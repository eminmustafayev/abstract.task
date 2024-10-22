using Abstractions;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            UserClass user = new UserClass(" Emin" , " eminoyun153@gmail.com" ,"Salam123");

            user.ShowInfo();
            if(user.PasswordChecker("Salam123") == true)
            {
                Console.WriteLine("Kod duzdu");
            }
            else
            {
                Console.WriteLine("Kod sehvdi");
            }


            Group students = new Group(5);
            Student telebe = new Student("emin", 45);
            students.AddStudent(telebe);
            students.ShowInfo();

            Console.WriteLine("Qrup daxil edin:");
            string group=Console.ReadLine();
            if (students.CheckGroupNo(group) == true)
            {
                Console.WriteLine("Qrup duzdur");
            }
            else
            {
                Console.WriteLine("qrup sehvdir");
            }
        }

    }
}