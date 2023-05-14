// =-=-=-inhertance=-=-=-=-=-=-=---------------------=-
// class Person
// {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }

//     public string GetFullName(){ 
//         return FirstName + " " + LastName;
//     }
// }

// class Employee : Person
// {
//     public int EmployeeId { get; set; }
//     public string CompanyName { get; set; }
    
// }
// class program{

// public static void Main(string[] args){
// Employee emp = new Employee();
// emp.FirstName = "Steve";
// emp.LastName = "Jobs";
// emp.EmployeeId = 1;
// emp.CompanyName = "Apple";
// var fullname = emp.GetFullName(); //Steve Jobs 
// }
// }


//=-=-=-=-=-=Method hiding--=--=============-=-=-=
// using System;
// namespace practice{
//     public class Employee{
//         public virtual void BaseClass(){
//             Console.WriteLine("Base class Method");
//         }
//     }
//     public class DerivedClass:Employee{
//         public new void BaseClass(){
//             Console.WriteLine("dervied class Method"); 

//         }
//     }
//     public class program{
//         public static void Main(){
//             Employee Emp=new DerivedClass();
//             Emp.BaseClass();  prints base class method

//         }
//     }
// }
//-==-=-=-=-=METHOD OVERRIDING=-=-=-=-=-==-------------------------------=-=-=
// using System;
// namespace practice{
//     public class Employee{
//         public virtual void BaseClass(){
//             Console.WriteLine("Base class Method");
//         }
//     }
//     public class DerivedClass:Employee{
//         public override void BaseClass(){
//             Console.WriteLine("dervied class Method");

//         }
//     }
//     public class program{
//         public static void Main(){
//             Employee Emp=new DerivedClass();
//             Emp.BaseClass();// prints derived class method

//         }
//     }
// }
//=-=-=-=-=-=-Abstraction-=-=-=-==--========-=-=-=-=-=-=-=-=-=-=
// using System;
// namespace practice{
//      abstract  class Animal{ //Inetrfaec
//         public abstract void Printsound();
//         public void Sound(){
//             Console.WriteLine("WEWEwE");
        
//     }
        
//     }
//      class Pig:Animal{
//         public override void Printsound()
//         {
//             Console.WriteLine("Hahahahah");
//         }
//     }

//     public class program{
//         public static void Main(){
//             Pig pig =new Pig();
//             pig.Printsound();
//             pig.Sound();

//         }
//     }
    
// }
//-------------static constructor-====================================
// using System;
// public class geeks{
//  static int s;
//  int ns;

//  static geeks(){
//     Console.WriteLine("This is static constructor called before instance of a class");
//  }
//  public geeks(){
//     Console.WriteLine("Non static constructor");

//  }
// }
// public class program{
//     public static void Main(){
//         geeks g=new geeks();

//     }
// }
//========================enum==========================
//class Program
// {
//   enum Level
//   {
//     Low,
//     Medium,
//     High
//   }
//   static void Main(string[] args)
//   {
//     Level myVar = Level.Medium;
//     Console.WriteLine(myVar);
//   } prints medium as output

//*****************ArrayList****************************8
// using System;
// using System.Collections;
// public class proram{
//     public static void Main(){
//         var arrlist= new ArrayList();
//          var arrlist2= new ArrayList(){ 23,"saiRiyan",676};
//          int[] arr = new int[4]{1,2,3,4};
//          Queue<string> val=new Queue<string>();
//          val.Enqueue("hello");
//          val.Enqueue("riyan");

//          arrlist.AddRange(arrlist2);
//          arrlist.AddRange(val);
//          arrlist.AddRange(arr);


//          foreach(var i in arrlist){
//             Console.WriteLine(i);
//          }
//     }
//}
//**********************list************** insert,remove,removeat,
//using System;
// using System.Collections.Generic;
// public class Student{
//     public int id {get;set;}
//     public string name{get;set;}

// }
// public class program{
//     public static void Main(){
//      List<Student> students=new List<Student>(){
//         new Student() { id=1,name="saiprasad"},
//         new Student(){ id=2,name="Riyan"},
//         new Student(){id=3,name="VenkataLakshmi"},
//         new Student(){id=4,name="AppaRao"}
//      };
//      students.RemoveAt(2);
//      //students.Insert(2,3,venkatalaksmi);
//      //tudents.Contains();

//      foreach(var l in students){
//         Console.WriteLine("Id={0},Name={1}",l.id,l.name);
//      }
//     }
// }
///*******************SortedList**************************remove
// using System.Collections.Generic;
// public class program{
//     public static void Main(){
//         SortedList<int,string> newonelist=new SortedList<int, string>();
//         newonelist.Add(1,"Riyan");
//         newonelist.Add(3,"AppaRao");
//         newonelist.Add(4,"Sai");

//         //updating vaalue at specify key
//         newonelist[2]="VEnkataLakshmi";
//         newonelist.Remove(2);

//         foreach(var mew in newonelist){
//             Console.WriteLine("KEy:{0},Value:{1}",mew.Key,mew.Value);
//         }
//     }
// }
// //*****************Dictionary***************************
// public class program{
//     public static void Main(){
//         Dictionary<int,string> newonelist=new Dictionary<int, string>();
//         newonelist.Add(1,"Riyan");
//         newonelist.Add(3,"AppaRao");
//         newonelist.Add(2,"Sai");

//         //updating vaalue at specify key
//         newonelist[2]="VEnkataLakshmi";

//         foreach(var mew in newonelist){
//             Console.WriteLine("KEy:{0},Value:{1}",mew.Key,mew.Value);
//         }
//     }
// }
///************hashtable*****************
//using System.Collections;
// public class program{
//     public static void Main(){
//         Hashtable tb= new Hashtable(){
//             {1,"one"},
//             {2,"Three"},
//             {3,"three"}
//         };
//         tb[2]="two";

//         foreach(DictionaryEntry em in tb){
//             Console.WriteLine("KEy:{0},value:{1}", em.Key,em.Value);
//         }
//         //tb.Add(1,"one");
//     }
// }
//**************Hashset****************
// C# program to illustrate how to
// create hashset
//using System;
//using System.Collections.Generic;

// class GFG {

// 	// Main Method
// 	static public void Main()
// 	{

// 		// Creating HashSet
// 		// Using HashSet class
// 		HashSet<string> myhash1 = new HashSet<string>();

// 		// Add the elements in HashSet
// 		// Using Add method
// 		myhash1.Add("C");
// 		myhash1.Add("C++");
// 		myhash1.Add("C#");
// 		myhash1.Add("Java");
// 		myhash1.Add("Ruby");
// 		Console.WriteLine("Elements of myhash1:");

// 		// Accessing elements of HashSet
// 		// Using foreach loop
// 		foreach(var val in myhash1)
// 		{
// 			Console.WriteLine(val);
// 		}

// 		// Creating another HashSet
// 		// using collection initializer
// 		// to initialize HashSet
// 		HashSet<int> myhash2 = new HashSet<int>() {10,
// 							100,1000,10000,100000};
				
// 		// Display elements of myhash2
// 		Console.WriteLine("Elements of myhash2:");
// 		foreach(var value in myhash2)
// 		{
// 			Console.WriteLine(value);
// 		}
	//}
//}


//***********Linkedlist*************
// public class progra{
//     public static void Main(){
//         LinkedList<string> names=new LinkedList<string>();
//         names.AddFirst("Raiyan");
//         names.AddLast("sai");
//         var find =names.Find("sai");
//         names.AddBefore(find,"Apparao");
//         names.AddAfter(find,"Lakshmi");
//         var node =new LinkedListNode<string>("Niharika");
//         //names.AddLast(node);
//         names.AddFirst(node);


//         foreach(var e in names){
//             Console.WriteLine(e);
//         }
//     }
// }

// using System;
// public class userdefinedException:Exception
// {
//     public userdefinedException(string message): base(message){

//     }
// }
// public class program{

//     public void validate(int age){
//         if(age<18){
//             throw (new userdefinedException("Sorry age cant be less"));
//         }
//     }
//     public static void Main(string[] args){
//         try{
//         program p = new program();
//         p.validate(12);
//         }
//         catch(userdefinedException e){
//         Console.WriteLine(e.Message);

//     }
   

//     }
// }


// using System;
// public class fitnessException:Exception{
//     public  fitnessException(string message):base(message){

//     }
// }
// public class test{
//     int points =0;
//     public void details(){
//     if(points<110){
//         throw (new fitnessException("failed"));

//     }
//     else{
//         Console.WriteLine("passed");
//     }
//     }
// }
// public class program{
//     public static void Main(String[] args){
//         try{
//             test t = new test();
//             t.details();
//         }
//         catch(fitnessException e){
//             Console.WriteLine(e.Message);
//         }
//     }
// }


//************ File Handling refers to the various operations like creating the file,
// reading from the file, writing to the file, appending the file, ************

// using System;
// using System.IO;
// public class program {
//     public static void Main(string [] args){
//         string path =@"../practice/open.txt";

//         string text = "this is first file";
//         File.WriteAllText(path,text);
//         Console.WriteLine(File.ReadAllText(path));
//         Console.WriteLine();

//         string [] texts = {"this is apple","this is bannaa","this is lemon"};
//         File.WriteAllLines(path,texts);
//         Console.WriteLine(File.ReadAllText(path));
        

        
 //   }
//}
  


// using System;
// using System.IO;
// public class program{
//     public static void Main(string [] args){
//      string path =@"../practice/open.txt";
//         if(File.Exists(path)){
//             string[] str =File.ReadAllLines(path);
//             foreach(string ln in str){
//             Console.WriteLine(ln);
//             }
//         }

//     }
// }
// using System;
// using System.IO;
// namespace programsCsharp;
// public class writeToFile{
//     public void data(){
//         StreamWriter sw = new StreamWriter(@"../handlings/file.txt");
//         string? str = Console.ReadLine();
//         sw.WriteLine(str);
//         sw.Flush();
//         sw.Close();

//     }
// }
// public class program{
//     public static void Main(string[]args){
//         writeToFile wf = new writeToFile();
//         wf.data();

//     }
// }
// using System;
// using System.IO;
      
//     public class readTofile{
//     public void Readdata(){
//         StreamReader sr = new StreamReader(@"../handlings/file.txt");
//         sr.BaseStream.Seek(0,SeekOrigin.Begin);
//         string? str = sr.ReadLine();
//         while(str != null){
//             Console.WriteLine(str);
//             str =sr.ReadLine();
//         }
//     }
// }
// public class program{
//     public static void Main(string[] args){
//         readTofile rf = new readTofile();
//         rf.Readdata();

//     }
// }
 

 //Delegates
 //using System;
  //  public class Employee{
  //   public int id {get;set;}
  //   public string ?Name {get;set;}
  //   public string ?salary {get;set;}
  //   public int Experience {get;set;}


  //   public  static void pEmployee(List<Employee> empList){
  //       foreach(Employee emp in empList){
  //           if(emp.Experience>5){
  //               Console.WriteLine(emp.Name +"Is promoted");
  //           }
  // //       }
  // //   }
  // // }
  // // class program{
  //   public static void Main(String[] args){
  //       List<Employee> emp = new List<Employee>(){

  //       new Employee(){id=1,Name ="saiPrasad",salary="89076",Experience =5},
  //       new Employee(){id=2,Name ="saiKrishna",salary="89076",Experience =6},};
  

  //       Employee.pEmployee(emp);
  //   }
  // }
  //using System;
//    public class Employee{
//     public int id {get;set;}
//     public string ?Name {get;set;}
//     public string ?salary {get;set;}
//     public int Experience {get;set;}


//     public  static void pEmployee(List<Employee> empList,Mydelegate ispromote ){
//         foreach(Employee emp in empList){
//             if(ispromote(emp)){
//                 Console.WriteLine(emp.Name +"Is promoted");
//             }
           
//         }
       
//     }
 
//   }
  

//   public delegate bool Mydelegate(Employee ispromoteable);
        

//   class program{
//     public static void Main(String[] args){
//         List<Employee> emp = new List<Employee>();

//         emp.Add(new Employee(){id=1,Name ="saiPrasad",salary="89076",Experience =5});
//         emp.Add(new Employee(){id=2,Name ="saiKrishna",salary="89076",Experience =6});
           
//       //Mydelegate del = new Mydelegate(promote);
//       //Employee.pEmployee(emp,del);
//  //using lamda expressions
//         Employee.pEmployee(emp,emp=>emp.Experience>5);
//     } 
    
    //   public static bool promote(Employee emp1){
    //     if(emp1.Experience>6){
    //        return true;
    //     }
    //     else{
    //        return false;
    //     }

    // }

//   }
//using System;




//public delegate  void mydelegate();




// class program{
//     public static void Main(string []args){
//         //happay p=new happay();
//         mydelegate del = new mydelegate(Myfirstmethod);
//         del+=Mysecondtmethod;
//         del+=MyThirdmethod;
//         //del-=Myfirstmethod;
//         //del -=MyThirdmethod;
//         del();


//     }
//    // class happay{


//       public static  void Myfirstmethod(){

//         Console.WriteLine("my first");
//     }
//       public  static void Mysecondtmethod(){

//         Console.WriteLine("my second");
//     }
//       public  static void MyThirdmethod(){

//         Console.WriteLine("my third");
//     }
//    }



// }
// C# program to illustrate Action delegates no return type
// using System;

// class GFG {

// 	// Method
// 	public static void myfun(int p, int q)
// 	{
// 		Console.WriteLine(p - q);
// 	}

// 	// Main method
// 	static public void Main()
// 	{

// 		// Using Action delegate
// 		// Here, Action delegate
// 		// contains two input parameters
// 		Action<int, int> val = myfun;
// 		val(20, 5);
// 	}
// }

// C# program to illustrate Predicate delegates bool return typewith input paraters
//using System;

// class GFG {

// 	// Method
// 	public static bool myfun(string mystring)
// 	{
// 		if (mystring.Length < 7)
// 		{
// 			return true;
// 		}
// 		else
// 		{
// 			return false;
// 		}
// // 	}

// 	// Main method
// 	static public void Main()
// 	{

// 		// Using predicate delegate
// 		// here, this delegate takes
// 		// only one parameter
// 		Predicate<string> val = myfun;
// 		Console.WriteLine(val("GeeksforGeeks"));
// 	}
// }

// C# program to illustrate Func delegate
//using System;
// The Func delegate takes zero, one or more input parameters, and returns a value (with its out parameter).
// Action takes zero, one or more input parameters, but does not return anything.

// class GFG {

// 	// Method
// 	public static int mymethod(int s, int d, int f, int g)
// 	{
// 		return s * d * f * g;
// 	}

// 	// Main method
// 	static public void Main()
// 	{

// 		// Using Func delegate
// 		// Here, Func delegate contains
// 		// the four parameters of int type
// 		// one result parameter of int type
// 		Func<int, int, int, int, int> val = mymethod;
// 		Console.WriteLine(val(10, 100, 1000, 1));
// 	}
// }



  

// C# program to illustrate the 
// concept of out parameter 
//using System; 

//class GFG { 

	// Main method 
	// static public void Main() 
	// { 

	// 	// Declaring variable 
	// 	// without assigning value 
	// 	int G; 

	// 	// Pass variable G to the method 
	// 	// using out keyword 
	// 	Sum(out G); 

	// 	// Display the value G 
	// 	Console.WriteLine("The sum of" + ///prints 160
	// 			" the value is: {0}", G); 
	// } 
//  public static void Sum(out int G)
//     {
//         G = 80;
//         G += G;
//     }
// }

// C# program to illustrate the
// concept of ref parameter
// using System;

// class GFG {

	// // Main Method
	// public static void Main()
	// {

	// 	// Assign string value
	// 	string str = "Geek";

	// 	// Pass as a reference parameter
	// 	SetValue(ref str);

	// 	// Display the given string
	// 	Console.WriteLine(str); prints geekforgeeks(bi diretional)
	// }

	// static void SetValue(ref string str1)
	// {

	// 	// Check parameter value
	// 	if (str1 == "Geek") {
	// 		Console.WriteLine("Hello!!Geek");
	// 	}

	// 	// Assign the new value
	// 	// of the parameter
	// 	str1 = "GeeksforGeeks";
	// }
//}

  //***************Binary serilization***************************
//In C#, serialization is the process of converting object into byte stream so that it can be saved to memory, file or database.

	// using System;
  // using System.IO;
  // using System.Runtime.Serialization.Formatters.Binary;
  // [Serializable]
  // public class Employee{
  //   public int id ;
  //   public string Name;
  //   public Employee(int id,string name){
  //     this.id=id;
  //     this.Name=name;
  //   }
  // }
  //  public class Program{
  //   public static void Main(){
  //     FileStream fs=new FileStream(@"../open.txt",FileMode.OpenOrCreate);
  //     BinaryFormatter format=new BinaryFormatter();
  //     Employee emp = new Employee(1,"Riyan");
  //     format.Serialize(fs,emp);
  //     fs.Close();
  //   }
  // }
// public class DeserializeExample  
// {  
//     public static void Main(string[] args)  
//     {  
//         FileStream stream = new FileStream("../open.txt", FileMode.OpenOrCreate);  
//         BinaryFormatter formatter=new BinaryFormatter();  
  
//         Employee s=(Employee)formatter.Deserialize(stream);  
// //         Console.WriteLine("Rollno: " + s.id);  
// //         Console.WriteLine("Name: " + s.Name);  
  
// //         stream.Close();  
// //     }  
// // }  
//************JSon seriization*************************************
//using System;
// using System.IO;
// using System.Runtime.Serialization.Json;
// using Newtonsoft.Json;
// using System.Collections.Generic;
// [Serializable]
// public class Employee{
//     public int id{get;set;} 
  //   public string? Name{get;set;}

  // // }
  // public class Program{
  //   public static void Main(){
  //   var employees = new List<Employee>{
  //     new Employee(){id=1,Name="sai"},
  //      new Employee(){id=2,Name="Riyan"},
  //       new Employee(){id=3,Name="AppaRao"}

  //   };
  


     
     //var jsondata=JsonConvert.SerializeObject(employees);
     // Console.WriteLine(jsondata);


      // string jsonstring=" [{\"id\":1,\"Name\":\"sai\"},{\"id\":2,\"Name\":\"Riyan\"},{\"id\":3,\"Name\":\"AppaRao\"}]";
      // var ans =JsonConvert.DeserializeObject<List<Employee>>(jsonstring);
      // foreach(var l in ans){
      //   Console.WriteLine(l.Name);
//       }
   
//     }
//     }
// }

//**************Lamda Expressions****************************
    // using System;
    // public class Program{
    //   public static void Main(){
    //     List<int> numbers = new List<int>{1,2,3,4,56,7,8,9,23,45};
    //    List<int> values=numbers.FindAll(x=>(x%2)==0).ToList();
    //    foreach(int v in values){
    //     Console.Write("{0},",v);
    //    }
    //   }
    // }
  //===================Refelection=====================================
//  using System;
//  using System.Reflection;
// namespace learn{
    // public class Customer{
    //     public int id {get;set;}
    //     public string name{get;set;}
    //     public Customer(int Id ,string Name){
    //         this.id=Id;
    //         this.name=Name;

    //    }
   
    //     public void printId(){
    //         Console.WriteLine("Id={0}",this.id);
    //        }
    //     public void printName(){
    //               Console.WriteLine("name={0}",this.name);
    //      }
    // }

 //}
//  public class Program{
//     private static void Main(){
//         Type T=Type.GetType("learn.Customer");
//         Console.WriteLine("FullName={0}",T.FullName);
//         Console.WriteLine("className={0}",T.Name);
//         Console.WriteLine("namespaceNAme={0}",T.Namespace);
//        PropertyInfo[] properties =T.GetProperties();
//        foreach(PropertyInfo property in properties){
//         Console.WriteLine(property.PropertyType+ " " + property.Name);
//        }
//        Console.WriteLine("");
//        MethodInfo[] methods =T.GetMethods();
//        foreach(MethodInfo method in methods){
//         Console.WriteLine(method.ReturnType.Name+"  "+method.Name);
//        }
//       Console.WriteLine("");
//        ConstructorInfo[] constructors =T.GetConstructors();
//        foreach(ConstructorInfo constructor in constructors){
//         Console.WriteLine( constructor.ToString());
//        }
//     }
// }

// late binding example===================================================

//using System;
//using System.Reflection;
//namespace learn{
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

//      }
//}
// public class Customer{
//     public string getfullname(string Fname ,string Lname){
//         return Fname+" "+ Lname;
//     }
// }
//}
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
        //var query=students.where(s=>s.age>18);
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
    //using System;  
  
// class Program  
// {  
//     // This is the entry point of a C# program  
//     static void Main(string[] args)  
//     {  
//         // Main execution starts here  
//         Console.WriteLine("Main thread starts here.");  
  
//         // This method takes 4 seconds to finish.  
//         Program.DoSomeHeavyLifting();      
  
//         // This method doesn't take anytime at all.  
//         Program.DoSomething();  
  
//         // Execution ends here  
//         Console.WriteLine("Main thread ends here.");  
//         Console.ReadKey();  
//     }  
  
//     public static void DoSomeHeavyLifting()  
//     {  
//         Console.WriteLine("I'm lifting a truck!!");  
//         Thread.Sleep(1000);  
//         Console.WriteLine("Tired! Need a 3 sec nap.");  
//         Thread.Sleep(1000);  
//         Console.WriteLine("1....");  
//         Thread.Sleep(1000);  
//         Console.WriteLine("2....");  
//         Thread.Sleep(1000);  
//         Console.WriteLine("3....");  
//         Console.WriteLine("I'm awake.");  
//     }  
//     public static void DoSomething()  
//     {  
//         Console.WriteLine("Hey! DoSomething here!");  
//         for (int i = 0; i < 20; i++)  
//             Console.Write($"{i} ");  
//         Console.WriteLine();  
//         Console.WriteLine("I'm done.");  
//     }  
// }  
// static void Main(string[] args)    
  // {  
//     // Main execution starts here  
//     Console.WriteLine("Main thread starts here.");  
  
//     // Create a thread   
//     Thread backgroundThread = new Thread(new ThreadStart(Program.DoSomeHeavyLifting));  
    // // Start thread  
    // backgroundThread.Start();          
  
    // // This method doesn't take anytime at all.  
    // Program.DoSomething();  
  
    // // Execution ends here  
    // Console.WriteLine("Main thread ends here.");  
    // Console.ReadKey();  
//}  
//*****************foreground threads****************
// C# program to illustrate the
// concept of foreground thread
// using System;
// using System.Threading;

// class GFG {

// 	// Main method
// 	static void Main(string[] args)
// 	{

// 		// Creating and initializing thread
// 		Thread thr = new Thread(mythread);
	// 	thr.Start();
	// 	Console.WriteLine("Main Thread Ends!!");
	// }

	// // Static method
	// static void mythread()
	// {
	// 	for (int c = 0; c <= 3; c++) {

	// 		Console.WriteLine("mythread is in progress!!");
	// 		Thread.Sleep(1000);
	// 	}
	// 	Console.WriteLine("mythread ends!!");
	// }
//}
//***********8background thread**************************
// C# program to illustrate the
// concept of Background thread
// using System;
// using System.Threading;

// class GFG {

	// Main method
	// static void Main(string[] args)
	// {
	// 	// Creating and initializing thread
	// 	Thread thr = new Thread(mythread);

	// 	// Name of the thread is Mythread
	// 	thr.Name = "Mythread";
	// 	thr.Start();

	// 	// IsBackground is the property of Thread
	// 	// which allows thread to run in the background
	// 	thr.IsBackground = true;

	// 	Console.WriteLine("Main Thread Ends!!");
	// }

// 	// Static method
// 	static void mythread()
// 	{

// 		// Display the name of the
// 		// current working thread
// 		Console.WriteLine("In progress thread is: {0}",
// 							Thread.CurrentThread.Name);

// 		Thread.Sleep(2000);

// 		Console.WriteLine("Completed thread is: {0}",
// 						Thread.CurrentThread.Name);
// 	}
// }
//*******************8Asynchronous proramming*******************
// static async Task Main(string[] args)
// {
//     LongProcess();

//     ShortProcess();
// }

// static async void LongProcess()
// {
//     Console.WriteLine("LongProcess Started");

//     await Task.Delay(4000); // hold execution for 4 seconds

//     Console.WriteLine("LongProcess Completed");

// }

// static void ShortProcess() {
//     Console.WriteLine("ShortProcess Started");
            
//     //do something here
            
//     Console.WriteLine("ShortProcess Completed");    
// }


// class Program {
//     public   static async Task Main(string[] args)
//     {
//         emp e= new emp();

//         Task<int> result =  e.LongProcess();

//           e.ShortProcess();

//         var val = await result; // wait untile get the return value

//         Console.WriteLine("Result: {0}", val);

       
//     }
// }
// class emp
// {
//    public   async Task<int> LongProcess()
//     {
//         Console.WriteLine("LongProcess Started");

//         await Task.Delay(4000);

//         Console.WriteLine("LongProcess Completed");

//         return 10;
//     }

//     public   void ShortProcess()
//     {
//         Console.WriteLine("ShortProcess Started");

//         //do something here

//         Console.WriteLine("ShortProcess Completed");
//     }
// }











//=-=--=Singleton design Pattern=-=-=-=-=-=

//create C# program that requests three names of people from the user and store them in array of objects of type person

//using System;

// class Person
// {
//     public string Name { get; set; }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Person[] people = new Person[3];

//         for (int i = 0; i < 3; i++)
//         {
//             Console.Write("Enter name: ");
//             string name = Console.ReadLine();
//             people[i] = new Person { Name = name };
//         }

//         Console.WriteLine("\nPeople:");
//         foreach (Person person in people)
//         {
//             Console.WriteLine(person.Name);
//         }
//     }
// }

// public class disconnect
// {
//     public void tableprint()
//     {
//         SqlConnection conn = new SqlConnection("Server=LAPTOP-P683EMH0;Database=project_1;Trusted_Connection=True;Encrypt=False;");
//         conn.Open();
//         string query = "select Email,Phone_number,Gender from Trainer";
//         SqlDataAdapter sda=new SqlDataAdapter(query, conn);
//         DataSet ds= new DataSet();
//         DataTable dt= new DataTable();
//         sda.Fill(ds);
//         dt = ds.Tables[0];
//         foreach(DataRow dr in dt.Rows)
//         {  
//             Console.WriteLine($"{dr["Email"]},{dr["Phone_Number"]},{dr["gender"]}");
//         }

//     }
// }
// public class Connected {
//  public void printtables()
//     {
//         SqlConnection conn = new SqlConnection("Server=LAPTOP-P683EMH0;Database=project_1;Trusted_Connection=True;Encrypt=False;");
//         conn.Open();
//         string query = "Select Email,Phone_Number,Gender from Trainer";
//         SqlCommand cmd=new SqlCommand(query, conn);
//         SqlDataReader reader= cmd.ExecuteReader();
//         while (reader.Read())
//         {
//             Console.WriteLine(reader.GetString(0));
//             Console.WriteLine(reader.GetString(1));
//             Console.WriteLine(reader.GetString(2));
//         }
//     }
// }











