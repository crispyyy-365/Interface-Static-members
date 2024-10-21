namespace code.homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new ("Huseyn", "Abbasov");
            Student stud2 = new("Nihat", "Abbasov");
            Student stud3 = new("Elshen", "Mahmudov");
            Student stud4 = new("Elvin", "Abdullayev");
            Student stud5 = new("Selcan", "Karimli");
            Student stud6 = new("Tebriz", "Nomaliyev");
            Student stud7 = new("Fidan", "Esedzade");
            Student stud8 = new("Jesse", "Pinkman");
            Group group1 = new("Beavers");
            Group group2 = new("Crocodiles");

            group1.AddStudent(stud1);
            group1.AddStudent(stud2);
            group1.AddStudent(stud3);
            group1.AddStudent(stud4);
            group2.AddStudent(stud5);
            group2.AddStudent(stud6);
            group2.AddStudent(stud7);
            group2.AddStudent(stud8);

            group1.GetGroupInfo();
            group1.ShowStudents();
            group2.GetGroupInfo();
            group2.ShowStudents();
            Group.ShowAllGroups();
        }
    }
}
