using System;
using System.Threading.Tasks;

public class ResultExample
{
    public static async Task Main()
    {

        //var task = Task.Run(DayTimeCheck); //Aufruf einer normalen Methode

        Task<string> task = Task.Run( //Aufruf einer anonymen Methode
            (/*Parameterliste*/) =>
            {
                DateTime date = DateTime.Now;
                return date.Hour > 17
                   ? "evening"
                   : date.Hour > 12
                       ? "afternoon"
                       : "morning";
            });

        await task.ContinueWith(
            antecedent =>
            {
                Console.WriteLine($"Good {antecedent.Result}!");
                Console.WriteLine($"And how are you this fine {antecedent.Result}?");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);



        Console.ReadKey();
    }


    public static string DayTimeCheck()
    {
        DateTime date = DateTime.Now;
        return date.Hour > 17
           ? "evening"
           : date.Hour > 12
               ? "afternoon"
               : "morning";
    }
}
// The example displays the similar output:
//       Good afternoon!
//       And how are you this fine afternoon?