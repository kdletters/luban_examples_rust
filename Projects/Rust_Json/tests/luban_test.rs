use Rust_json::cfg::prelude::*;
use Rust_json::TABLES;

#[test]
pub fn test_tables() {
    let row = TABLES.TbFullTypes.data_list[0].clone();
    println!("{:?}", row.x1);
    println!("{:?}", row.x2);
    println!("{:?}", row.x3);
    println!("{:?}", row.x4);
    println!("{:?}", row.x5);
    println!("{:?}", row.x6);
    println!("{:?}", row.x7);
    println!("{:?}", row.x8);
    println!("{:?}", row.x9);
    println!("{:?}", row.x10);
    println!("{:?}", row.x12);
    println!("{:?}", row.x13);
    println!("{:?}", row.x14);
    println!("{:?}", row.s1);
    println!("{:?}", row.t1);
    println!("{:?}", row.k1);
    println!("{:?}", row.k2);
    println!("{:?}", row.k5);
    println!("{:?}", row.k8);
    println!("{:?}", row.k9);
    println!("{:?}", row.k15);
}

#[test]
pub fn test_one_table() {
    println!("{:?}", TABLES.TbSingleton.data)
}

#[test]
pub fn test_list_table() {
    println!("{:?}", TABLES.TbNotIndexList.data_list);
    assert_eq!(TABLES.TbNotIndexList.data_list.len(), 5);
    let item = TABLES.TbNotIndexList.data_list[0].clone();
    assert_eq!(item.x, 1);
    assert_eq!(item.y, 2);
}

#[test]
pub fn test_union_key_table() {
    println!("{:?}", TABLES.TbMultiUnionIndexList);
    assert_eq!(TABLES.TbMultiUnionIndexList.data_list.len(), 11);
    let item = TABLES
        .TbMultiUnionIndexList
        .get(&(1, 1, "ab1".to_string()))
        .unwrap();
    assert_eq!(item.num, 1);
    assert_eq!(item.desc, "desc1".to_string());
}

#[test]
pub fn test_multi_key_table() {
    println!("{:?}", TABLES.TbMultiIndexList);
    assert_eq!(TABLES.TbMultiIndexList.data_list.len(), 11);
    let item = TABLES.TbMultiIndexList.get_by_id1(&1).unwrap();
    assert_eq!(item.num, 1);
    assert_eq!(item.desc, "desc1".to_string());
}

#[test]
pub fn test_flags() {
    println!("{:?}", TABLES.TbDefineFromExcel2);
    let e = &TABLES.TbDefineFromExcel2.data_list[0].x13_2;
    assert!(e.is_empty());
    let e = &TABLES.TbDefineFromExcel2.data_list[1].x13_2;
    assert!(e.eq(&DemoFlag::from(DemoFlag::A | DemoFlag::B)));
}

#[test]
pub fn test_polymorphic() {
    println!("{:?}", TABLES.TbFullTypes.data_list[0].k15);
}

#[test]
pub fn test_array() {
    let row = TABLES.TbFullTypes.data_list[0].clone();
    println!("{:?}", row.k1)
}

#[test]
pub fn test_float() {
    let row = TABLES.TbFullTypes.data_list[0].clone();
    println!("{:?}", row.x6);
    assert_eq!(1.28_f32, row.x6);
}

#[test]
pub fn test_double() {
    let row = TABLES.TbFullTypes.data_list[0].clone();
    println!("{:?}", row.x7);
    assert_eq!(1.23457891_f64, row.x7);
}

#[test]
pub fn test_map() {
    let row = TABLES.TbAutoImport1.data_list[0].clone();
    println!("{:?}", row.v2);
}