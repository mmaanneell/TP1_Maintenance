public class ActionPay : IActions
{
    public void Choice()
    {
        Console.WriteLine("\nPlease note that the students cannot be paid.");
        int memberType = Program.AcceptMemberType();

        Console.WriteLine("\nPayments in progress...");

        switch (memberType)
        {
            case 1:
                Principal.Pay();
                break;
            case 2:
                List<Task> payments = new List<Task>();

                foreach (Teacher teacher in Program.Teachers)
                {
                    Task payment = new Task(teacher.Pay);
                    payments.Add(payment);
                    payment.Start();
                }

                Task.WaitAll(payments.ToArray());

                break;
            case 4:
                Receptionist.Pay();
                break;
            default:
                Console.WriteLine("Invalid input. Terminating operation.");
                break;
        }

        Console.WriteLine("Payments completed.\n");
    }


   
}
