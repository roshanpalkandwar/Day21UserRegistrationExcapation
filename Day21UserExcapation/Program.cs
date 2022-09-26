namespace Day21UserExcapation
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Chosee a oprtion");
            Console.WriteLine("1. UC1 - Validate First Name");
            Console.WriteLine("2. UC2 - Validate Last Name");
            Console.WriteLine("3. UC3 - Validate Email Address");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FirstNamePattern.ValidateFirstName();
                    break;
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
                    case 2:
                    ValidateLastName1.ValidateLastName();
                    break;
                case 3:
                    ValidateEmail1.ValidateEmail();
                    break;
            }
        }
    }
}