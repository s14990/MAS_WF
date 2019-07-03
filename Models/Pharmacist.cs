using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_PROJECT_WF.Models
{
    [Table("Pharmacists")]
    public class Pharmacist : Worker
    {
        private int Bonus;
        private int Rating;

        public List<Assistant> Assistants = new List<Assistant>();

        [NotMapped]
        private Dictionary<int, Certificate> Certificates = new Dictionary<int, Certificate>();

        private bool was_maped { get; set; } = false;

        public List<Certificate> Certificates_List = new List<Certificate>();

        /// <summary>
        /// Fills Dictionary with certificates
        /// </summary>
        public void Map_Certificates()
        {
            foreach(Certificate c in Certificates_List)
            {
                if (!this.Certificates.ContainsKey(c.IdCertificate))
                    Certificates.Add(c.IdCertificate, c);
            }
        }

        public Pharmacist() { }

        public Pharmacist(string name, string email, DateTime hire_date, int salary, int rating)
        {
            this.Name = name;
            this.Email = email;
            this.Hire_Date = hire_date;
            this.Salary = salary;
            this.SetRating(rating);
            this.Bonus = 100;
        }

        public Pharmacist(string name, string email, DateTime hire_date, int salary, int rating, int bonus)
        {
            this.Name = name;
            this.Email = email;
            this.Hire_Date = hire_date;
            this.Salary = salary;
            this.SetRating(rating);
            this.Bonus = bonus;
        }

        /// <summary>
        /// Add certificates to the dictionary with the CertId as the key
        /// </summary>
        /// <param name="c">Certificate</param>
        public void AddCertificate(Certificate c)
        {
            if (this.was_maped == false)
                this.Map_Certificates();
            if (!this.Certificates.ContainsKey(c.IdCertificate))
            {
                this.Certificates.Add(c.IdCertificate, c);
                this.Certificates_List.Add(c);
                c.AddOwner(this);
            }

        }

        /// <summary>
        /// Returns certificate by id
        /// </summary>
        /// <exception cref="System.Exception"> No such identifier was found</exception>
        /// <param name="id">Id of Certificate</param>
        public Certificate GetCertificate(int id)
        {
            if (this.Certificates.ContainsKey(id))
                return this.Certificates[id];
            else
                throw new Exception("no Certificate number " + id + " was found");
        }

        /// <summary>
        /// count total salary
        /// </summary>
        /// <returns>
        /// total salary
        /// </returns>
        override
        public int Count_Salary()
        {
            return Salary + Bonus;
        }

        public int getRating()
        {
            return this.Rating;
        }

        public void SetRating(int rating)
        {
            if (rating < 1 && rating > 5)
            {
                Console.WriteLine("Rating is too high");
                this.Rating = 0;
            }
            else
                this.Rating = rating;
        }

        public int GetBonus()
        {
            return this.Bonus;
        }

        public void SetBonus(int bonus)
        {
            if (this.Bonus < 100)
                this.Bonus = bonus;
            else if (bonus < this.Bonus * 3)
            {
                Console.WriteLine("New bonus is too high");
            }
        }

        public void AddAssitant(Assistant s)
        {
            if (!this.Assistants.Contains(s))
                this.Assistants.Add(s);
        }

        public void RemoveAssitant(Assistant s)
        {
            if (this.Assistants.Contains(s))
                this.Assistants.Remove(s);
        }

        override
        public string ToString()
        {
            return "Pharmacist: " + this.Name + " Salary: " + this.Salary + " Bonus: " + this.Bonus;
        }


    }
}
