using System;
using System.Security.Cryptography.X509Certificates;

namespace Ivan_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ** Will ** I've only called your FirstPromt ( MainMenu() ) method. 
            // Everything else is called inside MainMenu()

            MainMenu(); 
        } // Main

        // ** Will **
        /* 
        I did some simple cleanup to your menus, the logic and structure was great!

        - Removed any Non Menu Logic. 
            - Anything where you did calculations, like add and subtract, I just called the method associated with that.
            - I Created methods for any non menu logic, like all your financial calculator and geometry stuff
            - This organizes the code so it's easy to read, and seperates functionality. Your menu should only do menu stuff. And then you call your methods to do the other stuff.
        - Added do / while loops to repeat the menu ( and got rid of the try catch doing it )
            - I wrapped all your menus in a do while loop. 
            - We created a single "bool isRunning" variable set to true before the loop.
            - As long as it is true, the code will keep looping
            - Inside of your condition to exit ( choice == "e') we can set it to false.
            - This tells the do while to stop looping and exits the method.
            - You can have loops inside of loops. So your menus are nested loops. You have one loop around your entire menu, then you have a loop for each sub menu ( calculator, finance, geometry )
                - Main Loop {
        
                    Calculator Loop {
                        perform math code until it stops.
                        when user presses e to exit calculator....
                    }

                    ... it comes back to the main loop. And you can keep looping here
                    until the user says they want to exit the app. Then this closes
                }
         */

        // ** Will ** This was your FirstPromt()
        // I renamed it to MainMenu()
        public static void MainMenu() 
        {
            bool isRunning = true;

            do
            {
                Console.WriteLine("Ivan Zarate Chavez - 4/29/2022");
                Console.WriteLine("Programing 120 midterm");
                Console.WriteLine("1 - Personal Calculator");
                Console.WriteLine("2 - Finance Calculator");
                Console.WriteLine("3 - Geometry Calculator");
                Console.WriteLine("");
                Console.WriteLine("e - Exit");
                Console.WriteLine("Choose your Selection");

                // ** Will ** Switched it to lower case (c)hoice for our naming convention
                string choice = Console.ReadLine(); 

                if (choice == "1")
                {
                    CalculatorMenu();
                }
                else if (choice == "2")
                {
                    FinancialMenu();
                }
                else if (choice == "3")
                {
                    GeometryMenu();
                }
                else if (choice == "e") //im done so this needed nothing and it works just fine, it works as intended there is a lot of unused stuff for practice
                {
                    Console.WriteLine("Good Bye");
                    isRunning = false;
                }
            } while (isRunning == true);

        } // MainMenu() 

        


        // Menu Methods ---------------
        public static void CalculatorMenu() //this is personal calculator stuff
        {
            bool isRunning = true;
            do
            {
                Console.WriteLine("personal calculator");
                Console.WriteLine("Enter Your First Number: ");
                string A = Console.ReadLine();
                Console.WriteLine("+ - add");
                Console.WriteLine("- - subract");
                Console.WriteLine("* - multiply");
                Console.WriteLine("/ divide");
                Console.WriteLine("e - exit personal calculator");
                string Choice = Console.ReadLine();

                // ** Will ** I just called the methods you created instead of retyping code
                if (Choice == "+")
                {
                    adds();
                }
                else if (Choice == "-")
                {
                    subs();
                }
                else if (Choice == "*")
                {
                    Multiply();
                }
                else if (Choice == "/")
                {
                    divide();
                }
                else if (Choice == "e")
                {
                    Console.WriteLine("Exiting the Calculator");
                    isRunning = false;
                }
            } while (isRunning == true);

        } // End CalculatorMenu()

        public static void FinancialMenu() //this is finance calculator stuff
        {
            bool isRunning = true;

            do
            {
                Console.WriteLine("finance calculator");
                Console.WriteLine("1 - Net Income");
                Console.WriteLine("2 - Rule of 72");
                Console.WriteLine("3 - Net Worth");
                Console.WriteLine("e - exit Finance calcultor");
                Console.WriteLine("Please Choose and option:");
                Console.WriteLine("if You messed up and pressed the wrong button press r during any selection");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    NetIncome();
                }
                else if (choice == "2")
                {
                    Rule72();

                }
                else if (choice == "3")
                {
                    NetWorth();
                }
                else if (choice == "e")
                {
                    Console.WriteLine("Exiting Finance calculator...");
                    isRunning = false;
                }

            } while (isRunning == true);

        } // FinancialMenu()

        public static void GeometryMenu()//this one gone be tough
        {
            bool isRunning = true;
            do
            {
                Console.WriteLine("Geometry Calculator");
                Console.WriteLine("1 - square");
                Console.WriteLine("2 - rectangle");
                Console.WriteLine("3 - circle");
                Console.WriteLine("4 - right");
                Console.WriteLine("e - exit Geomtry Calculator");

                // ** Will ** Switched it to lower case (c)hoice for our naming convention
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Square();
                }
                else if (choice == "2")
                {
                    Rectangle();
                }
                else if (choice == "3")
                {
                    Circle();
                }
                else if (choice == "4")
                {
                    RightTriangle();
                }
                else if (choice == "e")
                {
                    Console.WriteLine("Exiting the Geometry Calculator");
                    isRunning = false;
                }
            } while (isRunning == true);


        } // GeometryMenu()

        public static void Square()
        {
            try
            {
                Console.WriteLine("square Calculation \ntype any side of the square");
                string A = Console.ReadLine();
                int numa = int.Parse(A);
                int B = 4;
                int C = B * numa;
                Console.WriteLine($"this is your perimiter {C}");
                int D = C / 4;
                int E = D * D;
                Console.WriteLine($"And this will be Your Squares Area {E}");
                Console.WriteLine("Now the program will stop");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a valid number");
            }

        } // Square()

        public static void Rectangle()
        {
            try
            {
                Console.WriteLine("Rectangle Calculation \nNow type the lentgh or the longest side");
                string A = Console.ReadLine();
                int numa = int.Parse(A);
                Console.WriteLine("Now Type Your Width / the other side");
                string B = Console.ReadLine();
                int numb = int.Parse(B);
                int numc = 2 * (numa + numb);
                int numd = numa * numb;
                Console.WriteLine($"Now this will be Your Area {numd}\nand this will be Your Perimiter {numc}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a valid number");
            }
        } // Rectangle()

        public static void Circle()
        {
            try
            {
                Console.WriteLine("Please type the diameter of the circle:");
                double D = double.Parse(Console.ReadLine());
                double radius = D / 2.0;
                double area = Math.PI * Math.Pow(radius, 2); //I watched a Youtube Video for visual studio how to write pie in visual studio
                Console.WriteLine($"The area of the circle is: {area:F2}");//the F2 only picks the first 2 decimal places so it doesnt give a long number
                double C = 2 * Math.PI * radius;

                Console.WriteLine($"The circumference of the circle is {C:F3}"); //also the F thing also Rounds up
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a valid number");
            }

        } // Circle()

        public static void RightTriangle()
        {
            try
            {
                Console.WriteLine("Right calculation \nplease type the Radius of the circular cone");
                string A = Console.ReadLine();
                double r = double.Parse(A);//this wrote its self for me I only pressed tab
                Console.WriteLine("Now Please Type the Hight of the Circular Cone");
                string B = Console.ReadLine();
                double h = double.Parse(B); ; // it didnt auto type this for me though not cool
                double volume = (Math.PI * r * r * h) / 3.0; //to confirm that this worked I searched circular cone with the radius of 3 and a height of 5

                Console.WriteLine($"The volume of the cone is {volume:F2} cubic units."); //this shows closer than Math.Round for me for some reason I dont understand how that one works so I use the F2 to only pick the first 2 if I type F3 then it would type 3 decimal places like 1.111 and all that 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a valid number");
            }

        } // RightTriangle()

        // Calculator Methods --------------------------------

        public static void adds()
        {
            try
            {
                string A = Console.ReadLine();
                string B = Console.ReadLine();

                int numa = int.Parse(A);
                int numb = int.Parse(B);
                int addnum = numa + numb;
                string plus = "+";


                Console.WriteLine($"{numa} {plus} {numb} = {addnum}");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please Enter a valid number");
            }
        } // adds()


        public static void subs()
        {
            try
            {
                string C = Console.ReadLine();
                string D = Console.ReadLine();
                int numc = int.Parse(C);
                int numd = int.Parse(D);
                int subnum = numc - numd;
                string sub = "-";

                Console.WriteLine($"{numc} {sub} {numd} = {subnum}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter a valid number");
            }
        } // subs()

        public static void Multiply()
        {
            try
            {
                string E = Console.ReadLine();
                string F = Console.ReadLine();
                int nume = int.Parse(E);
                int numf = int.Parse(F);
                int multinum = nume * numf;
                string mult = "*";

                Console.WriteLine($"{nume} {mult} {numf} = {multinum}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter a valid number");
            }

        } // Multiply()

        public static void divide()
        {
            try
            {
                string G = Console.ReadLine();
                string H = Console.ReadLine();
                int numg = int.Parse(G);
                int numh = int.Parse(H);
                int divnum = numg / numh;
                string div = "/";

                Console.WriteLine($"{numg} {div} {numh} = {divnum}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter a valid number");
            }

        } // divide

        // Finance Methods ---------------------------------------

        public static void NetIncome()
        {
            try
            {
                Console.WriteLine("what are Your expected profits: ");
                string Ao = Console.ReadLine();
                int numa = int.Parse(Ao);
                Console.WriteLine("and What Are Your expected Losses: ");
                string Bo = Console.ReadLine();
                int numb = int.Parse(Bo);
                int netIncome = numa - numb;
                Console.WriteLine($"Your Net income would end up being ${netIncome}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a valid number");
            }

        } // NetIncome()

        public static void Rule72()
        {
            try
            {
                Console.WriteLine("Enter the expected interest rate");
                string A = Console.ReadLine();
                double nume = double.Parse(A);
                double numf = 72;
                double multinum = numf / nume;
                string div = "/";
                Console.WriteLine($"At an interest rate of {A}, it will take approximately {multinum:F2} years to double your $"); // only the first 2 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a valid number");
            }

        } // Rule72()

        public static void NetWorth()
        {
            try
            {
                Console.WriteLine("Here You will find Your Net Worth");
                Console.WriteLine("Please enter how many Liabilities do You have \nAKA the amount of money You WASTE or use out of nessesity");
                string C = Console.ReadLine();
                int numc = int.Parse(C);
                Console.WriteLine("And now tell me how much You Make in total that You Have before You WASTE any money on anything");
                string D = Console.ReadLine();
                int numd = int.Parse(D);
                int netIncome = numd - numc;
                if (netIncome > 100000)
                {
                    Console.WriteLine("DAMN YOUR RICH");
                    Console.WriteLine($"Your Net Worth will end up being ${netIncome} Good Job");
                }
                else if (netIncome < 0)
                {
                    Console.WriteLine("YOUR BROKE save Your money and fix Your Liabilities so You dont end up being homeless for the future \ndont beat yourself up for it just spend less and your fine only food and shelter are nessisary");
                    Console.WriteLine($"Your Net Worth will end up being ${netIncome} Please Spend Less");
                }
                else if (netIncome < 100000)
                {
                    Console.WriteLine("Nice! You should keep that Money up");
                    Console.WriteLine($"Your Net Worth will end up being ${netIncome} Good Job");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a valid number");
            }

        } // NetWorth()

    } // class

} // namespace