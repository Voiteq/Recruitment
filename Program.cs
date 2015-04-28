using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiteqTestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            //acronyms
            string word1 = args[0];

            string word2 = args[1];

            char[] aToZ = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            //length check
            string nospace1 = "";
            string nospace2 = "";

            for (int i = 0; i < word1.Length; i++)
            {
                if (word1[i] != ' ')
                    nospace1 += word1[i].ToString().ToLower();
            }

            for (int i = 0; i < word2.Length; i++)
            {
                if (word2[i] != ' ')
                    nospace2 += word2[i].ToString().ToLower();
            }

            for (int i = 0; i < aToZ.Length; i++)
            {
                letterCount.Add(aToZ[i], 0);
            }


            for (int i = 0; i < nospace1.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < nospace2.Length; j++)
                {
                    if (nospace1[i] == nospace2[j])
                    {
                        letterCount[nospace1[i]] = letterCount[nospace1[i]] + 1;
                        found = true;
                    }
                }
                if (found != true)
                {
                    Console.WriteLine(args[0] + " and " + args[1] + " are not anagrams");
                    return;
                }
                found = false;

            }

            Console.WriteLine(args[0] + " and " + args[1] + " are anagrams");

            
        }
    }


    public class Tests
    {
        [Test]
        public void Fails_When_Strings_Are_Unequal_Length()
        {
            Assert.Fail();
        }

        [Test]
        public void Supports_Duplicated_Letters()
        {
            Assert.Fail();
        }

        [Test]
        public void Validates_User_Input()
        {
            Assert.Fail();
        }

    }
}
