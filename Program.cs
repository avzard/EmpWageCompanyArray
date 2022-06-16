using EmpWageCompanyArray;
namespace EmpWageCompanyArray
{
    class program
    {

        public static void Main(String[] args)
        {
            EmployeeWageCompany Emp = new EmployeeWageCompany(2);
            Emp.AddCompany("TATA ",20,8,4,100,20);
            Emp.CalucalteWage("TATA");
            Emp.AddCompany("Mahindra ", 20, 8, 4, 100, 20);
            Emp.CalucalteWage("Mahindra");
            Emp.displayArray();
        }
    }
}