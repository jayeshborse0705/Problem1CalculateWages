namespace PractiseProblem1
{
    public class Program
    {
        public int EmpPresent = 1;
        public int TotalWage;
        public int dailywage = 20;
        public int hour = 8;
        public int parttime = 4;
        public int FullTime = 1;
        public void CheckEmpPresentAbsent()
        {
            Random check = new Random();
            int CheckEmp = check.Next(0, 2);
            if (EmpPresent==CheckEmp)
            {
                Random TimeCheck = new Random();
                int CheckTime = TimeCheck.Next(0, 2);
                if (FullTime==CheckTime)
                {
                    int TotalWage = dailywage*hour;
                    Console.WriteLine("Wage of full time employee:" +TotalWage);
                }
                else
                {
                    int TotalWage = parttime*dailywage;
                    Console.WriteLine("wage of part time employee:" +TotalWage);
                }

            }

            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        public static void Main(String[] args)
        {
            Program prg = new Program();
            prg.CheckEmpPresentAbsent();
        }
    }
}