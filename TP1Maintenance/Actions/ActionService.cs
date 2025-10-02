public static class ActionService
{
    private static readonly Dictionary<TypeChoix, IAction> Strategies = new()
    {
        [TypeChoix.Add] = new ActionAdd(),
        [TypeChoix.Display] = new ActionDisplay(),
        [TypeChoix.Pay] = new ActionPay()
        [TypeChoix.RaiseComplaint] = new ActionComplaint(),
        [TypeChoix.ShowPerformances] = new ActionPerformances()
    };

    public static double SelectAction()
    {
        
        if (Strategies.TryGetValue(TypeChoix, out var strategie))
        {
            strategie.Choice();
        }
    }


   
}