using Managers;
public class ActionUndo : IActions
{
    public void Choice()
    {
        UndoManager.UndoLast();

    }

}