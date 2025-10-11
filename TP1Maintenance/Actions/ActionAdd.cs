using Helper;
using Members;
using Managers;

public class ActionAdd : IActions
{
    public void Choice()
    {
        int memberType = MenuHelper.AcceptMemberType();

        switch ((SchoolMemberType)memberType)
        {
            case SchoolMemberType.Student:

                SchoolMember newStudent = Student.StudentAttributes();
                
                UndoManager.UndoHistory.Push(
                    description: $"Undo: add student '{newStudent.Name}'",
                    undo: () => Student.Students.Remove(newStudent as Student)
                );

                break;

            case SchoolMemberType.Teacher:
                SchoolMember newTeacher = Teacher.TeacherAttributes();

                UndoManager.UndoHistory.Push(
                    description: $"Undo: add teacher '{newTeacher.Name}'",
                    undo: () => Teacher.Teachers.Remove(newTeacher as Teacher)
                );

                break;

            case SchoolMemberType.Principal:
                UndoManager.UndoHistory.Push(
                    description: $"Undo: modify principal to '{Principal.principal.Name}'",
                    undo: () =>
                    {
                        Principal.principal = new Principal(
                            name: Principal.principal.Name,
                            address: Principal.principal.Address,
                            phoneNumber: Principal.principal.PhoneNumber
                        );
                    }
                );

                SchoolMember newPrincipal = Principal.PrincipalAttributes();
                break;

            case SchoolMemberType.Receptionist:
                UndoManager.UndoHistory.Push(
                    description: $"Undo: modify receptionist to '{Receptionist.receptionist.Name}'",
                    undo: () =>
                    {
                        Receptionist.receptionist = new Receptionist(
                            name: Receptionist.receptionist.Name,
                            address: Receptionist.receptionist.Address,
                            phoneNumber: Receptionist.receptionist.PhoneNumber
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
            string name = ConsoleHelper.AskInfoInput("Enter name: ");
            string address = ConsoleHelper.AskInfoInput("Enter address: ");
            int phoneNumber = ConsoleHelper.AskNumberInput("Enter phone number: ");

            return new SchoolMember(name, address, phoneNumber);
        }


}
