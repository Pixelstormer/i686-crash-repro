#[no_mangle]
pub extern "C" fn do_callback(managed_callback: extern "C" fn(i32)) {
    managed_callback(8);
}

#[no_mangle]
pub extern "C" fn get_value() -> i32 {
    8
}
