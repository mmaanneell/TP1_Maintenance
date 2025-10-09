
namespace Managers
{
    public class UndoEntry
    {
        public Action Undo { get; }
        public string Description { get; }

        public UndoEntry(string description, Action undo)
        {
            Description = description ?? "Undo last action";
            Undo = undo;
        }



    }
 }
