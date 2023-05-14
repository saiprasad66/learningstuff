using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class Class1
    {
        public bool valid(string str)
        {
            string pattern = @"^\w{3}$";
            if(Regex.IsMatch(str, pattern))
                { return true; }
             
            
            return false;
        }

    }
}