
/*!
<auto-generated>
    This code was generated by a tool.
    Changes to this file may cause incorrect behavior and will be lost if
    the code is regenerated.
</auto-generated>
*/


use super::*;
use serde::Deserialize;

#[derive(Debug)]
pub struct L10NDemo {
    pub id: i32,
    pub text: String,
}

impl L10NDemo{
    pub fn new(json: &serde_json::Value) -> Result<L10NDemo, LubanError> {
        let id = (json["id"].as_i64().unwrap() as i32);
        let text = json["text"].as_str().unwrap().to_string();
        
        Ok(L10NDemo { id, text, })
    }
}

#[derive(Debug)]
pub struct PatchDemo {
    pub id: i32,
    pub value: i32,
}

impl PatchDemo{
    pub fn new(json: &serde_json::Value) -> Result<PatchDemo, LubanError> {
        let id = (json["id"].as_i64().unwrap() as i32);
        let value = (json["value"].as_i64().unwrap() as i32);
        
        Ok(PatchDemo { id, value, })
    }
}


#[derive(Debug)]
pub struct TbL10NDemo {
    pub data_list: Vec<std::sync::Arc<crate::l10n::L10NDemo>>,
    pub data_map: std::collections::HashMap<i32, std::sync::Arc<crate::l10n::L10NDemo>>,
}

impl TbL10NDemo {
    pub fn new(json: &serde_json::Value) -> Result<std::sync::Arc<TbL10NDemo>, LubanError> {
        let mut data_map: std::collections::HashMap<i32, std::sync::Arc<crate::l10n::L10NDemo>> = Default::default();
        let mut data_list: Vec<std::sync::Arc<crate::l10n::L10NDemo>> = vec![];

        for x in json.as_array().unwrap() {
            let row = std::sync::Arc::new(crate::l10n::L10NDemo::new(&x)?);
            data_list.push(row.clone());
            data_map.insert(row.id.clone(), row.clone());
        }

        Ok(std::sync::Arc::new(TbL10NDemo { data_map, data_list }))
    }

    pub fn get(&self, key: &i32) -> Option<std::sync::Arc<crate::l10n::L10NDemo>> {
        self.data_map.get(key).map(|x| x.clone())
    }
}

impl std::ops::Index<i32> for TbL10NDemo {
    type Output = std::sync::Arc<crate::l10n::L10NDemo>;

    fn index(&self, index: i32) -> &Self::Output {
        &self.data_map.get(&index).unwrap()
    }
}


#[derive(Debug)]
pub struct TbPatchDemo {
    pub data_list: Vec<std::sync::Arc<crate::l10n::PatchDemo>>,
    pub data_map: std::collections::HashMap<i32, std::sync::Arc<crate::l10n::PatchDemo>>,
}

impl TbPatchDemo {
    pub fn new(json: &serde_json::Value) -> Result<std::sync::Arc<TbPatchDemo>, LubanError> {
        let mut data_map: std::collections::HashMap<i32, std::sync::Arc<crate::l10n::PatchDemo>> = Default::default();
        let mut data_list: Vec<std::sync::Arc<crate::l10n::PatchDemo>> = vec![];

        for x in json.as_array().unwrap() {
            let row = std::sync::Arc::new(crate::l10n::PatchDemo::new(&x)?);
            data_list.push(row.clone());
            data_map.insert(row.id.clone(), row.clone());
        }

        Ok(std::sync::Arc::new(TbPatchDemo { data_map, data_list }))
    }

    pub fn get(&self, key: &i32) -> Option<std::sync::Arc<crate::l10n::PatchDemo>> {
        self.data_map.get(key).map(|x| x.clone())
    }
}

impl std::ops::Index<i32> for TbPatchDemo {
    type Output = std::sync::Arc<crate::l10n::PatchDemo>;

    fn index(&self, index: i32) -> &Self::Output {
        &self.data_map.get(&index).unwrap()
    }
}