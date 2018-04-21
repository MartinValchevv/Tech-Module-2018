function capitalCase(arr) {
    let text = arr.join(",");
    let word = text.split(/\W+/);
    let nonEmptyWord = word.filter(w => w.length > 0);
    let upWords = nonEmptyWord.filter(isUpper);
    console.log(upWords.join(", "));
    
    function isUpper(str) {
        return str === str.toUpperCase();
    }
}

