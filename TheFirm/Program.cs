namespace TheFirm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JobTitles.Employee employee = new JobTitles.Employee("Rasmus", "Ferst", 021005000);
            JobTitles.Manager employee2 = new JobTitles.Manager("Rasmus", "Ferst", 021005000, 88888888);
            JobTitles.Projectmanager employee3 = new JobTitles.Projectmanager("Rasmus", "Ferst", 021005000, 88888888, "rasmus@gmail.com");
            JobTitles.Sweeper employee4 = new JobTitles.Sweeper("Rasmus", "Ferst", 021005000);

            employee.GetName();
            employee.GetID();
            employee2.GetNumber();
            employee3.GetEmail();
        }
    }
}