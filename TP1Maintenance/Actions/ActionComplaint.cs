using Members;

public class ActionComplaint : IAction
{
    public void Choice()
    {
        Receptionist.HandleComplaint();
    }

}
