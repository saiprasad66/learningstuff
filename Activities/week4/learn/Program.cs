 using System;
 using System.Reflection;
namespace learn{
    public class Customer{
        public int id {get;set;}
        public string name{get;set;}
        public Customer(int Id ,string Name){
            this.id=Id;
            this.name=Name;

       }
        // public Customer(){
        //     this.id=-1;
        //     this.name= string.empty;
        // }
        public void printId(){
            Console.WriteLine("Id={0}",this.id);
           }
        public void printName(){
                  Console.WriteLine("name={0}",this.name);
         }
    }

 }
 public class Program{
    private static void Main(){
        Type T=Type.GetType("learn.Customer");
        Console.WriteLine("FullName={0}",T.FullName);
        Console.WriteLine("className={0}",T.Name);
        Console.WriteLine("namespaceNAme={0}",T.Namespace);
       PropertyInfo[] properties =T.GetProperties();
       foreach(PropertyInfo property in properties){
        Console.WriteLine(property.PropertyType+ " " + property.Name);
       }
       Console.WriteLine("");
       MethodInfo[] methods =T.GetMethods();
       foreach(MethodInfo method in methods){
        Console.WriteLine(method.ReturnType.Name+"  "+method.Name);
       }
      Console.WriteLine("");
       ConstructorInfo[] constructors =T.GetConstructors();
       foreach(ConstructorInfo constructor in constructors){
        Console.WriteLine( constructor.ToString());
       }
    }
}

// late binding example===================================================

// using System;
// using System.Reflection;
// namespace learn{
// public class Program{
//     public static void  Main(){
//       Assembly excute = Assembly.GetExecutingAssembly();
//       Type ? customertype =excute.GetType("learn.Customer");
//       object ?customerinstance =Activator.CreateInstance(customertype);
//        MethodInfo GetFullName =customertype.GetMethod("getfullname");
//        string[] parameters =new string[2];
//        parameters[0]="AppaRao";
//        parameters[1]="Telagavalasa";
//        string fullname =( string)GetFullName.Invoke(customerinstance,parameters);
//        Console.WriteLine("fullname={0}",fullname);

//     }
// }
// public class Customer{
//     public string getfullname(string Fname ,string Lname){
//         return Fname+" "+ Lname;
//     }
// }
// }
// using System;
// using System.Linq;
// using System.Collections.Generic;
//     public  class student{
    //     public int id {get;set;}
    //     public string name {get;set;}
    //     public int age{get;set;}
    // }


    // public class Program{
    // public static void Main(){
    //     List<student> students=new List<student>(){
    //         new student(){id =101,name="sai",age=22},
    //         new student(){id=102,name="vignesh",age=23},
    //         new student(){id=103,name="Riyan",age=6}

    //     };


        // var query=from v in students
        //           where v.age<18
        //           select v;
        //var query = from s in students
                   // orderby s.name,s.age
                    //select s;
       // Console.WriteLine("Adults");

       //------method sysntax
    //    var query =students.OrderBy(s=>s.name);
     //var query =students.OrderByDescending(s=>s.name);
    //  var query =students.OrderBy(s=>s.name).ThenBy(s =>s.age);
    // foreach(student s in query){
    //   Console.WriteLine("Name={0},Age={1}",s.name,s.age);

    // }
   


    

    // }
    // }

    // using System;
    // using System.Threading.Tasks;
    // public class Tasks{
    //     public  static void Main(){
    //         Task task =Task.Run( ()=>{
    //             int a=0;
    //             for(a=0;a<1000;a++){}
    //                 Console.WriteLine("{0} ends",a);
                
    //         });
    //         task.Wait();
    //     }
    // }
