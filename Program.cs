//Olof Maleki Nordin
//Labb 5 - Grunderna OOP
//.NET23 OOP


namespace GrundernaOOP
{
    internal class Program
    {
        //Variables for holding user input
        int userInput1;
        int userInput2;

        static void Main(string[] args)
        {
            //instanciate new program
            Program program = new Program();

            //Print menu
            program.MainMenu();
        }

        //Method for calculating the circle
        public void CalculateCircle()
        {
            //Tidy up screen
            Console.Clear();

            //Collect user input for calculation
            Console.WriteLine("Du valde cirkel");
            Console.Write("Skriv in radien:");
            userInput1 = GetUserInput();

            //instanciate new circle with user radius
            Circle circle = new Circle(userInput1);

            //Run method GetArea() to calculate and print result
            Console.WriteLine($"Arean är på en cirkel med radie {userInput1} är: {circle.GetArea()}");
        }

        //Method for calculating the triangle
        public void CalculateTriangle()
        {
            //Tidy up screen
            Console.Clear();

            //Collect user input for calculation
            Console.WriteLine("Du valde triangel");
            Console.Write("Skriv in basen:");
            userInput1 = GetUserInput();
            Console.Write("Skriv in höjden:");
            userInput2 = GetUserInput();

            //instanciate new triangle with user base & height
            Triangle triangle = new Triangle(userInput1, userInput2);

            //Run method GetArea() to calculate and print result
            Console.WriteLine($"Arean är på en triangel med basen {userInput1} och höjden {userInput2} är: {triangle.GetArea()}");
        }

        //Method for calculating the rectangle
        public void CalculateRectangle()
        {
            //Tidy up screen
            Console.Clear();

            //Collect user input for calculation
            Console.WriteLine("Du valde rektangel");
            Console.Write("Skriv in basen:");
            userInput1 = GetUserInput();
            Console.Write("Skriv in höjden:");
            userInput2 = GetUserInput();

            //instanciate new rectangle with user base & height
            Rectangle rectangle = new Rectangle(userInput1, userInput2);

            //Run method GetArea() to calculate and print result
            Console.WriteLine($"Arean på en rektangel med basen {userInput1} och höjden {userInput2} är: {rectangle.GetArea()}");
        }

        //Main menu
        public void MainMenu()
        {
            //Loop
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine(" Knappa in siffran på formen");
                Console.WriteLine(" vars area du vill räkna ut");
                Console.WriteLine("++++++++++++++++++++++++++++");
                Console.WriteLine(" [1] Cirkel");
                Console.WriteLine(" [2] Triangel");
                Console.WriteLine(" [3] Rektangel");
                Console.WriteLine("++++++++++++++++++++++++++++");
                Console.WriteLine(" [4] Avsluta");
                Console.WriteLine("++++++++++++++++++++++++++++");

                //Get user menu choice
                int menuChoice = GetUserInput();

                switch (menuChoice)
                {
                    case 1:
                        CalculateCircle();

                        break;

                    case 2:
                        CalculateTriangle();

                        break;

                    case 3:
                        CalculateRectangle();

                        break;

                    case 4:
                        return;
                }

                //Check if user wants to calculate more
                Console.WriteLine("\nTryck [y] för att räkna igen,");
                Console.WriteLine("annars valfri tangen för att avsluta");

                //If not, quit program
                string x = Console.ReadLine();
                if (x.ToLower() != "y")
                {
                    break;
                }
            }
        }

        //Method for getting correct user input
        public int GetUserInput()
        {
            while (true)
            {
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Knappa in ett tal");
                }
            }
        }
    }
}