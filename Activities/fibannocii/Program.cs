//using System;
// namespace FIBANNOCII;
// public class programs{
//      public int fiba(int number){
//         int n1=0,n2=1,n3;
//         if(number==0){
//             return n1;
//         }
        
        

//         for(int i=2;i<=number;i++){
//             n3=n1+n2;
//             n1=n2;
//             n2=n3;
//         }
//         return n2;
//      }




// }
// public class program
// {
//        public  static void Main(string[] args)
//        {
       
//         Console.WriteLine("enter an element to find fibanocii upto the number");
//             int N =Convert.ToInt32(Console.ReadLine());
//            N=N-1;
//             programs p=new programs();
//             Console.Write(p.fiba(N));
//         }

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
//    // }



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



//class Resource : IDisposable
//{

  //private bool dispose =false;
    // public void Dispose()
    // {
    //   Dispose(true);
    //   GC.SuppressFinalize(this);
    // }
    // private void  Dispose(bool disposing){
    //   if(!dispose){
    //     if(disposing){

    //     }
    //      dispose=true;
    //     //di//spose=true;
    //   }
     
      
    // }
    // ~Resource(){
    //     Dispose(false);
     // }
// }
// class program{
//   static void Main(){
//     Resource r= null;
//     try{
//       r= new Resource();
//     }
//     finally{
//       if(r!=null){
//         r.Dispose();
//       }
//     }
//   }
//}
  
// C# program to illustrate the 
// concept of out parameter 
using System; 

//lass GFG { 

	// // Main method 
	// public static void Main() 
	// { 

	// 	// Declaring variable 
	// 	// without assigning value 
	// 	int G; 

	// 	// Pass variable G to the method 
	// 	// using out keyword 
	// 	Sum(out G); 

	// 	// Display the value G 
	// 	Console.WriteLine("The sum of" + 
	// 			" the value is: {0}", G); 
	// } 

// 	// Method in which out parameter is passed 
// 	// and this method returns the value of 
// 	// the passed parameter 
// 	public static void Sum(out int G) 
// 	{ 
// 		G = 80; 
// 		G += G; 
// 	} 
// } 

// using System.IO;
// using System;
// public class Program {
//    public static void update(out int a){
//       a = 10;
//    }
//    public static void change(ref int d){
//       d = 11;
//    }
//    public static void Main() {
//       int b;
//       int c = 9;
//       Program p1 = new Program();
//       update(out b);
//       change(ref c);
//       Console.WriteLine("Updated value is: {0}", b);
//       Console.WriteLine("Changed value is: {0}", c);
//    }
// }



  // public static void Main(string[] args)  
  //   {  
  //       FileStream stream = new FileStream("e:\\sss.txt", FileMode.OpenOrCreate);  
  //       BinaryFormatter formatter=new BinaryFormatter();  
  
  //       Student s=(Student)formatter.Deserialize(stream);  
  //       Console.WriteLine("Rollno: " + s.rollno);  
  //       Console.WriteLine("Name: " + s.name);  
  
  //       stream.Close();  
  //   }  
//}  


using System;
public   class Happy{
    public void myfun(int p ,int q){
        Console.WriteLine(p*q);
    }
}
public class Program{
    public static void Main(){
        Happy h= new Happy();
        Action<int,int> val =h.myfun;
        val(10,4);
    }
}

    
