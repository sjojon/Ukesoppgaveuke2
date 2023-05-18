namespace Ukesoppgaveuke2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //Console.OutputEncoding = System.Text.Encoding.UTF8;

                var studenter = Courses();

                ShowCourses(studenter);
            }
        }

        private static List<Student> Courses()
        {
            List<Student> studenter = new()
            {
                new Student("Heibert", 42, "Radiobilkjøring"),
                new Student("Bård", 29, "Radiobilkjøring"),
                new Student("Tine", 31, "Radiobilkjøring"),
                new Student("Kim", 25, "Data"),
                new Student("Hanne", 21, "Data"),
                new Student("Tore", 35, "Data"),
                new Student("Tom", 20, "Løping"),
                new Student("Tim", 44, "Løping"),
                new Student("Petter", 38, "Løping"),
                new Student("Per", 49, "Koding"),
                new Student("Kåre", 28, "Koding"),
                new Student("Anne", 34, "Koding"),
            };

            List<string> kurs = new();
            foreach (var student in studenter)
            {
                if (!kurs.Contains(student.Kurs))
                {
                    kurs.Add(student.Kurs);
                    Console.WriteLine(student.Kurs);
                }
            }

            return studenter;
        }

        private static void ShowCourses(List<Student> studenter)
        {
            Console.WriteLine("Skriv inn et kurs: ");
            string input = Console.ReadLine().ToLower();

            foreach (var student in studenter)
            {
                if (student.Kurs.ToLower() == input)
                {
                    Console.WriteLine($"{student.Name}, {student.Age}, {student.Kurs}");
                }
            }

            ShowCourses(studenter);
        }


        //var student = {
        //    navn: “Heibert”,
        //    alder: 42,
        //    kurs: Radiobilkjøring
        //};

        //Bruk så denne klassen til å lage flere studenter, og lagre disse i et array eller en List.
        //Gjør så man kan skrive/velge et kurs i konsollen, og så listes studentene på det valgte kurset ut i konsollen.
    }
}