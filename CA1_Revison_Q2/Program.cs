using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1_Revison_Q2
{
    class Program
    {
        static void Main(string[] args)
        {

            Member m1 = new Member("Pat", "Kelly", 23, "1022");
            Member m2 = new Member("Jim", "Jones", 17, "2167");
            Member m3 = new Member("Pa", "Keirnan", 33, "1234");
            Member m4 = new Member("Lucy", "Lipton", 44, "2032");
            Member m5 = new Member("Mary", "Jennedy", 13, "2022");

            Member[] allMemebrs = new Member[5];
            allMemebrs[0] = m1;
            allMemebrs[1] = m2;
            allMemebrs[2] = m3;
            allMemebrs[3] = m4;
            allMemebrs[4] = m5;



            DisplayMemebrs(allMemebrs);

            m1.ChangeStatus();
            m3.ChangeStatus();

            Console.WriteLine();
            DisplayMemebrs(allMemebrs);
            Console.WriteLine();

            Console.WriteLine("Total Memebers is: {0}", Member.MemberCount); //Displays all Members nmumber based on property
            Console.WriteLine();

            Array.Sort(allMemebrs);
            DisplayMemebrs(allMemebrs);
            Console.WriteLine();

            Array.Reverse(allMemebrs);
            DisplayMemebrs(allMemebrs);
            Console.WriteLine();

        }

        static void DisplayMemebrs(Member[] allMemebrs)
        {
            foreach (Member m in allMemebrs)
            {
                Console.WriteLine(m);
            }
        }
    }
}
