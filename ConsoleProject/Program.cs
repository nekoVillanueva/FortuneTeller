using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{//Neko Villanueva 9/9/18
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message

            Console.WriteLine(" Welcome to the Fortune Teller Project");
            

            Console.WriteLine(" What is your first name? Please enter now below ");
            string nameF = Console.ReadLine().ToLower();
            Console.WriteLine("Hello " + nameF);

            Console.WriteLine(" What is your last name? Please enter below ");
            string nameL = Console.ReadLine().ToLower();
            Console.WriteLine("Very unigue name," + nameF + " " +nameL);

            Console.WriteLine(" What is your age? Please enter below ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(age + " Wow...you are wise beyond your years ");

            int retire = (65 - age);
            bool isEven = retire%2 == 0;

            if (isEven)
            {
                Console.WriteLine(" You will retire in " + retire +  " years which is an even number ");
            }

            else
            {
                Console.WriteLine(" You will retire in "+ retire + " years which is an odd number ");
            }






            Console.WriteLine(" What is your birth month number? ");
            int birth = int.Parse(Console.ReadLine());


            switch (birth)
            {
                case 1:
                    Console.WriteLine("I didnt know you were a Janurary baby!");
                    break;

                case 2:
                    Console.WriteLine("I didnt know you were a Feburary baby!");
                    break;

                case 3:
                    Console.WriteLine("I didnt know you were a March baby!");
                    break;
                case 4:
                    Console.WriteLine("Hey my birthday is in April too");
                    break;
                case 5:
                    Console.WriteLine("I didnt know you were a May baby");
                    break;
                case 6:
                    Console.WriteLine("I didnt know you were a June baby");
                    break;
                case 7:
                    Console.WriteLine("I didnt know you were a July baby");
                    break;
                case 8:
                    Console.WriteLine("I didnt know you were an August baby");
                    break;
                case 9:
                    Console.WriteLine("I didnt know you were a September baby");
                    break;
                case 10:
                    Console.WriteLine("I didnt know you were an October baby");
                    break;
                case 11:
                    Console.WriteLine("I didnt know you were a November baby");
                    break;
                case 12:
                    Console.WriteLine("I didnt know you were a december baby");
                    break;
                default:
                    Console.WriteLine("Invalid Entry please try again at a later time");
                    break;

            }
        





            Console.WriteLine(" Which is your favorite color from ROYGBIV? If confused type help or type exit to close ");
            string color = Console.ReadLine().ToLower();

            switch (color)
            {
                case "r":
                    color = "red range rover";
                    
                    break;
                case "o":
                    color = "orangitang orange oldsmobile";
                    
                    break;
                case "y":
                    color = "yellow yeungling yamaha";
                    
                    break;
                case "g":
                    color = "green gucci gang gucci gangsmobile";
                    
                    break;
                case "b":
                    color = " bodascious blue bugatti";
                    
                    break;
                case "i":
                    color = "infintismally indigo infinity";
                    
                    break;
                case "v":
                    color = "violently violet venenno";
                   
                    break;
                default:
                    Console.WriteLine("Invalid Entry please try again at a later time ");
                    break;
            }
            Console.WriteLine(" I see a beautiful {0} in your future ", color);

            if (color == "help")
            {
                Console.WriteLine(" ROYGBIV represents red, orange, yellow, green, blue, indigo, and violet ");
                return;
            }



            else if (color == "exit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }
            else
            {
                Console.WriteLine("Good Choice ");

            }

            Console.WriteLine(" Please enter your number of siblings? ");
            int sibl = int.Parse(Console.ReadLine());

            string vacaTrue;

            if (sibl < 0)
            {
                
                vacaTrue = "Antartica" ;
            }

            else if (sibl == 0)
            {
                vacaTrue = "China";
            }
            else if (sibl == 1)
            {
                vacaTrue = "Japan";
            }
            else if (sibl == 2)
            {
                vacaTrue = "Australia";
            

            }
            else if (sibl == 3)
            {
                vacaTrue = "America";
            }
            else
            {
                vacaTrue = "Germany";
            
            }
            
            string moneyTrue;

            if ((birth < 0) || (birth > 12))
            {
                moneyTrue= "0";

            }
            else if ((birth > 0) && (birth <= 4))
            {
                moneyTrue= "10000000";

            }
            else if ((birth>4)&&(birth<=8))
            {
                moneyTrue = "500";
            }
            else 
            {
                moneyTrue = "10";

            }
            
            Console.WriteLine( "{0} {1} will retire in {2} years with {3} in the bank, a vacation home in {4} and a {5} to drive ",nameF,nameL,retire,moneyTrue,vacaTrue,color);
        }

    }
    
}



















    

