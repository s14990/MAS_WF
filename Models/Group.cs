using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_PROJECT_WF.Models
{
    public class Group
    {
        [Key]
        public int IdGroup {get;set;}
        [MaxLength(20)]
        public string Purpose { get; set; }

        public string Side_Effects { get; set; }

        public List<Medicine> Products = new List<Medicine>();

        public Group(int idGroup, string purpose, string side_Effects)
        {
            IdGroup = idGroup;
            Purpose = purpose;
            Side_Effects = side_Effects;
        }

        /// <summary>
        /// Adds string to the list of effects
        /// </summary>
        /// <param name="f">String that contains effect</param>
        public void AddEffect(string f)
        {
            this.Side_Effects += "," + f;
        }


        /// <summary>
        /// Splits string of side effects to list and returns it
        /// </summary>
        /// <returns>
        /// List of side effects
        /// </returns>
        public string[] GetSideEffects()
        {
            return this.Side_Effects.Split(',');
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
            return "Group: " + this.IdGroup + " " + this.Purpose;
        }
    }
}
