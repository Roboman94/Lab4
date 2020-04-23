using System;


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

                //Builds array of data for each column
                while (userint >= 1)
                {
                    int i = 0;

                    int[] numcol1 = new int[userint];
                    numcol1[i] = userint;

                    int[] numcol2 = new int[numcol1[i]];
                    numcol2[i] = numcol1[i] * numcol1[i];

                    int[] numcol3 = new int[numcol1[i]];
                    numcol3[i] = numcol1[i] * numcol1[i] * numcol1[i];


                    Console.WriteLine("{0}", string.Join("        ", numcol1[i], numcol2[i], numcol3[i]));

                    --userint;
                    ++i;

                }




                proceeding = Proceed();


            }


        }
        //numcol1 //sqcol2 //cucol3


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
            Console.WriteLine(message);
            string input = Console.ReadLine();
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
