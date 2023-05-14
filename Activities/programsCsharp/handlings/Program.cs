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
// using System;
// using System.IO;
// public class program {
//     public static void Main(string [] args){
//         string path =@"../handlings/file.txt";

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
//         string path=@"../handlings/file.txt";
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
  //       List<Employee> emp = new List<Employee>();

  //       emp.Add(new Employee(){id=1,Name ="saiPrasad",salary="89076",Experience =5});
  //       emp.Add(new Employee(){id=2,Name ="saiKrishna",salary="89076",Experience =6});

  //       Employee.pEmployee(emp);
  //   }
  // }
  

// C# program to illustrate the 
// concept of out parameter 
using System; 

class GFG { 

	// Main method 
	static public void Main() 
	{ 

		// Declaring variable 
		// without assigning value 
		int G; 

		// Pass variable G to the method 
		// using out keyword 
		Sum(out G); 

		// Display the value G 
		Console.WriteLine("The sum of" + 
				" the value is: {0}", G); 
	} 

	// Method in which out parameter is passed 
	// and this method returns the value of 
	// the passed parameter 
	public static void Sum(out int G) 
	{ 
		G = 80; 
		G += G; 
	} 
} 
