using System;
using static System.String;
using System.Collections;
using System.Linq;

namespace std
{
    public class A
    {
        public static void Main(String[] args)
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();

            char[] aArr = A.ToArray();
            char[] bArr = B.ToArray();
            int length = aArr.Length;

            if (bArr.Length == length)
            {

                char[] result = new char[length];

                // "plagiarism" check
                for (int i = 0; i < length; i++)
                {
                    if (bArr[i] == aArr[i])
                    {
                        result[i] = 'P';
                        aArr[i] = (char)((int)aArr[i] | 32);
                    }
                }

                // "innocent" check
                for (int i = 0; i < length; i++)
                {
                    if (result[i] != 'P')
                    {
                        for (int j = 0; j < aArr.Length; j++)
                        {
                            if (bArr[i] == aArr[j])
                            {
                                aArr[j] = (char)((int)aArr[j] | 32);
                                result[i] = 'S';
                                break;
                            }
                        }
                    }
                }

                // "suspicious" check
                for (int i = 0; i < length; i++)
                {
                    if (result[i] == '\0')
                    {
                        result[i] = 'I';
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}