public class ActionPay : IActions
{
    public void Choice()
    {
         Console.WriteLine("\nPlease note that the students cannot be paid.");
            int memberType = Helper.MenuHelper.AcceptMemberType();
            Console.WriteLine("\nPayments in progress...");

            switch ((SchoolMemberType)memberType)
            {
                case SchoolMemberType.Principal:
                    Principal?.Pay();
                    break;
                case SchoolMemberType.Teacher:
                    Teacher.PayAll();
                    break;
                case SchoolMemberType.Receptionist:
                    Receptionist?.Pay();
                    break;
                default:
                    Console.WriteLine("Invalid input. Terminating operation.");
                    break;
            }

            Console.WriteLine("Payments completed.\n");
    }


   
}
