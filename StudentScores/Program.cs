using System.Xml.Linq;

namespace StudentScores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[10];
            string[][] subjects = new string[4][];
            int[][] scores = new int[4][];
            bool loop = true;
            int c = 0;
            while(loop)
            {
                Console.WriteLine("Add a new student? y/n");
                string addStudent = Console.ReadLine();
                if (addStudent.Equals("y"))
                {
                    Console.WriteLine("Student name :");
                    students[c] = Console.ReadLine();
                    Console.WriteLine("How many subjects?");
                    int amtSubjects = int.Parse(Console.ReadLine());
                    List<string> Lnames = new List<string>();
                    List<int> Lscores = new List<int>();
                    for (int i = 0; i < amtSubjects; i++) 
                    {
                        Console.WriteLine("Subject name :");
                        Lnames.Add(Console.ReadLine());
                        Console.WriteLine("Subject score :");
                        Lscores.Add(int.Parse(Console.ReadLine()));
                    }
                    subjects[c] = Lnames.ToArray();
                    scores[c] = Lscores.ToArray();
                    c++;
                }
                Console.WriteLine("Display student details?> y/n");
                string display = Console.ReadLine();
                if (display.Equals("y"))
                {
                    int p = 0;
                    foreach(string stud in students)
                    {
                        int average = 0;
                        if (stud != null)
                        {
                            Console.WriteLine("------------");
                            Console.WriteLine(stud);
                            Console.WriteLine("------------");
                            int x = 0;
                            foreach (string sub in subjects[p])
                            {
                                Console.Write(sub + "\t:");
                                Console.WriteLine(scores[p][x]);
                                average += scores[p][x];
                                x++;
                            }
                            Console.WriteLine("------------");
                            average = average / x;
                            Console.WriteLine("Average : " + average);
                            Console.WriteLine("------------");
                        }
                        p++;
                    }
                }
                Console.WriteLine("Continue? y/n");
                string cont = Console.ReadLine();
                if (cont.Equals("n"))
                {
                    loop = false;
                }
            }
        }
    }
}
