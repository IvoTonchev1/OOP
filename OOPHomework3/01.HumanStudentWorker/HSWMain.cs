using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentWorker
{
    public class HSWMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Students:");
            var students = new List<Student>()
            {
                new Student("Gosho", "Goshev", "as2345"),
                new Student("Tosho", "Pehsev", "bs2345"),
                new Student("Tosho", "Toshev", "ass2345"),
                new Student("Gosho", "Mishev", "bd2345"),
                new Student("Pinko", "Pinkov", "cas2345"),
                new Student("Minko", "Minkov", "123s2345"),
                new Student("Pancho", "Panchev", "asds2345"),
                new Student("Onufri", "Mindjakiev", "vbns2345"),
                new Student("Tinko", "Tinkov", "123xas2345"),
                new Student("Tanko", "Tinkov", "xxas2345"),
            };
            var sortedStudents = students.OrderBy(s => s.FacultyNumber);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} - {1}", student, student.FacultyNumber);
            }

            Console.WriteLine("Workers:");
            var workers = new List<Worker>()
            {
                new Worker("Misho", "Gishev", 13.3, 13.4),
                new Worker("Stamat", "Stamatov", 14.3, 13.4),
                new Worker("Stavri", "Stamatov", 15.3, 13.4),
                new Worker("Liolio", "Liolev", 12.3, 13.4),
                new Worker("Lisko", "Lisev", 10.3, 13.4),
                new Worker("Kuma", "Lisa", 130.3, 13.4),
                new Worker("Kumcho", "Valcho", 112.3, 13.4),
                new Worker("Baba", "Meca", 13123.3, 13.4),
                new Worker("Zaio", "Baio", 113.3, 13.4),
                new Worker("Ejko", "Bejko", 3.3, 13.4),
            };
            var sortefWorkers = workers.OrderByDescending(w => w.MoneyPerHour());
            foreach (var worker in sortefWorkers)
            {
                Console.WriteLine("{0} - {1}", worker, worker.MoneyPerHour());
            }

            Console.WriteLine("All");
            var humans = new List<Human>();
            students.ForEach(x => humans.Add(x));
            workers.ForEach(x => humans.Add(x));
            var sortedHumans = humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);
            foreach (var human in sortedHumans)
            {
                Console.WriteLine("{0}", human);
            }
        }
    }
}
