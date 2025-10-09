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
            String outPutString = "";

            if (_history.Count == 0)
            {
                outPutString = "No undo available";
            }
            else 
            {
                UndoEntry entry = _history.Pop();
                entry.Undo();
                outPutString = entry.Description;
            }
            return outPutString;
        }
        

        public static void UndoLast()
        {
            Console.WriteLine(Program.Undo.Undo());
        }

    }
}

