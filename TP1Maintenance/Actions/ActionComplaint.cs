using Members;

public class ActionComplaint : IActions
{
    public void MakeChoice()
    {
        if (Receptionist.receptionist is not null)
        {
            Receptionist.receptionist.HandleComplaint();
        }
        else
        {
            Console.WriteLine("Receptionist is not initialized.");
        }
    }

}
