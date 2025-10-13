using Members;
using Managers;

public class ActionPay : IActions
{
    public void MakeChoice()
    {
        Console.WriteLine("\n ----- Please note that students cannot be paid.");
        int memberTypeInput = MenuHelper.AcceptMemberType();

        SchoolMemberManager.PayAll((SchoolMemberType)memberTypeInput);
    }

}
