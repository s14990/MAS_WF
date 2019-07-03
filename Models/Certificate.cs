using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_PROJECT_WF.Models
{
    public class Certificate
    {
        [Key]
        public int IdCertificate { get; set; }
        [MaxLength(20)]
        public string FullName { get; set; }
        [MaxLength(5)]
        public string ShortName { get; set; }

        public List<Pharmacist> Owners { get; set; } = new List<Pharmacist>();

        public Certificate (string FullName,string ShortName)
        {
            this.FullName = FullName;
            this.ShortName = ShortName;
        }

        /// <summary>
        /// Adds owner to the list
        /// </summary>
        /// <param name="p">Pharmacist</param>
        public void AddOwner(Pharmacist p)
        {
            if (!this.Owners.Contains(p))
                this.Owners.Add(p);
        }


        override
        public string ToString()
        {
            return "Certificate: " + this.IdCertificate + " " + this.ShortName + " " + this.FullName;
        }
    }
}
