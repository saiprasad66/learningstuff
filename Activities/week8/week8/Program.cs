using System;

namespace ContiguousSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 8;
            string S = "abfeuczi";
            Console.WriteLine(ContiguousSequence(N, S));
        }

        static int ContiguousSequence(int N, string S)
        {
            int result = 0;

            int a = 0, e = 0, i = 0, o = 0, u = 0;
            int left = 0;
            int count = 0;

            for (int right = 0; right < N; right++)
            {
                switch (S[right])
                {
                    case 'a':
                        a++;
                        break;
                    case 'e':
                        e++;
                        break;
                    case 'i':
                        i++;
                        break;
                    case 'o':
                        o++;
                        break;
                    case 'u':
                        u++;
                        break;
                }

                count = Math.Max(a, Math.Max(e, Math.Max(i, Math.Max(o, u))));

                while (count > 1)
                {
                    switch (S[left])
                    {
                        case 'a':
                            a--;
                            break;
                        case 'e':
                            e--;
                            break;
                        case 'i':
                            i--;
                            break;
                        case 'o':
                            o--;
                            break;
                        case 'u':
                            u--;
                            break;
                    }

                    count = Math.Max(a, Math.Max(e, Math.Max(i, Math.Max(o, u))));
                    left++;
                }

                if (right - left + 1 >= 5)
                {
                    result = Math.Min(result, right - left + 1 - 5);
                }
            }

          

            return result;
        }
    }
}
