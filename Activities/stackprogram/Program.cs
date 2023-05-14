// using System;
// namespace STACKPROGRAM;


// class program{
//     public static void Main()
//     {
//         Stack<string> name = new Stack<string>();
//         name.Push("saiprasad");
//         name.Push("Susmitha");
//         name.Push("Aishwarya");
//         name.Push("sailaja");




//         while(name.Count>0){
//             var result = name.Pop();
//             Console.WriteLine(result);
        
//     }

//     }


// }
using System;
public class program{
    public static void Main(string [] args){
        int cot =0;
        Console.Write("enter a string : ");
        string? str = Console.ReadLine();
        Console.WriteLine(str);
        while(str.Length>0){
            Console.Write(str[0] +" :");
            for(int j=0;j<str.Length;j++){
                if(str[0]==str[j]){
                cot++;
                }
            }
            Console.WriteLine(cot);
            str = str.Replace(str[0].ToString(),string.Empty);

        }
    }
}