public class ActionPerformances : IActions
{
    public void Choice()
    {
         double average = await Task.Run(() => Student.CalculateAverageGrade(Students));
        Console.WriteLine($"The student average performance is: {average}");
    }
    
}
