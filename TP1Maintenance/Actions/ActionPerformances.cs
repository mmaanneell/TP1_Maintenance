public class ActionPerformances : IAction
{
    Choice()
    {
         double average = await Task.Run(() => Student.CalculateAverageGrade(Students));
        Console.WriteLine($"The student average performance is: {average}");
    }
    
}
