"use strict";
var CardinalDirections;
(function (CardinalDirections) {
    CardinalDirections[CardinalDirections["North"] = 1] = "North";
    CardinalDirections[CardinalDirections["East"] = 2] = "East";
    CardinalDirections[CardinalDirections["South"] = 3] = "South";
    CardinalDirections[CardinalDirections["West"] = 4] = "West";
})(CardinalDirections || (CardinalDirections = {}));
let getdirection = CardinalDirections.East;
console.log(getdirection);
// logs 1
console.log(CardinalDirections.North);
//objects
let ninja = {
    age: 20,
    name: 'sai'
};
let Ninja = {
    age: 20,
    name: 'sai'
};
console.log(ninja.age);
//arrays
let names = [1, 2, 3, 4]; //number array
let words = ['sai', 'prasad', 'riyan'];
let mixed = [1, 'sai', 44, true, 'riyan'];
mixed.sort(); //mixed array
//tupes- with fixed size and pedefined datatypes for each index
let mytuple;
mytuple = [65, 'riyan', true];
console.log(mytuple[0]);
//union types can be used when a value  can be more than a single type
function printstatuscode(code) {
    console.log(`status code is ${code}`);
}
printstatuscode(400);
printstatuscode('BadRequest');
const CarYear = 21;
const CarModel = 'Toyata';
const car = {
    year: CarYear,
    model: CarModel
};
console.log(car);
const logdetails = (uid, item) => {
    console.log(`${item} has a uid of ${uid}`);
};
const greetad = (user) => {
    console.log(`${user.name} say hello`);
};
logdetails('2', 'riyan');
//functions
let greet = () => {
    console.log("hello world!");
};
function add(n1, n2) {
    return n1 + n2;
}
console.log(add(2, 5));
const addition = (a, b) => {
    return (a + b);
};
console.log(addition(5, 7));
//====================Classes===============
class Department {
    constructor(n) {
        this.names = n;
    }
}
const value = new Department('riyan');
console.log(value.names);
//shorthand intilization
class Invoice2 {
    constructor(details, client, amount) {
        this.details = details;
        this.client = client;
        this.amount = amount;
    }
    format() {
        return `${this.client}   ${this.amount} for ${this.details}`;
    }
}
class Invoice {
    constructor(c, d, a) {
        this.client = c;
        this.details = d;
        this.amount = a;
    }
    format() {
        return `${this.client}   ${this.amount} for ${this.details}`;
    }
}
const invoice1 = new Invoice('Riyan', 'Go to school', 345);
console.log(invoice1.format());
//The super keyword is used to call the constructor of its
// parent class to access the parent's properties and methods.
class Person {
    constructor(name) {
        this.name = name;
    }
}
class teacher extends Person {
    constructor(name, payment) {
        super(name);
        this.name = name;
        this.payment = payment;
    }
    display() {
        console.log(`Teacher name is   ${this.name}`);
        console.log(`teacher payment is ${this.payment}`);
    }
}
const t2 = new teacher("riyan", 2000);
t2.display();
//======multilevel inheritance======================
class Vehicle {
    Type() {
        console.log("Car");
    }
}
// Inherites from Vehicle
class Car extends Vehicle {
    Brand() {
        console.log("ABC");
    }
}
// Inherites all properties of 
// Vehicle and Car class
class carModel extends Car {
    Model() {
        console.log("ABC2021");
    }
}
// Object creation
let obj = new carModel();
obj.Type();
obj.Brand();
obj.Model();
//abstract class===============
class Employee {
    constructor(firstname, lastname) {
        this.firstname = firstname;
        this.lastname = lastname;
    }
}
class FTemployee extends Employee {
    fullname() {
        console.log(`${this.firstname} ${this.lastname}`);
    }
    constructor(firstname, lastname) {
        super(firstname, lastname);
        this.firstname = firstname;
        this.lastname = lastname;
    }
}
const FTE = new FTemployee('sai', 'prasad');
FTE.fullname();
function add1(a, b) {
    return a + b;
}
add1("Hello ", "Steve"); // returns "Hello Steve" 
add1(10, 20); // returns 30
//method overrirding
class vehcile {
    info() {
        console.log("this is a vehicle");
    }
}
class bike extends vehcile {
    info() {
        console.log('This is a bike');
    }
}
const b = new bike();
b.info();
//_________-Generics----------------------
function genric(arg1, arg2) {
    console.log(arg1, arg2);
}
genric("hello", "world");
genric(2, 3);
