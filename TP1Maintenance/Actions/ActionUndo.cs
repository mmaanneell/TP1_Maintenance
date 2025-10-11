using Managers;     
public class ActionUndo : IActions
{
    public void MakeChoice()
    {
        Console.WriteLine(UndoManager.UndoHistory.Undo());
    }

}