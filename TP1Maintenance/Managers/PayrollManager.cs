using System;
using System.Collections.Generic;
using Members;

namespace Managers
{
    public static class PayrollManager
    {

        public static void PayMembers(Principal principal, Receptionist receptionist)
        {
            Console.WriteLine("\nPlease note that the students cannot be paid.");
            int memberType = MenuHelper.AcceptMemberType();
            Console.WriteLine("\nPayments in progress...");

            switch ((SchoolMemberType)memberType)
            {
                case SchoolMemberType.Principal:
                    principal?.Pay();
                    break;
                case SchoolMemberType.Teacher:
                    Teacher.PayAll();
                    break;
                case SchoolMemberType.Receptionist:
                    receptionist?.Pay();
                    break;
                default:
                    Console.WriteLine("Invalid input. Terminating operation.");
                    break;
            }

            Console.WriteLine("Payments completed.\n");
        }


    }
}