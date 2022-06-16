using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompanyArray
{
    internal class EmployeeWageCompany
    {

        public const float EmpWagePerHour = 20;
        public const int FullTime_WorkingHrs_PerDay = 8;
        public const int PartTime_WorkingHrs_PerDay = 4;
        public const int MAX_WORKING_HRS = 100;
        public const int MAX_WORKING_DAYS = 20;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int IS_ABSENT = 0;
        public float EmpDailyWage = 0;
        public float TotalWage = 0;
        private Dictionary<string, Company> Companies = new Dictionary<string, Company>();
        public string[] CompanyList;
        public int ArrayIndex = 0;
        public EmployeeWageCompany(int number)
        {
            CompanyList = new string[number * 2];
        }
        public void AddCompany(string CompanyName, int EmpWagePerHour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHrs_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS)
        {
            Company company = new Company(CompanyName.ToLower(), EmpWagePerHour, FullTime_WorkingHrs_PerDay, PartTime_WorkingHrs_PerDay, MAX_WORKING_HRS, MAX_WORKING_DAYS);
            Companies.Add(CompanyName.ToLower(), company);
            CompanyList[ArrayIndex] = CompanyName;
            ArrayIndex++;
        }
        public int IsEmployeePresent()
        {
            return new Random().Next() % 3;
        }
        public void CalucalteWage(string CompanyName)
        {
            int Daynumber = 1;
            int EmpworkingHrs = 0;
            int TotalWorkingHrs = 0;
            /*foreach(var key in Companies.Keys)
            {
                Console.WriteLine(key);
            }*/
            if (Companies.ContainsKey(CompanyName.ToLower()))
            {
                throw new ArgumentNullException("Company Doesnt Exist");
            }
            Companies.TryGetValue(CompanyName.ToLower(), out Company company);

            while (Daynumber <= MAX_WORKING_DAYS && TotalWorkingHrs <= MAX_WORKING_HRS)
            {
                switch (IsEmployeePresent())
                {
                    case IS_ABSENT:
                        EmpworkingHrs = 0;
                        break;
                    case IS_PART_TIME:
                        EmpworkingHrs = PartTime_WorkingHrs_PerDay;
                        break;
                    case IS_FULL_TIME:
                        EmpworkingHrs = FullTime_WorkingHrs_PerDay;
                        break;
                }
                EmpDailyWage = EmpworkingHrs * EmpWagePerHour;

                TotalWage += EmpDailyWage;
                Daynumber++;
                TotalWorkingHrs += EmpworkingHrs;


            }
            CompanyList[ArrayIndex] = Convert.ToString(TotalWorkingHrs);
            ArrayIndex++;
            Console.WriteLine("Total Working days : " + (Daynumber) + "\nTotal Working hours : " + (TotalWorkingHrs) + "\nTotal Wage :" + (TotalWage));
        }
        public void displayArray()
        {
            for (int i = 0; i < CompanyList.Length; i+=2)
            {
                Console.WriteLine("Monthly Wage for {0} is {1} name", CompanyList[i], CompanyList[i + 1]);
            }
        }
    }
}

