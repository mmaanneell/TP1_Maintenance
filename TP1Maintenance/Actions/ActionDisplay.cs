public class ActionDisplay : IActions
{
    public void Choice()
    {
            int memberType = Program.AcceptMemberType();

        switch (memberType)
        {
            case 1:
                Console.WriteLine("\nThe Principal's details are:");
                Principal.Display();
                break;
            case 2:
                Console.WriteLine("\nThe teachers are:");
                foreach (Teacher teacher in Teachers)
                    teacher.Display();
                break;
            case 3:
                Console.WriteLine("\nThe students are:");
                foreach (Student student in Students)
                    student.Display();
                break;
            case 4:
                Console.WriteLine("\nThe Receptionist's details are:");
                Receptionist.Display();
                break;
            default:
                Console.WriteLine("Invalid input. Terminating operation.");
                break;
        }
    }
    
}
