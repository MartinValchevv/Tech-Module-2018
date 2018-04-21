function Largest3Numbers(arr) {
let nums = arr.map(Number);

nums.sort((a, b ) => b - a );

    let counnt = Math.min(3, arr.length);
    for (let i = 0; i < counnt; i++) {
       console.log(nums[i]);

    }
}

Largest3Numbers([

    '30',

    '20',


]);