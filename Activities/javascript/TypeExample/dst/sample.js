"use strict";
// var string ="susmitha"
// console.log(string);
class Animal {
    /**
     *
     */
    constructor(name1, species) {
        this.name1 = name1;
        this.species = species;
    }
    get getspecies() {
        return this.species;
    }
    set setspecies(sp) {
        this.species = sp;
    }
    move(feet) {
        console.log(`The animal is ${this.name1} moved ${feet} feet`);
    }
}
let an = new Animal('Bunty', 'Lab');
an.move(5);
class Dog extends Animal {
    bark() {
        console.log("bow bow");
    }
}
let m = new Dog("joh", "poo");
m.bark();
m.move(2);
class car {
    alarm() {
        console.log("beep");
    }
}
class sportcar extends car {
    drive() {
        console.log("driving...");
    }
}
let sc = new sportcar();
sc.alarm();
sc.drive();
