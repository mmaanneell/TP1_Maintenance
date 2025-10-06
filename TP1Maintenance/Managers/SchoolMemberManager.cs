using System;
using System.Collections.Generic;
using Members;
using Helper;

namespace Managers
{
    public static class SchoolMemberManager
    {
        public static void AddPrincipal(Principal principal, string name, string address, int phoneNumber)
        {
            SchoolMember member = AcceptAttributes(name, address, phoneNumber);
            principal.Name = member.Name;
            principal.Address = member.Address;
            principal.PhoneNumber = member.PhoneNumber;
            Console.WriteLine("New principal created successfully.");
        }

        public static void AddStudent(string name, string address, int phoneNumber)
        {
            SchoolMember member = AcceptAttributes(name, address, phoneNumber);
            Student newStudent = new Student(member.Name, member.Address, member.PhoneNumber);
            newStudent.Grade = ConsoleHelper.AskNumberInput("Enter grade: ");

            Student.Students.Add(newStudent);
        }

        public static void AddTeacher(string name, string address, int phoneNumber)
        {
            SchoolMember member = AcceptAttributes(name, address, phoneNumber);
            Teacher newTeacher = new Teacher(member.Name, member.Address, member.PhoneNumber);
            newTeacher.Subject = ConsoleHelper.AskInfoInput("Enter subject: ");

            Teacher.Teachers.Add(newTeacher);
        }
        private static void AddReceptionist(string name, string address, int phoneNumber)
        {
            SchoolMember member = AcceptAttributes(name, address, phoneNumber);
            Receptionist newReceptionist = new Receptionist(member.Name, member.Address, member.PhoneNumber);

            Console.WriteLine("New receptionist created successfully.");
        }

        public static void Add(Principal principal, string name, string address, int phoneNumber)
        {
            int memberType = MenuHelper.AcceptMemberType();

            switch ((SchoolMemberType)memberType)
            {
                case SchoolMemberType.Teacher:
                    AddTeacher(name, address, phoneNumber);
                    break;
                case SchoolMemberType.Student:
                    AddStudent(name, address, phoneNumber);
                    break;
                case SchoolMemberType.Receptionist:
                    AddReceptionist(name, address, phoneNumber);
                    break;
                case SchoolMemberType.Principal:
                    AddPrincipal(principal, name, address, phoneNumber);
                    break;
                default:
                    Console.WriteLine("Invalid input. Terminating operation.");
                    break;
            }
        }

        

        private static SchoolMember AcceptAttributes(string name, string address, int phoneNumber)
        {
            SchoolMember member = new SchoolMember(name, address, phoneNumber);
            member.Name = ConsoleHelper.AskInfoInput("Enter name: ");
            member.Address = ConsoleHelper.AskInfoInput("Enter address: ");
            member.PhoneNumber = ConsoleHelper.AskNumberInput("Enter phone number: ");

            return member;
        }



    }
}