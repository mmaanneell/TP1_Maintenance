using Members;
using Managers;

public class ActionAdd : IActions
{
    public void MakeChoice()
    {
        int memberType = MenuHelper.AcceptMemberType();
        string oldName;
        string oldAddress; 
        int oldPhoneNumber;

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

                oldName = Principal.principal.Name;
                oldAddress = Principal.principal.Address;
                oldPhoneNumber = Principal.principal.PhoneNumber;
                

                Principal.principal = Principal.PrincipalAttributes();


                UndoManager.UndoHistory.Push(
                    description: $"Undo: Revert principal '{Principal.principal.Name}' to previous '{oldName}'",
                    undo: () =>
                    {
                        Principal.principal = new Principal(
                            name: oldName,
                            address: oldAddress,
                            phoneNumber: oldPhoneNumber
                        );
                    }
                );
                
                break;

            case SchoolMemberType.Receptionist:

                oldName = Receptionist.receptionist.Name;
                oldAddress = Receptionist.receptionist.Address;
                oldPhoneNumber = Receptionist.receptionist.PhoneNumber;


                Receptionist.receptionist = Receptionist.ReceptionistAttributes();

                UndoManager.UndoHistory.Push(
                    description: $"Undo: Revert receptionist '{Receptionist.receptionist.Name}' to  '{oldName}'",
                    undo: () =>
                    {
                        Receptionist.receptionist = new Receptionist(
                            name: oldName,
                            address: oldAddress,
                            phoneNumber: oldPhoneNumber
                        );
                    }
                );




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
