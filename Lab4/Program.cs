using System;
using System.Linq;


namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proceeding = true;
            while (proceeding == true)
            {

                int userint = IntPar("Enter an integer ");
                
                

                //Table Header
                var datatab = DatTabA();
                Console.WriteLine("{0}", string.Join("   ", datatab[0], datatab[1], datatab[2]));
                datatab = DatTabB();
                Console.WriteLine("{0}", string.Join("   ", datatab[0], datatab[1], datatab[2]));



                int i = 0;
                int x = userint - 1;
                int y = userint;
                string[] rowset = new string[userint];


                    int[] numcol1 = new int[userint];
                    int[] sqmcol2 = new int[userint];
                    int[] cumcol3 = new int[userint];



                while (i <= x)
                {

                    numcol1[i] = userint;

                    sqmcol2[i] = numcol1[i] * numcol1[i];

                    cumcol3[i] = numcol1[i] * numcol1[i] * numcol1[i];


                    rowset[i] = string.Join("        ", numcol1[i], sqmcol2[i], cumcol3[i]);

                    

                    i++;
                    userint--;
                }

                while(y >= 1)
                {
                    y--;
                    Console.WriteLine(rowset[y]);
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