
public class ProgramStruct {
    struct Employee {
        public string firstName;
        public string lastName;
        public int age;
        public string completedTraining;
    }
    public static void Main(string[] args){

        Employee employee1;

        Console.WriteLine("What is your first name?");
        employee1.firstName = Console.ReadLine( );
        Console.WriteLine("What is your last name?");
        employee1.lastName = Console.ReadLine( );
        Console.WriteLine("How old are you?");
        employee1.age = int.Parse(Console.ReadLine( ));
        Console.WriteLine("Do you complete the training?");
        employee1.completedTraining = Console.ReadLine( );
        Console.WriteLine("You entered");
        Console.WriteLine("First Name: "+ employee1.firstName);
        Console.WriteLine("Last Name: "+ employee1.lastName);
        Console.WriteLine("Age: "+ employee1.age);
        Console.WriteLine("Completed Training: "+ employee1.completedTraining);
        }
}
