using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public class SULSTest
    {
        static void Main()
        {
            Trainer trainer = new Trainer("Gosho", "Goshev", 60);
            JuniorTrainer jTrainer = new JuniorTrainer("Pesho", "Peshev", 34);
            SeniorTrainer sTrainer = new SeniorTrainer("Misho", "Mishev", 47);
            trainer.CreateCourse("OOP");
            jTrainer.CreateCourse("HQC");
            sTrainer.DeleteCourse("Advanced C");
            Console.WriteLine();
            DropoutStudent dropout = new DropoutStudent("Onufri", "Onufriev", 23, 6722, 2.23, "Losh uspeh!");
            dropout.Reapply();
            Console.WriteLine();

            var people = new List<Person>
        {
            new Person("Georgi", "Georgiev", 30),
            new Trainer("Ivan", "Ivanov", 18),
            new JuniorTrainer("Pencho", "Penev", 29),
            new SeniorTrainer("Gincho", "Ginev", 45),
            new Student("Lesho", "Leshev", 42, 1234, 5.75),
            new DropoutStudent("Misho", "Mihaylov", 25, 1234, 3.5, "Too few women on campus."),
            new GraduateStudent("Toncho", "Tonev", 31, 1234, 5.25),
            new CurrentStudent("Stamat", "Stamatov", 23, 1234, 3.25, "OOP"),
            new OnlineStudent("Mincho", "Minchev", 21, 1234, 2.5, "OOP"),
            new OnsiteStudent("Svetlin", "Nakov", 34, 1234, 6, "OOP", 15),
            new CurrentStudent("Tosho", "Toshev", 43, 1234, 4.25, "QPC"),
            new OnlineStudent("Onufrii", "Popchev", 63, 1234, 5.15, "QPC"),
            new OnsiteStudent("Maria", "Stoeva", 19, 1234, 5.86, "QPC", 12)
        };

            List<CurrentStudent> currStudents = people.Where(a => a is CurrentStudent).ToList().Cast<CurrentStudent>().ToList();
            var sortedCurrStudents = currStudents.OrderBy(a => a.AverageGrade);

            Console.WriteLine("List of current students (sorted by average grade):");
            Console.WriteLine();

            foreach (var student in sortedCurrStudents)
            {
                Console.WriteLine(student);
            }

        }
    }
}
