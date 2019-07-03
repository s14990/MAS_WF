using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_PROJECT_WF.Models
{
    public class Batch
    {
        [Key]
        public int IdBatch { get; set; }

        public DateTime Due_Date { get; set; }

        public int Number { get; set; }

        public Medicine Medicine { get; set; }

        public Wholesale_Purchase Wholesale_Purchase {get;set;}

        public Order Order { get; set; }

        private Batch(DateTime due_Date, int number, Medicine medicine, Wholesale_Purchase wholesale_Purchase,Order order)
        {
            Due_Date = due_Date;
            Number = number;
            Medicine = medicine;
            Wholesale_Purchase = wholesale_Purchase;
        }

        private Batch(DateTime due_Date, int number)
        {
            Due_Date = due_Date;
            Number = number;
        }


        /// <summary>
        /// Creates batch if as part of order 
        /// </summary>
        /// <returns>
        /// new Batch
        /// </returns>
        /// <param name="due_Date">DateTime </param>
        /// <param name="number">count of med</param>
        /// <param name="medicine">Medicine </param>
        /// <param name="wholesale_Purchase">Wholesale Purchase</param>
        public static Batch CreateBatch(DateTime due_Date, int number, Medicine medicine, Wholesale_Purchase wholesale_Purchase, Order order)
        {
            if (order == null)
                throw new Exception("no Order was provided");
            else
               return new Batch(due_Date, number, medicine, wholesale_Purchase,order);
        }

        override
        public string ToString()
        {
            return "Batch " +this.IdBatch + " Medicine: " + this.Medicine.Name + " Order: " + this.Order.IdOrder;
        }

    }
}
