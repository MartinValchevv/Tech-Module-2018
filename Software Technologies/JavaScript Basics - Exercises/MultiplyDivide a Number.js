function multiplayDivideNumber(nums) {
    let x = Number(nums[0]);
    let y = Number(nums[1]);
    let result = 0;

    if ( x <= y){
        result = x * y;
    } else {
        result = x / y;
    }

    console.log(result);
}