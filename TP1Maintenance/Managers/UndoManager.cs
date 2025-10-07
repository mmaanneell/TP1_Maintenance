namespace Managers
{

    public class UndoManager
    {
        private readonly Stack<UndoEntry> _history = new();

        public void Push(string description, Action undo)
        {
            _history.Push(new UndoEntry(description, undo));
        }

        public string UndoLast()
        {
            UndoEntry entry = _history.Pop();
            entry.Undo();
            return entry.Description;
        }

        

    }
}