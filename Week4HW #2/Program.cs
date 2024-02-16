using System.Linq.Expressions;

namespace Week4HW__2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const double SICK_APPT_CHILD_PRICE = 50;
            const double SICK_APPT_ADULT_PRICE = 75;
            const double LAB_WORK_PRICE = 25;
            const double CHECK_UP_CHILD_PRICE = 75;
            const double CHECK_UP_ADULT_PRICE = 100;
            String appType, isChild, labWork;
            double price = 0;


            Console.WriteLine("Are you here for a check up or an appointment?");
            appType = Console.ReadLine();

            switch (appType)
            {
                case "appointment":
                    Console.WriteLine("Are you a child or an adult");
                    isChild = Console.ReadLine();
                    Console.WriteLine("Did you have labwork done");
                    labWork = Console.ReadLine();
                    if (isChild == "child")
                        price = SICK_APPT_CHILD_PRICE;
                    else
                        price = SICK_APPT_ADULT_PRICE;
                    if (labWork == "yes")
                        price += LAB_WORK_PRICE;

                    Console.WriteLine("Your total is {0}", price.ToString("C"));

                    break;
                case "check up":
                    Console.WriteLine("Are you a child or an adult");
                    isChild = Console.ReadLine();
                    if (isChild == "child")
                        price = CHECK_UP_CHILD_PRICE;
                    else
                        price = CHECK_UP_ADULT_PRICE;

                    Console.WriteLine("Your total is {0}", price.ToString("C"));

                    break;
                default:
                    Console.WriteLine("You entered an invalid response");

                    break;
            }

        }
    }
}
