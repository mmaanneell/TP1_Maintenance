using Managers;     
public class ActionUndo : IActions
{
    public void Choice()
    {
        Console.WriteLine(UndoManager.UndoHistory.Undo());
    }

}