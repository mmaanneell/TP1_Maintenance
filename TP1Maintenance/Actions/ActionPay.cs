using Members;

public class ActionPay : IActions
{
    public void MakeChoice()
    {
        Console.WriteLine("\nPlease note that the students cannot be paid.");
        int memberType = Helper.MenuHelper.AcceptMemberType();
        Console.WriteLine("\nPayments in progress...");

        switch ((SchoolMemberType)memberType)
        {
            case SchoolMemberType.Principal:
                if (Principal.principal is not null) Principal.principal.Pay();
                else Console.WriteLine("Principal is not initialized.");
                break;
            case SchoolMemberType.Teacher:
                Teacher.PayAll();
                break;
            case SchoolMemberType.Receptionist:
                if (Receptionist.receptionist is not null) Receptionist.receptionist.Pay();
                else Console.WriteLine("Receptionist is not initialized.");
                break;
            default:
                Console.WriteLine("Invalid input. Terminating operation.");
                break;
        }

        Console.WriteLine("Payments completed.\n");
    }



}
