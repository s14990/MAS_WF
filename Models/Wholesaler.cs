using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_PROJECT_WF.Models
{
    public class Wholesaler
    {

        [Key]
        public int IdWholesaler { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }

        public int Discount { get; set; }

        public int Delay { get; set; }

        public List<Wholesale_Purchase> Purchases = new List<Wholesale_Purchase>();


        public Wholesaler(string email, int discount, int delay)
        {
            Email = email;
            Discount = discount;
            Delay = delay;
        }


        public void AddPurchase(Wholesale_Purchase m)
        {
            if (!this.Purchases.Contains(m))
                this.Purchases.Add(m);
        }

        public void RemovePurchase(Wholesale_Purchase m)
        {
            if (this.Purchases.Contains(m))
                this.Purchases.Remove(m);
        }
    }
}
