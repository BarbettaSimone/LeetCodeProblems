using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises
{
    internal class RequestManager
    {
        public void StartManager()
        {
            Console.WriteLine("Welcome to LeetCode exercises, select the number of the exercise that you want to resolve:");
            string? selection = Console.ReadLine();
            while (selection == null || selection!= "-1")
            {
                var assembly = Assembly.GetExecutingAssembly();
                var exercise = assembly.GetTypes().FirstOrDefault(x => x.Name == "LeetCodeExercise" + selection);
                if (exercise != null)
                {
                    Activator.CreateInstance(exercise);
                    Console.WriteLine("\nInsert another exercise number, or inser -1 to exit");
                }
                else
                {
                    Console.WriteLine("\nWrong selected number, please retry or inser -1 to exit");
                }
                selection = Console.ReadLine();
            }
        }
    }
}
