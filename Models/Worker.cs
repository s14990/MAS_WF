using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_PROJECT_WF.Models
{
    public abstract class Worker
    {
        [Key]
        public int IdWorker { get; set; }
        [MaxLength(20)]
        [Index(IsUnique = true)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }

        public DateTime Hire_Date { get; set; }

        [Required]
        public int Salary { get; set; }

        public List<Practise> Practises { get; set; } = new List<Practise>();

        /// <summary>
        /// Gets all unique branches where this worker was
        /// </summary>
        /// <returns>
        /// List of branches
        /// </returns>
        public List<Branch> GetAllBranches()
        {
            List<Branch> branches = new List<Branch>();
            foreach (Practise p in Practises)
            {
                Branch b = p.Branch;
                if (!branches.Contains(b))
                    branches.Add(b);
            }
            return branches;
        }


        virtual public int Count_Salary()
        {
            return Salary;
        }

        public void Add_Practise(Practise p)
        {
            if (!this.Practises.Contains(p))
                this.Practises.Add(p);
        }

        public void Remove_Practise(Practise p)
        {
            if (this.Practises.Contains(p))
                this.Practises.Remove(p);
        }
    }

}
