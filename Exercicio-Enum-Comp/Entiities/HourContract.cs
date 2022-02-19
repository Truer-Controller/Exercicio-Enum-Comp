
using System;

namespace Exercicio_Enum_Comp.Entiities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHours { get; set; }
        public int HoursWorking { get; set; }

        public HourContract()
        {
        }
        public HourContract(DateTime date, double valuePerHours, int hoursWorking)
        {
            Date = date;
            ValuePerHours = valuePerHours;
            HoursWorking = hoursWorking;
        }
        public double TotalValue()
        {
            return HoursWorking * ValuePerHours;
        }
    }
}
