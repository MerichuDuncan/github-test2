using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeproject2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, fullName, howFeel, Howweather;

            Console.WriteLine("Enter you first name");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name");
            lastName = Console.ReadLine();

            fullName = string.Concat(firstName, "", lastName);

            Console.WriteLine("Hello " + fullName + "! Are you doing well today?");
            howFeel=Console.ReadLine();

            if (howFeel == "yes" || howFeel== "YES" || howFeel== "Yes")
            {
                Console.WriteLine("That is wonderful " + fullName + " ! So am I!");
            }
            else if (howFeel == "no" || howFeel == "NO" || howFeel == "No") 
            {
                Console.WriteLine("I'm so sorry to hear that " + fullName + ". That's really ashame!");
            }
            else
            {
                Console.WriteLine("I'm so sorry I am not programmed to interpret that response");
            }
            Console.WriteLine("How is the weather? " + fullName + " Is it cold or warm today?");
            Howweather = Console.ReadLine();

            if(Howweather=="cold" || Howweather=="warm")
            {
                Console.WriteLine("It could be worse!  "+ fullName);
            }
             

          



        }
    }
}
