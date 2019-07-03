using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_PROJECT_WF.Models
{
    public class Wholesale_Purchase
    {
        [Key]
        public int IdPurchase { get; set; }

        public DateTime Purchase_Date { get; set; }

        public float Total_Sum { get; set; }

        public Wholesaler Wholesaler { get; set; }

        public Wholesale_Purchase(DateTime purchase_Date, float total_Sum, Wholesaler wholesaler)
        {
            Purchase_Date = purchase_Date;
            Total_Sum = total_Sum;
            Wholesaler = wholesaler;
        }

        public Wholesale_Purchase(DateTime purchase_Date, float total_Sum)
        {
            Purchase_Date = purchase_Date;
            Total_Sum = total_Sum;
        }
    }
}
