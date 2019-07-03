using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_PROJECT_WF.Models
{
    public class Manufacturer
    {
        [Key]
        public int IdManufacturer { get; set; }
        [MaxLength(20)]
        public string Name { get;set;}
        [MaxLength(20)]
        public string Location { get; set; }

        public Boolean Has_Licence { get; set; }

        public List<Medicine> Products = new List<Medicine>();

        public Manufacturer(string Name,string Location,Boolean Has_Licence)
        {
            this.Name = Name;
            this.Location = Location;
            this.Has_Licence = Has_Licence;
        }

        public void AddProduct(Medicine m)
        {
            if (!this.Products.Contains(m))
                this.Products.Add(m);
        }

        public void RemoveProduct(Medicine m)
        {
            if (this.Products.Contains(m))
                this.Products.Remove(m);
        }

        override
        public string ToString()
        {
            return "Manufacturer: " + this.Name + " " + this.Location;
        }
    }
}
