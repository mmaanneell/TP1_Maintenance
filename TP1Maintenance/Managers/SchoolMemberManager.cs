using System;
using System.Collections.Generic;
using Members;

namespace Managers
{
    public static class SchoolMemberManager
    {
        public static void AddMember()
        {
            int memberType = MenuHelper.AcceptMemberType();

            switch ((SchoolMemberType)memberType)
            {
                case SchoolMemberType.Student:

                    SchoolMember newStudent = Student.StudentAttributes();

                    Program.Undo.Push(
                        description: $"Undo: add student '{newStudent.Name}'",
                        undo: () => Student.Students.Remove(newStudent as Student)
                    );

                    break;

                case SchoolMemberType.Teacher:
                    SchoolMember newTeacher = Teacher.TeacherAttributes();

                    Program.Undo.Push(
                        description: $"Undo: add teacher '{newTeacher.Name}'",
                        undo: () => Teacher.Teachers.Remove(newTeacher as Teacher)
                    );

                    break;

                case SchoolMemberType.Principal:
                    Program.Undo.Push(
                        description: $"Undo: modify principal to '{Program.Principal.Name}'",
                        undo: () =>
                        {
                            Program.Principal = new Principal(
                                name: Program.Principal.Name,
                                address: Program.Principal.Address,
                                phoneNumber: Program.Principal.PhoneNumber
                            );
                        }
                    );

                    SchoolMember newPrincipal = Principal.PrincipalAttributes();
                    break;

                case SchoolMemberType.Receptionist:
                    Program.Undo.Push(
                        description: $"Undo: modify receptionist to '{Program.Receptionist.Name}'",
                        undo: () =>
                        {
                            Program.Receptionist = new Receptionist(
                                name: Program.Receptionist.Name,
                                address: Program.Receptionist.Address,
                                phoneNumber: Program.Receptionist.PhoneNumber
                            );
                        }
                    );

                    SchoolMember newReceptionist = Receptionist.ReceptionistAttributes();
                    break;

                default:
                    Console.WriteLine("Invalid type selected.");
                    return;
            }
        }

        public static SchoolMember BaseMemberAttributes()
        {
            string name = MenuHelper.AskInfoInput("Enter name: ");
            string address = MenuHelper.AskInfoInput("Enter address: ");
            int phoneNumber = MenuHelper.AskNumberInput("Enter phone number: ");

            return new SchoolMember(name, address, phoneNumber);
        }


    }
}