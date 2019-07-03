using System;
using System.ComponentModel.DataAnnotations;

namespace MAS_PROJECT_WF.Models
{
    public class Practise
    {
        [Key]
        public int IdPractise { get; set; }

        public Branch Branch { get; set; }

        public Worker Worker { get; set; }
        [Required]
        public DateTime Start_Date { get; set; }

        public DateTime? Finish_Date { get; set; }

        public bool Is_Current { get; set; }
        [MaxLength(40)]
        public string Notes { get; set; }

        public Practise() { }
        public Practise(Branch branch, Worker worker, DateTime start_Date)
        {
            Branch = branch;
            Branch.Add_Practise(this);
            Worker = worker;
            Worker.Add_Practise(this);
            Start_Date = start_Date;
            Is_Current = true;

        }

        public Practise(Branch branch, Worker worker, DateTime start_Date, DateTime finish_Date, string notes)
        {
            Branch = branch;
            Branch.Add_Practise(this);
            Worker = worker;
            Worker.Add_Practise(this);
            Start_Date = start_Date;
            Finish_Date = finish_Date;
            check_dates();
            Is_Current = false;
            Notes = notes;
        }

        /// <summary>
        /// Creates new Practise with date as now
        /// </summary>
        /// <returns> new Practice </returns>
        /// <param name="b">Branch</param>
        /// <param name="w">Worker</param>
        public static Practise Start_Practise(Branch b, Worker w)
        {
            return new Practise(b, w, DateTime.Now);
        }

        /// <summary>
        /// Finishes current practise
        /// </summary>
        /// <exception cref="System.Exception"> Practise was already finished</exception>
        /// <param name="note">String that represents notes about practise</param>
        public void Finish_Practise(string notes)
        {
            if (this.Is_Current == false)
                throw new Exception("Cant close what was already closed before");
            Finish_Date = DateTime.Now;
            check_dates();
            Is_Current = false;
            Notes = notes;
        }

        /// <summary>
        /// Finishes current practise
        /// </summary>
        /// <exception cref="System.Exception"> Practise was already finished</exception>
        public void check_dates()
        {
            if (this.Start_Date > this.Finish_Date)
                throw new Exception("Start Cant be later then finish");
        }
    }
}
