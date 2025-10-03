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

        public static void Add(string name, string address, int phoneNumber, Func<int> acceptMemberTypeFunc)
        {
            Console.WriteLine("\nPlease note that the Principal/Receptionist details cannot be added or modified now.");
            int memberType = acceptMemberTypeFunc();

            switch ((SchoolMemberType)memberType)
            {
                case SchoolMemberType.Teacher:
                    AddTeacher(name, address, phoneNumber);
                    break;
                case SchoolMemberType.Student:
                    AddStudent(name, address, phoneNumber);
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