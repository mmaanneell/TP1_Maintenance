using Members;

public class ActionComplaint : IActions
{
    public void Choice()
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
