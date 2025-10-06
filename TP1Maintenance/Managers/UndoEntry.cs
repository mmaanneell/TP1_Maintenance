public class UndoEntry
{
    public Action Undo { get; }
    public string Description { get; }

    public UndoEntry(string description, Action undo)
    {
        Description = description ?? "Undo last action";
        Undo = undo;
    }

    public static void CallUndoAdd()
    {
        Undo.Push(
        description: $"Undo: add student '{newStudent.Name}'",
        undo: () => Students.Remove(newStudent)
        );
    }
    public static void CallUndoPayment(){
        Undo.Push(
        description: $"Undo: add student '{newStudent.Name}'",
        undo: () => Students.Remove(newStudent)
        );
    }

}
