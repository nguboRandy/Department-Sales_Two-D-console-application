using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunDepartment
{
    internal class Department
    {

        public double[][] sales;

        public Department()
        {
            sales = new double[4][];
            for (int i = 0; i < 4; i++)
            {
                sales[i] = new double[3];
            }
        }

        public void PopulateArray()
        {
            Console.WriteLine("Enter sales figures for each department and month:");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Department {i + 1}:");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Month {j + 1}: ");
                    sales[i][j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        public double[] CalculateAvgSalesPerMonth()
        {
            double[] avgSales = new double[3];

            for (int j = 0; j < 3; j++)
            {
                double total = 0;
                int count = 0;
                for (int i = 0; i < 4; i++)
                {
                    total += sales[i][j];
                    if (sales[i][j] > 0)
                        count++;
                }
                avgSales[j] = total / count;
            }

            return avgSales;
        }

        public double[] CalculateAvgSalesPerDepart()
        {
            double[] avgSales = new double[4];

            for (int i = 0; i < 4; i++)
            {
                double total = 0;
                int count = 0;
                for (int j = 0; j < 3; j++)
                {
                    total += sales[i][j];
                    if (sales[i][j] > 0)
                        count++;
                }
                avgSales[i] = total / count;
            }

            return avgSales;
        }

        public int DetermineHighestMonthlySales(int month)
        {
            int highestDepartment = -1;
            double highestSales = -1;

            for (int i = 0; i < 4; i++)
            {
                if (sales[i][month - 1] > highestSales)
                {
                    highestSales = sales[i][month - 1];
                    highestDepartment = i + 1;
                }
            }

            return highestDepartment;
        }

        public int DetermineHighestDepartSales(int department)
        {
            int highestMonth = -1;
            double highestSales = -1;

            for (int j = 0; j < 3; j++)
            {
                if (sales[department - 1][j] > highestSales)
                {
                    highestSales = sales[department - 1][j];
                    highestMonth = j + 1;
                }
            }

            return highestMonth;
        }
    }
}
