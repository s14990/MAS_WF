using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_PROJECT_WF.Models
{
    public class Order
    {
        [Key]
        public int IdOrder { get; set; }

        public float Order_Sum { get; set; }

        public string type { get; set; } = "Ordered";

        public DateTime? Order_Date { get; set; }

        public DateTime? Completed_Date { get; set; }

        public List<Batch> Batches = new List<Batch>();

        private Branch _branch;
        public Branch Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != null)
                    _branch.Remove_Order(this);
                _branch = value;
            }
        }


        public Order() { }
        public Order(float order_Sum, DateTime completed_Date, Branch branch)
        {
            Order_Sum = order_Sum;
            Completed_Date = completed_Date;
            Branch = branch;
            type = "Completed";

        }

        public Order(DateTime order_Date, Branch branch)
        {
            Order_Date = order_Date;
            Branch = branch;
        }

        /// <summary>
        /// Completes current_order
        /// </summary>
        /// <exception cref="System.Exception"> If order was already finished</exception>
        /// <param name="completed_Date">DateTime</param>
        public void Complete_Order(DateTime completed_Date)
        {
            if (this.type == "Completed")
                throw new Exception("Cant finish completed order");
            this.Completed_Date = completed_Date;
            this.type = "Completed";
            this.Order_Date = null;
        }

        /// <summary>
        /// Completes current_order
        /// </summary>
        /// <exception cref="System.Exception"> If order was already ordered</exception>
        /// <param name="order_Date">DateTime</param>
        public void Return_To_Order(DateTime order_Date)
        {
            if (this.type == "Ordered")
                throw new Exception("Cant return to order");
            this.Order_Date = order_Date;
            this.type = "Ordered";
            this.Completed_Date = null;
        }

        /// <summary>
        /// Counts order sum and stores it into Order_SUm
        /// </summary>
        public void CountSum()
        {
            Order_Sum = 0;
            foreach (Batch b in Batches)
            {
                Order_Sum += b.Number * b.Medicine.Price;
            }
        }

        /// <summary>
        /// Creates and Adds Batch as part of Order
        /// </summary>
        /// <exception cref="System.Exception"> Batch was already used</exception>
        /// <param name="used_batches">List of alreadyu used batches</param>
        /// <param name="due_date">DateTime</param>
        /// <param name="number">count of prod in batch</param>
        /// <param name="medicine">Meds</param>
        /// <param name="wholesale_Purchase">wholesale_purchase</param>
        public void Create_Batch(List<Batch> used_batches, DateTime due_date, int number, Medicine medicine, Wholesale_Purchase wholesale_Purchase)
        {
            Batch new_Batch = Batch.CreateBatch(due_date, number, medicine, wholesale_Purchase, this);
            if (used_batches.Contains(new_Batch))
                throw new Exception("This Batch was already used");
            Add_Batch(new_Batch);
        }

        
        /// <summary>
        /// Adds batches to the list
        /// </summary>
        /// <param name="b">Batch</param>
        public void Add_Batch(Batch b)
        {
            if (!this.Batches.Contains(b))
                Batches.Add(b);
        }

        override
        public string ToString()
        {
            if (this.type == "Completed")
                return "Order: " + this.IdOrder + "Type: " + this.type + " Complete Time: " + this.Completed_Date;
            else
                return "Order: " + this.IdOrder + "Type: " + this.type + " Complete Time: " + this.Order_Date;
        }
    }
}
