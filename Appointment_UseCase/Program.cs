using Infrastructure;

namespace Appointment_UseCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();
            bool isTerminate = false;
          
            while(!isTerminate) 
            {
                Console.WriteLine("---------------------ONLINE BOOKING SYSTEM-----------------");
                Console.WriteLine("1) Add appointment , 2) Delete appointment , 3) Show appointment list , 4)Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        repository.AddAppointment();
                        break;
                    case "2":
                        Console.Clear();
                        repository.delete();
                        break;
                    case "3":
                        Console.Clear();
                        repository.display();
                        break;
                    case "4":
                        Console.Clear();
                        isTerminate = true;
                        Console.WriteLine("System terminating");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Enter valid key");
                        break;
                }
            }
        }
    }
}