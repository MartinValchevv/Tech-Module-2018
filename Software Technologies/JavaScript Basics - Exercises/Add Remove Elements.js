function AddRemoveElement(args) {
    let arr = [];

    for (let obj of args) {
        let input = obj.split(' ');

        let comand = input[0];

        switch (comand) {
            case "add":
                arr.push(input[1]);
                break;
            case "remove":
                let index = Number(input[1]);
                arr.splice(index, 1);
                break;
        }
    }

    console.log(arr.join("\n"));

}