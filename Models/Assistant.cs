using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_PROJECT_WF.Models
{
    [Table("Assistants")]
    public class Assistant : Worker
    {
        private int _pay;
        public int Pay_Per_Hour
        {
            get { return _pay; }
            set
            {
                if (value > 100)
                    throw new Exception("Pay per hour is too high");
                else _pay = value;
            }
        }

        public Pharmacist Pharmacist { get; set; }

        public Assistant() { }

        public Assistant(string name, string email, DateTime hire_date, int salary)
        {
            this.Name = name;
            this.Email = email;
            this.Hire_Date = hire_date;
            this.Salary = salary;
            this.Pay_Per_Hour = 20;
        }

        public Assistant(string name, string email, DateTime hire_date, int salary, int pay_pay_hour)
        {
            this.Name = name;
            this.Email = email;
            this.Hire_Date = hire_date;
            this.Salary = salary;
            this.Pay_Per_Hour = pay_pay_hour;
        }
        public void setPharmacist(Pharmacist p)
        {
            if (this.Pharmacist != null)
                this.Pharmacist.RemoveAssitant(this);
            this.Pharmacist = p;
            p.AddAssitant(this);
        }

        /// <summary>
        /// count salary based on houres
        /// </summary>
        /// <returns>
        /// total salary
        /// </returns>
        /// <param name="houres">int</param>
        public int Count_Salary(int houres)
        {
            return Salary + Pay_Per_Hour * houres;
        }

        override
        public string ToString()
        {
            return "Assistant: " + this.Name + " " + this.Salary + " " + this.Pay_Per_Hour;
        }

    }
}
