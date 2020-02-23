using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();
            //Test2();
            //Test3();
            Test4();
            //Test5();
            //Test6();

            Console.ReadLine();
        }

      
        private static void Test1()
        {
            /*1.В заданном натуральном числе поменять порядок цифр на обратный
            и сравнить полученное число с исходным*/

            int intNumber, reverseNumber=0, num, checkNumber =0;

            //uncomment "i" if you want to see Explanation block
            //int i = 0;

            Console.Write("Enter any Integer number: ");

            intNumber = int.Parse(Console.ReadLine());
            
            //Block for comparing Entered Number and Reverse one
            checkNumber = intNumber;

            while (intNumber != 0)  
            {
                num = intNumber % 10;
                reverseNumber = reverseNumber*10 + num;
                intNumber /= 10;


                //Explanation block of each Iteration
               /*                
                i++;
                Console.WriteLine("\n---ITERATION {0}---\nnum is {1}", i, num);
                Console.WriteLine("reverseNumber is {0}", reverseNumber);
                Console.WriteLine("intNumber is {0}\n", intNumber);
                */
            }


            string comparing = "";

            if (reverseNumber >= checkNumber)
            {
                if (reverseNumber > checkNumber)
                    comparing = "bigger";
                
                else
                    comparing = "equal";
            }

            else
            {
                comparing = "smaller";
            }
            Console.WriteLine("Reverse number is: {0}\nReverse number is {1} than/to entered number",reverseNumber,comparing);
            
        }

        private static void Test2()
        {
            /*14.Плотность воздуха убывает с высотой по закону p=p0*e^(-hz), где p — плотность на высоте h метров,  
            Напечатать таблицу зависимости плотности от высоты для значений от 0 до 1000 м через каждые 100 м.*/

            // Given Values: Density p0 and Z
            const double p0 = 1.29; //kg/m^3
            double z = 1.25 * Math.Pow(10,-4);

            //Density p, and height h
            Double p;
            int h = 0;

            for (; h <= 1000; h+=100)
            {
                p = p0 * Math.Pow(Math.E, -h * z);

                //for output clarity
                string pSimplified = string.Format("{0:0.00}", p);
                
                Console.WriteLine("Density on the height \t{0}m. \tis \t{1}kg/m3", h, pSimplified);
            }
            

        }

        private static void Test3()
        {
            /*69.Начав тренировки, лыжник в первый день пробежал 10 км.
            Каждый следующий день он увеличивал пробег на 10 % от пробега предыдущего дня.Определить:
            а) пробег лыжника за второй, третий, …, десятый день тренировок;
            б) суммарный путь лыжника за первые 7 дней тренировок;
            в) в какой день он пробежит больше 20 км;
            г) в какой день суммарный пробег за все дни превысит 100 км.*/

            Double distance = 10, sum = 0;
            int day = 1;

            for (; day <= 10; day++)
            {
                Console.WriteLine("Day {0}:\tDistance {1:N2} km", day, distance);

                //Summary distance in 7 days
                if (day <= 7)
                {
                    sum += distance;
                }
                distance += distance * 0.1;
            }

            Console.WriteLine("\nSummary distance in 7 days is {0:N2} km", sum);

            //Day when 20km done
            distance = 10;
            sum = 0;
            for (day = 1; day <= 10; day++)
            {
                if (sum < 20)
                {
                    sum += distance;                    
                }

                distance += distance * 0.1;

                if (sum >= 20)
                {
                    Console.WriteLine("\nDone more than 20km in {0} days", day);
                    break;
                }
            }

            //Day when 100km done
            distance = 10;
            sum = 0;
            for (day = 1; day <= 10; day++)
            {
                if (sum < 100)
                {
                    sum += distance;
                }

                distance += distance * 0.1;

                if (sum >= 100)
                {
                    Console.WriteLine("\nDone more than 100km in {0} days", day);
                    break;
                }
            }
        }

        private static void Test4()
        {
            /*32.Дано вещественное число x.Вычислить.(x-1)*(x-3)..(x-63)/(x-2)(x-4)..(x-64)*/

            
            Console.WriteLine("Enter integer number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            double numerator = 1, denominator=1;

            for (int i = 1; i <= 64; i += 2)
            {
                numerator *= (x - i);
                denominator *= (x - (i+1));

                // Explanation block
                //Console.WriteLine("\n\tIteration " + i);
                //Console.WriteLine("numerator\t {0}", numerator);
                //Console.WriteLine("denominator\t {0}", denominator);
            }

            Console.WriteLine("\nResult is {0:N}", numerator/ denominator);
            
        }

        private static void Test5()
        {
            /*5.Написать программу, которая выводит на экран таблицу квадратов и кубов целых чисел а от 1 до 10.
              Столбцы таблицы должны иметь обозначения, например, а, а^ 2, а ^ 3.*/

            Console.WriteLine("a\ta^2\ta^3\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}",i, i*i, Math.Pow(i,3));
            }
        }

        private static void Test6()
        {
            /*19.Рассчитать значения у для значений х, равных 4, 5, ..., 28,
            если у задается следующей формулой: у = 2t2 + 5,5t – 2, t = х + 2*/

            Double y = 0;
            Console.WriteLine("x\tResult");
            for (int x = 4; x < 29; x++)
            {
                double te = x + 2;
                y = 2 * Math.Pow(te,2) + 5.5 * te - 2;

                Console.WriteLine("{0}\t{1}",x,y);
            }
        }
    }
}
