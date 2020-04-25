using System;
using System.Linq;


namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            int userint = 0;
            string[] rowset = new string[userint];
            bool proceeding = true;
            while (proceeding == true)
            {
                userint = IntPar("Enter an integer ");
                int x = 0;
                

                //Table Header
                var datatab = DatTabA();
                Console.WriteLine("{0}", string.Join("   ", datatab[0], datatab[1], datatab[2]));
                datatab = DatTabB();
                Console.WriteLine("{0}", string.Join("   ", datatab[0], datatab[1], datatab[2]));




                //Builds array of data for each column
                for (int i=userint; i <= 1; i++)
                {
                   

                    int[] numcol1 = new int[userint];
                    numcol1[i] = userint;

                    int[] sqmcol2 = new int[numcol1[i]];
                    sqmcol2[i] = numcol1[i] * numcol1[i];

                    int[] cumcol3 = new int[numcol1[i]];
                    cumcol3[i] = numcol1[i] * numcol1[i] * numcol1[i];

                    
                    rowset[i] = string.Join("        ", numcol1[i], sqmcol2[i], cumcol3[i]);

                   

                }

                //Unable to pass array data "rowset[]" to this while loop for reverse order printing
                for (int i = userint; i <= 0; i--)
                {

                    Console.WriteLine($"{rowset[i]}");
                  
                }
                proceeding = Proceed();

            }
        }

        public static string[] DatTabA()
        {
            string header = "Number Squared Cubed";
            var headarray = header.Split(' ');
            return headarray;
        }
        public static string[] DatTabB()
        {

            string border = "====== ====== ======";
            var borderarray = border.Split(' ');
            return borderarray;
        }

        public static int IntPar(string message)
        {
            string input = " ";
            int validcheck = 1;
            while (validcheck == 1)
            {
                Console.WriteLine(message);
                input = Console.ReadLine();

                if (input.All(char.IsNumber))
                {
                    validcheck = 0;
                }
                else
                {
                    validcheck = 1;
                    Console.WriteLine("Invalid entry. Please try again.");
                }
            }
          int num = int.Parse(input);
          return num;
        }

        public static bool Proceed()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to continue? (y/n) ");
            string proceed = Console.ReadLine();
            if (proceed.ToLower().StartsWith("y"))
            {
                return true;
            }
            if (proceed.ToLower().StartsWith("n"))
            {
                Console.WriteLine("thank you!");
                Console.WriteLine();
                return false;
            }
            else
            {
                Console.WriteLine("Invalid entry. Please try again");
                return Proceed();
            }
        }
    }
}