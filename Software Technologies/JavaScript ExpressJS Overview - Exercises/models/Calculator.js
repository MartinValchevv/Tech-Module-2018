class Calculator {
    constructor(operator, leftOperand, rightOperand) {
        this.operator = operator;
        this.leftOperand =leftOperand;
        this.rightOperand = rightOperand;
    }

    calculate(){
      return operations[this.operator](this.leftOperand, this.rightOperand);
    }
}

const operations = {
    '+': (a, b) => a + b,
    '-': (a, b) => a - b,
    '*': (a, b) => a * b,
    '/': (a, b) => a / b,
};

module.exports = Calculator;