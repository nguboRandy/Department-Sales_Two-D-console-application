using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunDepartment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Department department = new Department();
            department.PopulateArray();

            double[] avgSalesPerMonth = department.CalculateAvgSalesPerMonth();
            double[] avgSalesPerDepart = department.CalculateAvgSalesPerDepart();

            Console.WriteLine("\nSales Figures per Department per Month:");
            Console.WriteLine("                                                                 ");
            Console.WriteLine("| Department    |    Month 1    |    Month 2    |    Month 3    |");
            Console.WriteLine("|---------------|---------------|---------------|---------------|");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"| {i + 1}          | {department.sales[i][0],-8} | {department.sales[i][1],-8} | {department.sales[i][2],-8} |");
            }



            Console.WriteLine("\nAverage Sales per Department:");
            for (int i = 0; i < avgSalesPerDepart.Length; i++)
            {
                Console.WriteLine($"Department {i + 1}: {avgSalesPerDepart[i]}");
            }



            Console.WriteLine("\nAverage Sales per Month:");
            for (int i = 0; i < avgSalesPerMonth.Length; i++)
            {
                Console.WriteLine($"Month {i + 1}: {avgSalesPerMonth[i]}");
            }

            

            Console.WriteLine("\nMonth with the Highest Sales per Department:");
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Department {i}: Month {department.DetermineHighestDepartSales(i)}");
            }

            Console.WriteLine("\nDepartment with the Highest Sales per Month:");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Month {i}: Department {department.DetermineHighestMonthlySales(i)}");
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

    }

}

