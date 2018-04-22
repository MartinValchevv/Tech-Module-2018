function storingObkects(args) {

    let result = [];

    for (let obj of args) {
        let input = obj.split(" -> ");
        let name = input[0];
        let age = input[1];
        let grade = input[2];

        let userNameInfo = {};

        userNameInfo['name'] = name;
        userNameInfo['age'] = age;
        userNameInfo['grade'] = grade;

        result.push(userNameInfo);
    }
    for (let obj of result) {
        console.log(`Name: ${obj.name}`);
        console.log(`Age: ${obj.age}`);
        console.log(`Grade: ${obj.grade}`);
    }
}