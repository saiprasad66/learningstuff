//using System;
//using System.Net.Http;
//using System.Text.Json;
//using System.Threading.Tasks;

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        //using(var clent=new HttpClient())
//        //{
//        //    var response = await clent.GetAsync("https://localhost:7108/api/Trainer/All");
//        //    var received= await response.Content.ReadAsStringAsync();

//        //    Console.WriteLine(received);
//        //}

//        string str = "abbbaacccaddeffg";



//        Dictionary<char, int> dic = new Dictionary<char, int>();

//        foreach(char c in str)
//        {
//            if (dic.ContainsKey(c))
//            {
//                dic[c]++;
//            }
//            else
//            {
//                dic.Add(c, 1);
//            }
//        }
//        foreach(KeyValuePair<char,int> ch in dic)
//        {
//            Console.WriteLine("{0},{1}", ch.Key, ch.Value);

//        }






//    }
//}

//using System;
//using System.Security.Cryptography.X509Certificates;

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        int start = int.Parse(Console.ReadLine());
//        int end = int.Parse(Console.ReadLine());
//        for(int i = start; i <= end; i++)
//        {
//            if (Armstrong(i))
//            {
//                Console.WriteLine(i);
//            }
//        }
//         static bool Armstrong(int number)
//        {
//            int on = number;
//            int result = 0;
//            int rem = 0;
//            while (number > 0)
//            {
//                rem = number % 10;
//                result += rem * rem * rem;
//                number = number / 10;


//            }
//            return on == result;

//        }
//    }
//}
//----------sum of longest postive sequence number in an array---------------------------------
//using System;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;

//public class program
//{
//    public static void Main(string[] args)
//    {

//        int[] arr = new int[] { 1, 2, 3, 5,6,7 ,-4, 6, 7, 8, 9,-2, 10, -12 };
//        int n = arr.Length;
//        int sum = 0;
//        List<int> maxsequence = new List<int>();
//        List<int> currentsequence = new List<int>();
//        for(int i = 0; i < n; i++)
//        {
//            if (arr[i] >= 0)
//            {
//                currentsequence.Add(arr[i]);
//            }
//            else
//            {
//                if (currentsequence.Count > maxsequence.Count)
//                {
//                    maxsequence = new List<int>(currentsequence);
//                }
//                currentsequence.Clear();
//            }
//        }
//        if (currentsequence.Count > maxsequence.Count)
//        {
//            maxsequence = new List<int>(currentsequence);
//        }
//       foreach(int v in maxsequence)
//        {
//            sum += v;

//        }
//        Console.WriteLine(sum);

//    }
//}

//using System;
//using System.Collections;




//public class Program
//{


//    public int findPassword(int input1,int input2,int input3,int input4,int input5)
//    {
//        String s1= input1.ToString();
//        String s2 = input2.ToString();
//        String s3 = input3.ToString();
//        String s4 = input4.ToString();
//        String s5 = input5.ToString();
//        Dictionary<char,int> dic = new Dictionary<char,int>();

//        string[] arr = {s1,s2,s3,s4,s5};
//        foreach(var i in arr)
//        {
//            char[] ch=i.ToCharArray();
//            foreach(char c in ch)
//            if (dic.ContainsKey(c))
//            {
//                dic[c]++;
//            }
//                else
//                {
//                    dic.Add(c, 1);
//                }

//        }

//    }
//    public static void Main(string[] args)
//    {
//        int input1 = 12;
//        int input2 = 2233;
//        int input3 = 2345;
//        int input4 = 2225;
//        int input5 = 112;
//        Program p=new Program();

//        int result=p.findPassword(input1,input2, input3, input4,input5);
//        Console.WriteLine(result);

//    }
//}

////Nth prime number    && given range===============================
using System;
//public class program
//{
// public int getnthprime(int Start,int end)
//{
//    int count = 0;
//    int start = 2;
//    while (count < n)
//    {
//        if (isprime(start))
//        {
//            count++;
//        }

//            start++;

//    }
//    return start-1;



//}




//    public static bool isprime(int n)
//    {
//        if (n < 2)
//        {
//            return false;
//        }

//            for(int i = 2; i <= Math.Sqrt(n); i++)
//            {
//                if (n % i == 0)
//                {
//                    return false;
//                }

//            }
//        return true;
//    }
//    public static void Main(string[] args)
//    {
//        program p = new program();

//        //int n = p.getnthprime(20,30);
//        int Start = 20;int end = 100;

//        for (int i = Start; i <= end; i++)
//        {
//            if (isprime(i))
//            {
//                Console.WriteLine( i);
//            }
//        }

//    }
//}

//get max digit in given number




//using System;
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        int number = 123456;
//        int max = 0;
//        foreach(char i in number.ToString())
//        {
//            if(char.IsDigit(i)&&char.GetNumericValue(i)>max)
//            {
//                max= (int)char.GetNumericValue(i);
//            }
//        }
//        Console.WriteLine(max);
//    }
//}
//sum of the digits in cyclic order================================================
//using System;
//public class program
//{
//    public static void Main(string[] args)
//    {
//        int n = 572;
//        int sum = 0;
//        string s = n.ToString();
//        string s2 = " ";
//        for(int i = s.Length - 1; i >= 0; i--)
//        {
//            s2 += s[i];
//        }
//        Console.WriteLine(s2);
//        int n1 = Int32.Parse(s2);
//        while (n1> 0)
//        {
//            foreach (char digit in n1.ToString())
//            {
//                if (char.IsDigit(digit))
//                {
//                    sum += (int)char.GetNumericValue(digit);


//                }


//            }
//            n1 = n1 / 10;



//        }
//        Console.WriteLine(sum);


//    }
//}


//return one  tens and hundread digit ==========
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        int n = 12345678;
//        int p = n % 10;
//        Console.WriteLine(p);
//        int q = (n / 10) % 10;
//        Console.WriteLine(q);
//        int r= (n / 100) % 10;
//        Console.WriteLine(r);
//        int s=(n / 1000) % 10;
//        Console.WriteLine(s);
//    }
//}
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        int n = 5;
//        int fact = 1;
//        for(int i=1; i<=n; i++)
//        {
//            fact= fact*i;

//        }
//        Console.WriteLine(fact);
//    }
//}
//getting unique elements in an number or string===============================
//using System.Linq;
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        int n = 121212;
//        string s=n.ToString();
//        string o =  new (s.Distinct().ToArray());
//        Console.WriteLine(o);
//        int p=Int32.Parse(o);
//        int sum = 0;
//       foreach(char f in p.ToString())
//        {
//            if(char.IsDigit(f))
//            {
//                sum += (int)char.GetNumericValue(f);

//            }
//        }
//       Console.WriteLine(sum);
//    }
//}
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        long n = 1234123212212;
//        string s=n.ToString();
//        HashSet<char> set = new HashSet<char>(s);
//        string s1=new string(set.ToArray());
//        Console.WriteLine(Int32.Parse(s1));
//    }
//}
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        int n = 234567;
//        int sum = 0;
//        foreach (char i in n.ToString())
//        {
//            if (char.IsDigit(i))
//            {
//                if (i % 2 == 0)
//                {
//                    sum += (int)char.GetNumericValue(i);

//                }
//            }
//        }
//        Console.WriteLine(sum);
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        string s1 = "MadAm";
//        string s2=s1.ToLower();
//        Console.WriteLine(s2);
//        string s3 = "";
//        for(int i=s2.Length-1; i>=0; i--)
//        {
//            s3 += s2[i];

//        }
//        Console.WriteLine(s3);
//        if(s3 == s2) {
//            Console.WriteLine("yes");

//        }
//        else
//        {
//            Console.WriteLine("no");
//        }
//    }
//}

//Maximum repeated digit among 3 numbers;
//using System.Linq;
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        int[] arr = { 123,223, 412, 498 };
//        Dictionary<int, int> map = new Dictionary<int, int>();
//        foreach (int i in arr)
//        {
//            foreach (char d in i.ToString())
//            {
//                if (char.IsDigit(d))
//                {
//                    if (map.ContainsKey((int)char.GetNumericValue(d)))
//                    {
//                        map[(int)char.GetNumericValue(d)]++;

//                    }
//                    else
//                    {
//                        map.Add((int)char.GetNumericValue(d), 1);
//                    }

//                }
//            }
//        }
//        int value=map.OrderByDescending(x=>x.Value).ThenByDescending(x=>x.Key).First().Key;
//        Console.WriteLine(value);
//    }
//    }

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        string s = "WORLD";
//        int n=s.Length;
//        int sum = 0;
//        for(int i=0;i<s.Length/2;i++)
//        {
//            sum += Math.Abs((int)s[i] - (int)s[s.Length - 1 - i]);

//        }
//        if(n%2!=0)
//        {
//            sum += (int)s[s.Length / 2]-'A' + 1;
//        }
//        Console.WriteLine(sum);
//    }
//}



////power of a digit sum=============================
//public class Proram
//{
//    public static void Main(string[] args)
//    {
//        int n = 582109;
//        string s=n.ToString();
//        char[] chars = s.ToCharArray();
//        long sum = 0;
//        for(int i=0;i<chars.Length-1;i++)
//        {

//                sum += (int)Math.Pow(char.GetNumericValue(chars[i]), char.GetNumericValue(chars[i+1]));

//        }
//        sum += (int)Math.Pow(char.GetNumericValue(chars[chars.Length - 1]), 0);
//        Console.WriteLine(sum);
//    }
//}


//public class Program
//{

//    public static bool isprime(int n)
//    {
//        if(n<2) return false;
//        else
//        {
//            for(int i=2;i<n; i++)
//            {
//                if(n%i==0) return false;

//            }
//        }
//        return true;
//    }
//    public static void Main(string[] args)
//    {
//        int n = 3;
//        int count = 0;
//        int start = 2;
//        while (count < n)
//        {
//            if (isprime(start))
//            {
//                count++;
//            }
//            start++;
//        }
//        int r = (start-1);
//       List<int> list = new List<int>();
//        while (r > 0)
//        {
//            int digit=r %10;
//            list.Add(digit);
//            r =r /10;
//        }


//        string result=string.Empty; 
//        Dictionary<int,string> dict = new Dictionary<int,string>();
//        dict.Add(0, "zero");
//        dict.Add(1, "one");
//        dict.Add(2, "two");
//        dict.Add(3, "three");
//        dict.Add(4, "four");
//        dict.Add(5, "five");
//        dict.Add(6, "six");
//        dict.Add(7, "seven");
//        dict.Add(8, "eight");
//        dict.Add(9, "nine");
//        int vowel = 0;
//        for (int i = 0; i < list.Count; i++) {
//            foreach (var v in dict)
//            {
//                if (v.Key == list[i])
//                {
//                    string s = v.Value;
//                    foreach(char c in s)
//                    {
//                        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
//                        {
//                            vowel++;
//                            result += c;

//                        }
//                    }
//                }
//             }
//        }
//        Console.WriteLine(result+vowel);

//    }
//}


/// <summary>
/// freqncy of digits in   a  number  is equal called stable or else unstable find the difference of stable and unstable
/// </summary>
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        int[] arr = { 455, 257, 3300, 110, 303 };
//        int s = 0;
//        int u=0;

//        foreach(int i in arr)
//        {
//            if (isstable(i))
//            {
//                s += i;

//            }
//            else
//            {
//                u += i;
//            }

//        }


//        int pass = s - u;
//        Console.WriteLine(pass);




//    }
//    public static bool isstable(int n)
//    {
//        int[] f=new int[10];

//        while(n> 0)
//        {
//            int d = n % 10;
//            f[d]++;
//            n /= 10;


//        }
//        int freq = 0;
//        for(int i = 0; i < 10; i++)
//        {
//            if (f[i] != 0)
//            {
//                if(freq==0)
//                {
//                    freq = f[i];
//                }
//                else if (freq != f[i])
//                {
//                    return false;
//                }

//            }

//        }
//        return true;



//}

//}


public class Program
{
    public static void Main(string[] args)
    {
        string s = "mynameisprabhas";
        string k = "prabs";
        string n= "";
        int index = s.IndexOf(k);
        if (index >= 0)
        {
             n = s.Substring(index, k.Length);
            Console.WriteLine(n);
        }
        else
        {
            Console.WriteLine("No String found!");
        }
    }
}