using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_PROJECT_WF.Models
{
    public class Medicine
    {
        public Medicine(string name, float price, int total_Available, bool for_Sale)
        {
            Name = name;
            Price = price;
            Total_Available = total_Available;
            For_Sale = for_Sale;
        }

        public Medicine(string name, float price, int total_Available, bool for_Sale, Manufacturer manufacturer, Group group)
        {
            Name = name;
            Price = price;
            Total_Available = total_Available;
            For_Sale = for_Sale;
            Manufacturer = manufacturer;
            Group = group;
            Manufacturer.AddProduct(this);
        }

        [Key]
        public int IdMedicine{get;set;}
        [MaxLength(20)]
        public string Name { get;set;}

        public float Price { get; set; }

        public int Total_Available { get; set; }

        public Boolean For_Sale { get; set; }

        public Manufacturer Manufacturer {
            get { return Manufacturer; }
            set {
                if (this.Manufacturer != null)
                    this.Manufacturer.RemoveProduct(this);
                this.Manufacturer = value;
            }
        }

        public Group Group {
            get { return Group; }
            set
            {
                if (this.Group != null)
                    this.Group.RemoveProduct(this);
                this.Group = value;
            }
        }

    }
}
