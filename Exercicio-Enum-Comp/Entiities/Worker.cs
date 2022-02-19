using System;
using System.Collections.Generic;
using Exercicio_Enum_Comp.Entiities.Enums;
using Exercicio_Enum_Comp.Entiities;

namespace Exercicio_Enum_Comp.Entiities
{
    class Worker
    {
        public string NameWorker { get; set; }
        public WorkerLevel Level { get; set; }
        public Departament Departament { get; set; }
        public double BaseSalary { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Worker()
        {
        }
        public Worker(string nameWorker, WorkerLevel level, double baseSalary, Departament department)
        {
            NameWorker = nameWorker;
            Level = level;
            BaseSalary = baseSalary;
            Departament = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
