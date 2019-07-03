using MAS_PROJECT_WF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAS_PROJECT_WF
{
    public partial class Form1 : Form
    {
        MyContext mainContext = new MyContext();
        List<Practise> current_Practises;
        Branch current_Branch;
        Worker current_Worker;
        Practise current_Practise = null;
        public Form1()
        {
            InitializeComponent();
            //Main Grid
            Default_Grid_Update();
            ResetBranchLabels();
            ResetWorkerLabels();

            //Branches ListBox
            List<Branch> branches_list = mainContext.Branches.Include(b=>b.Practises).ToList<Branch>();
            Branch all_branches_option = new Branch("Apteka", "All_Branches");
            all_branches_option.IdBranch = -1;
            branches_list.Insert(0, all_branches_option);
            BranchesComboBox.DataSource = branches_list;
            BranchesComboBox.DisplayMember = "Address";
            current_Branch = all_branches_option;

            //Worker ComboBox 
            List<Worker> workers_list = mainContext.Workers.Include(b => b.Practises).ToList<Worker>();
            Worker all_workers_option = new Pharmacist("All Workers", "", DateTime.Now, 0, 0);
            all_workers_option.IdWorker = -1;
            workers_list.Insert(0, all_workers_option);
            WorkerComboBox.DataSource = workers_list;
            WorkerComboBox.DisplayMember = "Name";
            current_Worker = all_workers_option;


            //Buttons
            Reset_Buttons();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Reset_Buttons()
        {
            StartButton.Visible = false;
            StartButton.Enabled = false;
            FinishButton.Visible = false;
            FinishButton.Enabled = false;
            NoteTextBox.Visible = false;
            NoteTextBox.Text = "";
            NoteError.Text = "Add some notes";
            NoteError.Visible = false;
            this.StartMessage.Visible = false;
            this.FinishMessage.Visible = false;
            MessageText.Text = "";
        }

        private void Enable_Start()
        {
            StartButton.Visible = true;
            StartButton.Enabled = true;
            FinishButton.Visible = false;
            FinishButton.Enabled = false;
            NoteTextBox.Visible = false;
            NoteTextBox.Text = "";
            NoteError.Text = "Add some notes";
            NoteError.Visible = false;
            this.StartMessage.Visible = true;
            this.FinishMessage.Visible = false;
            MessageText.Text = "";
        }

        private void Enable_Finish()
        {
            StartButton.Visible = false;
            StartButton.Enabled = false;
            FinishButton.Visible = true;
            FinishButton.Enabled = false;
            NoteTextBox.Visible = true;
            NoteTextBox.Text = "";
            NoteError.Text = "Add some notes";
            NoteError.Visible = true;
            this.StartMessage.Visible = false;
            this.FinishMessage.Visible = true;
            MessageText.Text = "";
        }


        private void ResetBranchLabels()
        {
            IdLabel.Visible = false;
            AddressLabel.Visible = false;
            KindLabel.Visible = false;
        }

        private void SetBranchLabels(Branch b)
        {
            IdLabel.Text = "id: " + b.IdBranch;
            AddressLabel.Text = "Address: " + b.Address;
            KindLabel.Text = "Kind: " + b.Kind;
            IdLabel.Visible = true;
            AddressLabel.Visible = true;
            KindLabel.Visible = true;

        }

        private void ResetWorkerLabels()
        {
            WorkerId.Visible = false;
            WorkerName.Visible = false;
            WorkerEmail.Visible = false;
        }

        private void SetWorkerLabels(Worker w)
        {
            WorkerId.Text = "Id: " + w.IdWorker;
            WorkerName.Text = "Name: " + w.Name;
            WorkerEmail.Text = "Email: " + w.Email;
            WorkerId.Visible = true;
            WorkerName.Visible = true;
            WorkerEmail.Visible = true;

        }

        private void BranchesComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            current_Branch = (Branch)BranchesComboBox.SelectedItem;
            Update_Grid();
        }

        private void WorkerComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            current_Worker = (Worker)WorkerComboBox.SelectedItem;
            Update_Grid();
        }

        private void Update_Grid()
        {
            if (current_Branch.IdBranch != -1 && current_Worker.IdWorker != -1)
                Filter_Grid_By_Branch_Worker(current_Branch, current_Worker);
            else if (current_Branch.IdBranch != -1)
                Filter_Grid_By_Branch(current_Branch);
            else if (current_Worker.IdWorker != -1)
                Filter_Grid_By_Worker(current_Worker);
            else
                Default_Grid_Update();
        }

        private void Default_Grid_Update()
        {
            current_Practises = mainContext.Practises.Include(practise => practise.Branch).Include(practise => practise.Worker).
                ToList<Practise>();
            MainGrid.DataSource = Build_Table(current_Practises);
            Reset_Buttons();
            ResetWorkerLabels();
            ResetBranchLabels();
        }

        private void Filter_Grid_By_Branch(Branch b)
        {
            current_Practises = b.Practises;
            MainGrid.DataSource = Build_Table(current_Practises);
            Reset_Buttons();
            ResetWorkerLabels();
            SetBranchLabels(b);
        }

        private void Filter_Grid_By_Worker(Worker w)
        {
            current_Practises = w.Practises;
            MainGrid.DataSource = Build_Table(current_Practises);
            Reset_Buttons();
            ResetBranchLabels();
            SetWorkerLabels(w);
        }

        private void Filter_Grid_By_Branch_Worker(Branch b, Worker w)
        {
            current_Practises = mainContext.Practises.Include(practise => practise.Branch).Include(practise => practise.Worker).
                Where(practise => practise.Worker == w).Where(practise => practise.Branch == b).ToList<Practise>();
            MainGrid.DataSource = Build_Table(current_Practises);

            current_Practise = current_Practises.Where(practise => practise.Is_Current == true).FirstOrDefault();
            if (current_Practise == null)
            {
                Enable_Start();
            }
            else
            {
                Enable_Finish();
            }
            SetWorkerLabels(w);
            SetBranchLabels(b);

        }

        private DataTable Build_Table(List<Practise> lista)
        {
            DataTable t = new DataTable();
            t.Columns.Add("Id");
            t.Columns.Add("Branch Address");
            t.Columns.Add("Worker");
            t.Columns.Add("Start Date");
            t.Columns.Add("Finish Date");
            t.Columns.Add("Notes");

            foreach (Practise p in lista)
            {
                DataRow r = t.NewRow();
                r["Id"] = p.IdPractise;
                r["Branch Address"] = p.Branch.Address;
                r["Worker"] = p.Worker.Name;
                r["Start Date"] = p.Start_Date;
                if (p.Is_Current == false)
                {
                    r["Finish Date"] = p.Finish_Date;
                    r["Notes"] = p.Notes;
                }
                else
                {
                    r["Finish Date"] = "In Progress";
                    r["Notes"] = "";
                }

                t.Rows.Add(r);
            }

            return t;
        }

        private void NoteTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NoteTextBox.TextLength < 4)
            {
                NoteError.Text = "Add some notes";
                FinishButton.Enabled = false;
                NoteError.Visible = true;
            }
            else if (NoteTextBox.TextLength > 40)
            {
                NoteError.Text = "Note is too Long";
                FinishButton.Enabled = false;
                NoteError.Visible = true;
            }
            else
            {
                FinishButton.Enabled = true;
                NoteError.Visible = false;
            }

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            mainContext.Practises.Add(Practise.Start_Practise(current_Branch, current_Worker));
            mainContext.SaveChanges();
            Update_Grid();
            MessageText.Text = "New Practice Saved";
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            current_Practise.Finish_Practise(NoteTextBox.Text);
            mainContext.SaveChanges();
            Update_Grid();
            MessageText.Text = "Current Practice Finished";
        }
    }
}
