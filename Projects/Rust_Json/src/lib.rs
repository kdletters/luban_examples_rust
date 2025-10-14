#[path = "gen/luban/cfg/mod.rs"]
pub mod cfg;

use cfg::prelude::*;
use lazy_static::lazy_static;
use serde_json::Value;
use std::path::PathBuf;

lazy_static! {
    pub static ref TABLES: Tables = {
        let tables = Tables::new(|name| {
            let path = PathBuf::from(format!("../GenerateDatas/json/{}.json", name));
            match serde_json::from_str::<Value>(std::fs::read_to_string(path).unwrap().as_str()) {
                Ok(t) => Ok(t),
                Err(e) => Err(LubanError::Loader(format!("{}", e))),
            }
        });
        tables.expect("REASON")
    };
}

#[derive(Debug, Hash, Eq, PartialEq, luban_macros::EnumFromNum)]
pub enum CustomAudioType {
    UNKNOWN = 0,
    ACC = 1,
    AIFF = 2,
}

impl From<i32> for CustomAudioType {
    fn from(value: i32) -> Self {
        match value {
            0 => CustomAudioType::UNKNOWN,
            1 => CustomAudioType::ACC,
            2 => CustomAudioType::AIFF,
            _ => panic!("Invalid value for CustomAudioType:{}", value),
        }
    }
}

impl From<cfg::AudioType> for CustomAudioType {
    fn from(value: AudioType) -> Self {
        match value {
            AudioType::UNKNOWN => CustomAudioType::UNKNOWN,
            AudioType::ACC => CustomAudioType::ACC,
            AudioType::AIFF => CustomAudioType::AIFF,
        }
    }
}

#[derive(Debug, Clone, PartialEq)]
pub struct Vec2 {
    pub x: f32,
    pub y: f32,
}

impl From<cfg::vec2> for Vec2 {
    fn from(value: vec2) -> Self {
        Self {
            x: value.x,
            y: value.y,
        }
    }
}

#[derive(Debug, Clone, PartialEq)]
pub struct Vec3 {
    pub x: f32,
    pub y: f32,
    pub z: f32,
}

impl From<cfg::vec3> for Vec3 {
    fn from(value: vec3) -> Self {
        Self {
            x: value.x,
            y: value.y,
            z: value.z,
        }
    }
}

#[derive(Debug, Clone, PartialEq)]
pub struct Vec4 {
    pub x: f32,
    pub y: f32,
    pub z: f32,
    pub w: f32,
}

impl From<cfg::vec4> for Vec4 {
    fn from(value: vec4) -> Self {
        Self {
            x: value.x,
            y: value.y,
            z: value.z,
            w: value.w,
        }
    }
}