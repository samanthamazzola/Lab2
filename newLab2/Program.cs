using System;

namespace Lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //TO DO: string split so that you can evaluate in the same line feet and inches and convert to a whole number value
            //Console.WriteLine("Enter Length (exm: 2' 6"): ");

            //input
            double Length;
            double Width;
            double Height;
            double Area;
            double Perimeter;
            double Volume;


            Console.WriteLine("Enter Length (exm: 12.5): ");
            Length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Width (exm: 12.5): ");
            Width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Height (exm: 12.5): ");
            Height = Convert.ToDouble(Console.ReadLine());


            Area = (Length * Width);
            Perimeter = (Length * 2 + Width * 2);
            Volume = (Length * Width * Height);

            //output
            Console.Write($"Area: {Area}");
            Console.WriteLine();
            Console.Write($"Perimeter: {Perimeter}");
            Console.WriteLine();
            Console.Write($"Volume: {Volume}");
            Console.WriteLine();


            //loop
            String Answer;

            Console.WriteLine("Continue? (y/n)");
            //instead of using ORs you can do Convert.ToInput 
            if (!(Console.ReadLine() == "y") || (Console.ReadLine() == "Y") || (Console.ReadLine() == "Yes") || (Console.ReadLine() == "YES") || (Console.ReadLine() == "yes"))
            {
                Console.WriteLine("Enter Length (exm: 12.5): ");
                Length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Width (exm: 12.5): ");
                Width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Height (exm: 12.5): ");
                Width = Convert.ToDouble(Console.ReadLine());


                Area = (Length * Width);
                Perimeter = (Length * 2 + Width * 2);
                Volume = (Length * Width * Height);

                //output
                Console.Write($"Area: {Area}");
                Console.WriteLine();
                Console.Write($"Perimeter: {Perimeter}");
                Console.WriteLine();
                Console.Write($"Volume: {Volume}");
                Console.WriteLine();
            }
            else
            {
                return;
            }
            //do goes around the whole code and the while at the end, then need a bool set at true????
            //this is my change

        }
    }
}
