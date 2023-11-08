using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_p_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TryParse
            /* string inputString = "42"; // Replace "42" with your input string

             if (int.TryParse(inputString, out int number))
             {
                 // Conversion successful, multiply by 5 and print the result
                 int result = number * 5;
                 Console.WriteLine("Result:" +result);
             }
             else
             {
                 // Conversion failed, display an error message
                 Console.WriteLine("error occured.");
             }
                 Console.ReadKey();
            */

            //Convert method

            /*string dateString = "2023-11-08"; // Replace with your input date string

            try
            {
                DateTime inputDate = Convert.ToDateTime(dateString);

                // Subtract 1 month from the obtained DateTime
                DateTime resultDate = inputDate.AddMonths(-1);

                Console.WriteLine($"Input Date: {inputDate:yyyy-MM-dd}");
                Console.WriteLine($"Result Date (1 month ago): {resultDate:yyyy-MM-dd}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date format. Please enter a valid date string.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.ReadKey();
            */

            //Parse method

            string timeString = "02:30:00"; // Replace with your input time string

            try
            {
                TimeSpan inputTime = TimeSpan.Parse(timeString);

                // Add 2 hours to the obtained TimeSpan
                TimeSpan resultTime = inputTime.Add(TimeSpan.FromHours(2));

                Console.WriteLine("Input Time:" + inputTime);
                Console.WriteLine("Result Time (+2 hours):" + resultTime);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid time format. Please enter a valid time string.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The provided time value is too large or too small.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred:  {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
