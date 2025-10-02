public class ActionAdd : IAction
{
    Choice()
    {
        string name = "";
        string address = "";
        int phoneNumber = 1234;

        Console.WriteLine("\nPlease note that the Principal/Receptionist details cannot be added or modified now.");
        int memberType = Program.AcceptMemberType();

        switch (memberType)
        {
            case 2:
                AddTeacher(name, address, phoneNumber);
                break;
            case 3:
                AddStudent(name, address, phoneNumber);
                break;
            default:
                Console.WriteLine("Invalid input. Terminating operation.");
                break;
        }
    }

    private static void AddStudent(string name, string address, int phoneNumber)
    {
        SchoolMember member = AcceptAttributes(name, address, phoneNumber);
        Student newStudent = new Student(member.Name, member.Address, member.PhoneNumber);
        newStudent.Grade = ConsoleHelper.AskNumberInput("Enter grade: ");

        Students.Add(newStudent);
    }

    private static void AddTeacher(string name, string address, int phoneNumber)
    {
        SchoolMember member = AcceptAttributes(name, address, phoneNumber);
        Teacher newTeacher = new Teacher(member.Name, member.Address, member.PhoneNumber);
        newTeacher.Subject = ConsoleHelper.AskInfoInput("Enter subject: ");

        Teachers.Add(newTeacher);
    }
    

        public static SchoolMember AcceptAttributes(string name, string address, int phoneNumber)
    {
        SchoolMember member = new SchoolMember(name, address, phoneNumber);
        member.Name = ConsoleHelper.AskInfoInput("Enter name: ");
        member.Address = ConsoleHelper.AskInfoInput("Enter address: ");
        member.PhoneNumber = ConsoleHelper.AskNumberInput("Enter phone number: ");

        return member;
    }


    
}
