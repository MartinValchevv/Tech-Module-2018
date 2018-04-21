function solve(arr) {
    let input = arr.map(line => JSON.parse(line));
    let towns = {};
    for (let entry of input) {
        if (towns[entry.town] === undefined) {
            towns[entry.town] = 0;
        }
        towns[entry.town] += entry.income;
    }
    let townsName = Object.keys(towns).sort();
    for (let name of townsName ) {
        console.log(`${name} -> ${towns[name]}`);
    }
}