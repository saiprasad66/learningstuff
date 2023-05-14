enum CardinalDirections {
    North = 1,
    East,
    South,
    West
  }
  let getdirection=CardinalDirections.East;
  console.log(getdirection);
  // logs 1
  console.log(CardinalDirections.North);
//objects
let ninja:{age:number,name:string}={
    age:20,
    name:'sai'
}
let Ninja={
    age:20,
    name:'sai'
}
console.log(ninja.age);
//arrays
let names=[1,2,3,4];//number array
let words=['sai','prasad','riyan'];
let mixed=[1,'sai',44,true,'riyan'];
mixed.sort();//mixed array


//tupes- with fixed size and pedefined datatypes for each index
let mytuple:[number,string,boolean];
mytuple=[65,'riyan',true]
console.log(mytuple[0]);


//union types can be used when a value  can be more than a single type
function printstatuscode(code:number|string){
    console.log(`status code is ${code}`)
}
printstatuscode(400);
printstatuscode('BadRequest');
 //type Aliases--Allow defining types with a custom name
 type caryear=number
 type carmodel=string

 type car={
    year:caryear,
    model:carmodel
 }
 const CarYear:caryear=21
 const CarModel:carmodel='Toyata'

 const car={
    year:CarYear,
    model:CarModel
 };
 console.log(car);


 type stringOrnum=string|number;
 const logdetails=(uid:stringOrnum,item:string)=>{
    console.log(`${item} has a uid of ${uid}`);
 }
 const greetad=(user:{name:string,uid:stringOrnum})=>{
    console.log(`${user.name} say hello`);
 }
 logdetails('2','riyan');

//functions
 let greet=()=>{
    console.log("hello world!");
 }
 function add(n1:number ,n2:number):number{
    return n1+n2;
 }
  console.log(add(2,5));

  const addition=(a:number,b:number):number=>{
    return(a+b);
  }
  console.log(addition(5,7));
  
  //====================Classes===============


  class Department{
    names:string;
    constructor(n:string){
        this.names=n;
    }
  }
  const value =new Department('riyan');
  console.log(value.names);

  //shorthand intilization
  class Invoice2{
    constructor(
        readonly details:string,
        public client:string,
        private amount:number
    ){}
    format(){
        return `${this.client}   ${this.amount} for ${this.details}`
    }
  }



  

  class Invoice{
    client:string;
   private details:string;
    amount:number;
    constructor(c:string,d:string,a:number){
        this.client=c;
        this.details=d;
        this.amount=a;

    }
    format(){
        return `${this.client}   ${this.amount} for ${this.details}`
    }
  }
  const invoice1=new Invoice('Riyan','Go to school',345);
  
  console.log(invoice1.format());

 
 
//The super keyword is used to call the constructor of its
// parent class to access the parent's properties and methods.

class Person{
  constructor(
    public name:string
  ){

  }
}
class teacher extends Person{
  
  constructor(
    public name:string,
    public payment:number){
    super(name);

  }
  display():void{
    console.log(`Teacher name is   ${this.name}`);
    console.log(`teacher payment is ${this.payment}`);
  }

}
 const t2=new teacher("riyan",2000);
 t2.display();
//======multilevel inheritance======================
 class Vehicle {
  Type(): void {
    console.log("Car");
  }
}
  
// Inherites from Vehicle
class Car extends Vehicle {
  Brand(): void {
    console.log("ABC");
  }
}
  
// Inherites all properties of 
// Vehicle and Car class
class carModel extends Car {
  Model(): void {
    console.log("ABC2021");
  }
}
  
// Object creation
let obj = new carModel();
obj.Type();
obj.Brand();
obj.Model();

//abstract class===============
abstract class Employee{
  constructor(
    public firstname:string,
    public lastname:string
  ){}
  
  abstract  fullname():void
   
  
}
class FTemployee extends Employee{
  fullname(): void {
    console.log(`${this.firstname} ${this.lastname}`);
  }
 
  constructor(
    public firstname:string,public lastname:string,
  ){
    super(firstname,lastname)
  }

}
const FTE=new FTemployee('sai','prasad');
FTE.fullname();

//function overloading
 function add1(a:string, b:string):string;
 

 function add1(a:number, b:number): number;

function add1(a: any, b:any): any {
    return a + b;
}

add1("Hello ", "Steve"); // returns "Hello Steve" 
add1(10, 20); // returns 30


//method overrirding
class vehcile{
info():void{
  console.log("this is a vehicle");
}
}
class bike extends vehcile{
  info():void{
    console.log('This is a bike');

  }

}
const b=new bike();
b.info();


//_________-Generics----------------------
function genric<t,u>(arg1:t,arg2:u):void{
  console.log(arg1,arg2);
}
 genric<string,string>("hello","world");
 genric<number,number>(2,3);
