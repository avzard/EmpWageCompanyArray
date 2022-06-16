namespace EmpWageCompanyArray
{
    internal class Company
    {
        public float EmpWagePerHour = 20;
        public int FullTime_WorkingHrs_PerDay = 8;
        public int PartTime_WorkingHrs_PerDay = 4;
        public int MAX_WORKING_HRS = 100;
        public int MAX_WORKING_DAYS = 20;
        public string CompanyName;

        public Company(string CompanyName, int EmpWagePerHour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHrs_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS)
        {
            this.CompanyName = CompanyName;
            this.EmpWagePerHour = EmpWagePerHour;           
            this.FullTime_WorkingHrs_PerDay = FullTime_WorkingHrs_PerDay;            
            this.PartTime_WorkingHrs_PerDay = PartTime_WorkingHrs_PerDay;           
            this.MAX_WORKING_HRS = MAX_WORKING_HRS;           
            this.MAX_WORKING_DAYS = MAX_WORKING_DAYS;
        }
    }
}