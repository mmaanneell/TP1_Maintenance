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

        public static void AddStudent(List<Student> students, string name, string address, int phoneNumber)
        {
            SchoolMember member = AcceptAttributes(name, address, phoneNumber);
            Student newStudent = new Student(member.Name, member.Address, member.PhoneNumber);
            newStudent.Grade = ConsoleHelper.AskNumberInput("Enter grade: ");

            students.Add(newStudent);
        }

        public static void AddTeacher(List<Teacher> teachers, string name, string address, int phoneNumber)
        {
            SchoolMember member = AcceptAttributes(name, address, phoneNumber);
            Teacher newTeacher = new Teacher(member.Name, member.Address, member.PhoneNumber);
            newTeacher.Subject = ConsoleHelper.AskInfoInput("Enter subject: ");

            teachers.Add(newTeacher);
        }

        public static void Add(List<Student> students, List<Teacher> teachers, string name, string address, int phoneNumber, Func<int> acceptMemberTypeFunc)
        {
            Console.WriteLine("\nPlease note that the Principal/Receptionist details cannot be added or modified now.");
            int memberType = acceptMemberTypeFunc();

            switch ((SchoolMemberType)memberType)
            {
                case SchoolMemberType.Teacher:
                    AddTeacher(teachers, name, address, phoneNumber);
                    break;
                case SchoolMemberType.Student:
                    AddStudent(students, name, address, phoneNumber);
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

        public static void PayMembers()
        {
            Console.WriteLine("\nPlease note that the students cannot be paid.");
            int memberType = Program.AcceptMemberType();

            Console.WriteLine("\nPayments in progress...");

            switch ((SchoolMemberType)memberType)
            {
                case SchoolMemberType.Principal:
                    Program.Principal.Pay();
                    break;
                case SchoolMemberType.Teacher:          
                    List<Task> payments = new List<Task>();

                    foreach (Teacher teacher in Teacher.Teachers)
                    {
                        Task payment = new Task(teacher.Pay);
                        payments.Add(payment);
                        payment.Start();
                    }

                    Task.WaitAll(payments.ToArray());
                    break;
                case SchoolMemberType.Receptionist:
                    Program.Receptionist.Pay();
                    break;
                default:
                    Console.WriteLine("Invalid input. Terminating operation.");
                    break;
            }

            Console.WriteLine("Payments completed.\n");
        }



    }
}