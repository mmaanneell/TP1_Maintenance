using Members;
using System;

namespace Managers
{
    public static class SchoolMemberManager
    {
        public static List<SchoolMember> GetListOfMembersByType(SchoolMemberType memberType)
        {
            return memberType switch
            {
                SchoolMemberType.Principal => new List<SchoolMember> { Principal.principal },
                SchoolMemberType.Teacher => Teacher.Teachers.Cast<SchoolMember>().ToList(),
                SchoolMemberType.Student => Student.Students.Cast<SchoolMember>().ToList(),
                SchoolMemberType.Receptionist => new List<SchoolMember> { Receptionist.receptionist },
                _ => new List<SchoolMember>()
            };
        }

        public static void DisplayAll(SchoolMemberType memberType)
        {
            List<SchoolMember> members = GetListOfMembersByType(memberType);

            if (members.Count == 0)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Console.WriteLine($"\nThe {memberType}s are:");
            foreach (SchoolMember member in members)
            {
                member.Display();
            }
        }

        public static void PayAll(SchoolMemberType memberType)
        {
            List<Employee> employees = GetListOfMembersByType(memberType).OfType<Employee>().ToList();

            if (employees.Count == 0)
            {
                Console.WriteLine("This type of member cannot be paid.");
                return;
            }

            Console.WriteLine($"\nPayments in progress for {memberType}s...");

            foreach (Employee employe in employees)
            {
                employe.Pay();
            }

            Console.WriteLine("Payments completed.");
        }
    }
}