
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

        public virtual void PushUndoAdd(SchoolMemberType type, SchoolMember name)
        {
            Undo.Push(
            description: $"Undo: add {type} '{newStudent.Name}'",
            undo: () => Students.Remove(newStudent)
            );
        }

        public virtual void PushUndoDisplay()
        {}

        public virtual void PushUndoPayment()
        {
            Undo.Push(
            description: $"Undo: add student '{newStudent.Name}'",
            undo: () => Students.Remove(newStudent)
            );
        }

    }
 }
