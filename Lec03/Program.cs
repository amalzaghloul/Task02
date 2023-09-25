using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lec03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Counting Vowels

            //Console.WriteLine("please enter a word or phrase");
            //string vowels = "AOEIU";

            //string phrase = Console.ReadLine().ToLower;


            //Console.WriteLine("-------------------------------------------------");
            #endregion

            #region String Splitter 
            Console.WriteLine("please enter a comma-separated list of names ");
            string fullName  = "Amal,Zaghloul,Mahmoud ";
            string[]text =fullName.Split(',');
            foreach (string s in text)
            {
                Console.WriteLine(s);
                Thread.Sleep(1000);

            }



            Console.WriteLine("-------------------------------------------------"); 
            #endregion


            Console.ReadLine();
        }
    }
}
