// var string ="susmitha"
// console.log(string);

class Animal{
    readonly name1:string;
    private species :string;
    /**
     *
     */
    constructor(name1:string,species:string) {
        this.name1=name1;
        this.species=species;
        
    }

    get getspecies():string{
        return this.species;
    }
    set setspecies(sp:string){
        this.species=sp;
    }
    move(feet:number):void{
        console.log(`The animal is ${this.name1} moved ${feet} feet`)
    }
}
let an=new Animal('Bunty','Lab');
an.move(5);

class Dog extends Animal{
    bark():void{
        console.log("bow bow");
    }
}
let m=new Dog("joh","poo");
m.bark();
m.move(2);


abstract class car{
    alarm():void{
        console.log("beep");
    }
}
class sportcar extends car{
    drive():void{
        console.log("driving...");
    }
}
let sc=new sportcar();
sc.alarm();
sc.drive();


