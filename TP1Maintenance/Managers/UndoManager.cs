namespace Managers
{
    public class UndoManager
    {
        private readonly Stack<UndoEntry> _history = new();

        public void Push(string description, Action undo)
        {
            _history.Push(new UndoEntry(description, undo));
        }

        public string Undo()
        {
            if (_history.Count == 0)
            {
                throw new InvalidOperationException("No undo available");
            }
            else
            {
                UndoEntry entry = _history.Pop();
                entry.Undo();
                return entry.Description;
            }
        }
        

        public static void UndoLast()
        {
            Console.WriteLine(Program.Undo.Undo());
        }

    }
}

