using System;

namespace BethanysPieShopHRM.HR
{
    public class Employee : IComparable, IEmployee
    {
        public int Id { get; set; } 
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string Email { get; set; }
        public int NumberOfHoursWorked { get; set; }
        public double Wage { get; set; }
        public double? HourlyRate { get; set; }
        public static double taxRate = 0.15;
        public DateTime BirthDay { get; set; }
        
        public Employee(int empId, string first, string last, string em, DateTime bd, double? rate)
        {
            Id = empId;
            FirstName = first;
            LastName = last;
            Email = em;
            BirthDay = bd;
            HourlyRate = rate ?? 10;
        }

        public void PerformWork()
        {
            NumberOfHoursWorked++;

            Console.WriteLine($"{FirstName} {LastName} is now working!");
        }


        public void StopWorking()
        {
            Console.WriteLine($"{FirstName} {LastName} has stopped working!");
        }

        public double ReceiveWage()
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");
            NumberOfHoursWorked = 0;

            return Wage;
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 100!");
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nID: {Id}\nFirst name: {FirstName}\nLast name: {LastName}\nEmail: {Email}\nBirthday: {BirthDay.ToShortDateString()}\nTax rate: {taxRate}");
        }

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }

        public int CompareTo(object obj)
        {
            var otherEmployee = (Employee)obj;
            if (Id > otherEmployee.Id)
                return 1;
            else if (Id < otherEmployee.Id)
                return -1;
            else
                return 0;
        }

        public void GiveCompliment()
        {
            Console.WriteLine($"You've done a great job, {FirstName}");
        }
    }
}
