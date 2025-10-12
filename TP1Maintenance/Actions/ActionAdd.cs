using Members;
using Managers;

public class ActionAdd : IActions
{
    public void MakeChoice()
    {
        int memberType = MenuHelper.AcceptMemberType();

        switch ((SchoolMemberType)memberType)
        {
            case SchoolMemberType.Student:

                Student newStudent = Student.StudentAttributes();

                UndoManager.UndoHistory.Push(
                    description: $"Undo: add student '{newStudent.Name}'",
                    undo: () => Student.Students.Remove(newStudent)
                );

                break;

            case SchoolMemberType.Teacher:
                Teacher newTeacher = Teacher.TeacherAttributes();

                UndoManager.UndoHistory.Push(
                    description: $"Undo: add teacher '{newTeacher.Name}'",
                    undo: () => Teacher.Teachers.Remove(newTeacher)
                );

                break;

            case SchoolMemberType.Principal:

                Principal.principal = Principal.PrincipalAttributes();


                UndoManager.UndoHistory.Push(
                    description: $"Undo: remove principal '{Principal.principal.Name}' to previous principal",
                    undo: () =>
                    {
                        Principal.principal = new Principal(
                            name: Principal.principal.Name,
                            address: Principal.principal.Address,
                            phoneNumber: Principal.principal.PhoneNumber
                        );
                    }
                );
                
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
        string name = MenuHelper.AskInfoInput("Enter name: ");
        string address = MenuHelper.AskInfoInput("Enter address: ");
        int phoneNumber = MenuHelper.AskNumberInput("Enter phone number: ");

        return new SchoolMember(name, address, phoneNumber);
    }


}
