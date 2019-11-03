using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1_Revison_Q2
{
    class Member: IComparable
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string MemberID { get; set; }
        public string MembershipStatus { get; set; }
        public decimal Price { get; } //Can only set within the constructor

        public static int  MemberCount { get; set; }

        //Constructors
        public Member(string firstName, string lastName, int age, string memberId)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            MemberID = memberId;

            MembershipStatus = "Expired";

            if (age < 18)
            {
                Price = 50;
            }
            else
            {
                Price = 150;
            }

            MemberCount++;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("Fist Name:{0} Last Name:{1} Age:{2} ID:{3} Status:{4} Price:{5}", FirstName, LastName, Age, MemberID, MembershipStatus,Price);
        }
        //Changed the status of memebrship status of a object when called
        public void ChangeStatus()
        {
           
            if (MembershipStatus == "Expired")
            {
                MembershipStatus = "Current";
            }
            else
            {
                MembershipStatus = "Expired";
            }
        }

        //Compare Member objects based on last name
        public int CompareTo(object obj)
        {
            Member that = (Member)obj;

            return this.LastName.CompareTo(that.LastName);

            /* Use this if comparing numbers
             * if(this.Age > that.Age)
             * return 1:
             * else if(this.Age < that.Age)
             * return -1;
             * else
             * return 0;*/
        }
    }
}
