using Members;

public class ActionComplaint : IActions
{
    public void Choice()
    {
        Program.Receptionist.HandleComplaint();
    }

}
