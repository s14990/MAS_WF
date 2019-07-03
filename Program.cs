using MAS_PROJECT_WF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MAS_PROJECT_WF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //fill_db();

            //main_t();


        }

        public static void fill_db()
        {
            using (var db = new MyContext())
            {

                Branch b1 = new Branch("Apteka", "Ul AAAA");
                Branch b2 = new Branch("Punkt", "Al CCCC");
                Pharmacist p1 = new Pharmacist("Pharmac1", "aaa@email.com", DateTime.Now.AddYears(-5), 1000, 5);
                Pharmacist p2 = new Pharmacist("Pharmac2", "bbb@email.com", DateTime.Now.AddYears(-10), 2000, 3);
                Assistant a1 = new Assistant("Assistant1", "cc@email.com", DateTime.Now.AddYears(-5), 500);
                Assistant a2 = new Assistant("Assistant2", "dd@email.com", DateTime.Now.AddYears(-8), 800, 40);
                a1.setPharmacist(p1);
                a2.setPharmacist(p2);

                Practise pr1 = new Practise(b1, p1, DateTime.Now.AddYears(-3), DateTime.Now.AddYears(-2), "Good");
                Practise pr2 = new Practise(b1, p1, DateTime.Now.AddYears(-1), DateTime.Now.AddDays(-1), "Bad");
                Practise pr3 = new Practise(b1, p1, DateTime.Now);

                Practise pr4 = new Practise(b2, p1, DateTime.Now.AddYears(-4), DateTime.Now.AddYears(-3), "Horrible");
                Practise pr5 = new Practise(b2, p2, DateTime.Now.AddYears(-1), DateTime.Now.AddDays(-1), "Perfect");
                Practise pr6 = new Practise(b2, p2, DateTime.Now);

                db.Workers.Add(p1);
                db.Workers.Add(p2);
                db.Workers.Add(a1);
                db.Workers.Add(a2);
                db.Branches.Add(b1);
                db.Branches.Add(b2);
                db.Practises.Add(pr1);
                db.Practises.Add(pr2);
                db.Practises.Add(pr3);
                db.Practises.Add(pr4);
                db.Practises.Add(pr5);
                db.Practises.Add(pr6);
                db.SaveChanges();
            }
        }

        public static void main_t()
        {
            Console.WriteLine("Tests");
            using (var db = new MyContext())
            {
                //Kwal
                Pharmacist p1 = db.Workers.OfType<Pharmacist>().First();
                Console.WriteLine("Kwalifikowana ");
                Certificate c1 = new Certificate("Bezpiecienstwo", "BZP");
                p1.AddCertificate(c1);
                Console.WriteLine(p1.GetCertificate(c1.IdCertificate).ToString());
                Console.WriteLine("-------------");

                //Comp
                Branch b1 = db.Branches.First();
                Medicine m1 = new Medicine("Med1",15 ,10,true);
                Wholesaler ws1 = new Wholesaler("wh1@email.com", 10, 3);
                Wholesale_Purchase wp1 = new Wholesale_Purchase(DateTime.Now,50,ws1);
                Order o1 = new Order(DateTime.Now, b1);
                o1.Create_Batch(db.Batches.ToList(), DateTime.Now.AddYears(5),10, m1, wp1);
                Console.WriteLine(o1.Batches.First().ToString());

                //Dynamic
                Console.WriteLine(o1);
                o1.Complete_Order(DateTime.Now);
                Console.WriteLine(o1);


            }
        }
    }
}
