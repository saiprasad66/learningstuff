using System;
namespace programsCsharp;

 public class revstr
    {
        public string  isrev(string str2){
           
    
            char[] convertedarray = str2.ToCharArray();
            string reversestring = String.Empty;
            for(int i=convertedarray.Length-1;i>=0;i--){
            reversestring  += convertedarray[i];
           }
           return reversestring;
                //Array.Reverse(convertedarray);
                //return new string(convertedarray);
            
        }


     
    }
class program{

    public static void Main(string[] args){
        revstr S= new revstr();
        Console.WriteLine(S.isrev("saiPrasad"));
       // Console.Write("Enter a string");
        
       
    }

}


