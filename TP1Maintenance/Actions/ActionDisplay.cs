using Helper;
using Members;

public class ActionDisplay : IActions
{
    public void MakeChoice()
    {
            int memberType = MenuHelper.AcceptMemberType();

        switch (memberType)
        {
            case 0:
                Console.WriteLine("\nThe Principal's details are:");
                Principal.principal.Display();
                break;
            case 1:
                Console.WriteLine("\nThe teachers are:");
                foreach (Teacher teacher in Teacher.Teachers)
                    teacher.Display();
                break;
            case 2:
                Console.WriteLine("\nThe students are:");
                foreach (Student student in Student.Students)
                    student.Display();
                break;
            case 3:
                Console.WriteLine("\nThe Receptionist's details are:");
                Receptionist.receptionist.Display();
                break;
            default:
                Console.WriteLine("Invalid input. Terminating operation.");
                break;
        }
    }
    
}
