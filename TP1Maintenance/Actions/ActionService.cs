public static class ActionService
{
    private static readonly Dictionary<TypeChoice, IActions> Strategies = new()
    {
        [TypeChoice.Add] = new ActionAdd(),
        [TypeChoice.Display] = new ActionDisplay(),
        [TypeChoice.Pay] = new ActionPay(),
        [TypeChoice.RaiseComplaint] = new ActionComplaint(),
        [TypeChoice.ShowPerformances] = new ActionPerformances(),
        [TypeChoice.UndoLastAction] = new ActionUndo()
    };

    public static void SelectAction(TypeChoice selection)
    { 
        if (Strategies.TryGetValue(selection, out var strategie))
        {
            strategie.MakeChoice();
        }
    }


   
}