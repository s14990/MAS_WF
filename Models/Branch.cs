using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_PROJECT_WF.Models
{
    public class Branch
    {
        [Key]
        public int IdBranch { get; set; }

        [MaxLength(20)]
        public string Kind { get; set; }
        [MaxLength(30)]
        public string Address { get; set; }

        public List<Practise> Practises { get; set; } = new List<Practise>();

        public List<Order> Orders { get; set; } = new List<Order>();


        public static string[] KINDS = { "Apteka", "Punkt" };

        public Branch(string kind, string address)
        {
            Check_Kind(kind);
            Address = address;
        }


        /// <summary>
        /// Checks if kind is in defined range
        /// </summary>
        /// <exception cref="System.Exception">When Kind is wrong</exception>
        /// <param name="s">String that contains kind </param>
        public void Check_Kind(string s)
        {
            if (KINDS.Contains(s))
                this.Kind = s;
            else
                throw new Exception("Wrong Kind");
        }

        /// <summary>
        /// Gets all unique workers
        /// </summary>
        /// <returns>
        /// List of workers
        /// </returns>
        public List<Worker> GetAllWorkers()
        {
            List<Worker> workers=new List<Worker>();
            foreach(Practise p in Practises)
            {
                Worker w = p.Worker;
                if (!workers.Contains(w))
                    workers.Add(w);
            }
            return workers;       
        }

        public void Add_Order(Order o)
        {
            if (!this.Orders.Contains(o))
                this.Orders.Add(o);
        }

        public void Remove_Order(Order o)
        {
            if (this.Orders.Contains(o))
                this.Orders.Remove(o);
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


        override
        public string ToString()
        {
            return "Branch: " + this.IdBranch + " " + this.Address + " " + this.Kind;
        }
    }
}
