namespace MAS_PROJECT_WF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BranchesComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkerComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FinishButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.NoteTextBox = new System.Windows.Forms.RichTextBox();
            this.NoteError = new System.Windows.Forms.Label();
            this.MessageText = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.KindLabel = new System.Windows.Forms.Label();
            this.WorkerId = new System.Windows.Forms.Label();
            this.WorkerName = new System.Windows.Forms.Label();
            this.WorkerEmail = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FinishMessage = new System.Windows.Forms.Label();
            this.StartMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apteka";
            // 
            // BranchesComboBox
            // 
            this.BranchesComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchesComboBox.FormattingEnabled = true;
            this.BranchesComboBox.Location = new System.Drawing.Point(12, 33);
            this.BranchesComboBox.Name = "BranchesComboBox";
            this.BranchesComboBox.Size = new System.Drawing.Size(129, 29);
            this.BranchesComboBox.TabIndex = 4;
            this.BranchesComboBox.SelectionChangeCommitted += new System.EventHandler(this.BranchesComboBox_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Branch";
            // 
            // WorkerComboBox
            // 
            this.WorkerComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerComboBox.FormattingEnabled = true;
            this.WorkerComboBox.Location = new System.Drawing.Point(623, 38);
            this.WorkerComboBox.Name = "WorkerComboBox";
            this.WorkerComboBox.Size = new System.Drawing.Size(121, 29);
            this.WorkerComboBox.TabIndex = 6;
            this.WorkerComboBox.SelectionChangeCommitted += new System.EventHandler(this.WorkerComboBox_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(626, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Worker";
            // 
            // FinishButton
            // 
            this.FinishButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.FinishButton.Location = new System.Drawing.Point(733, 417);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(99, 34);
            this.FinishButton.TabIndex = 8;
            this.FinishButton.Text = "Finish Current Practise";
            this.FinishButton.UseVisualStyleBackColor = false;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StartButton.Location = new System.Drawing.Point(733, 227);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(99, 34);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "Start New Practise";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainGrid
            // 
            this.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MainGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MainGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainGrid.Location = new System.Drawing.Point(-1, 227);
            this.MainGrid.MaximumSize = new System.Drawing.Size(550, 250);
            this.MainGrid.MinimumSize = new System.Drawing.Size(300, 100);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.ReadOnly = true;
            this.MainGrid.Size = new System.Drawing.Size(550, 250);
            this.MainGrid.TabIndex = 3;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(659, 286);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(173, 98);
            this.NoteTextBox.TabIndex = 10;
            this.NoteTextBox.Text = "";
            this.NoteTextBox.TextChanged += new System.EventHandler(this.NoteTextBox_TextChanged);
            // 
            // NoteError
            // 
            this.NoteError.AutoSize = true;
            this.NoteError.Location = new System.Drawing.Point(749, 387);
            this.NoteError.Name = "NoteError";
            this.NoteError.Size = new System.Drawing.Size(83, 26);
            this.NoteError.TabIndex = 11;
            this.NoteError.Text = "\r\nAdd some notes";
            // 
            // MessageText
            // 
            this.MessageText.AutoSize = true;
            this.MessageText.Location = new System.Drawing.Point(589, 445);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(0, 13);
            this.MessageText.TabIndex = 12;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(13, 75);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(73, 21);
            this.IdLabel.TabIndex = 13;
            this.IdLabel.Text = "BranchID";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(12, 96);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(118, 21);
            this.AddressLabel.TabIndex = 14;
            this.AddressLabel.Text = "Branch Address";
            // 
            // KindLabel
            // 
            this.KindLabel.AutoSize = true;
            this.KindLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KindLabel.Location = new System.Drawing.Point(13, 117);
            this.KindLabel.Name = "KindLabel";
            this.KindLabel.Size = new System.Drawing.Size(95, 21);
            this.KindLabel.TabIndex = 15;
            this.KindLabel.Text = "Branch Type";
            // 
            // WorkerId
            // 
            this.WorkerId.AutoSize = true;
            this.WorkerId.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerId.Location = new System.Drawing.Point(626, 75);
            this.WorkerId.Name = "WorkerId";
            this.WorkerId.Size = new System.Drawing.Size(75, 21);
            this.WorkerId.TabIndex = 16;
            this.WorkerId.Text = "WorkerId";
            // 
            // WorkerName
            // 
            this.WorkerName.AutoSize = true;
            this.WorkerName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerName.Location = new System.Drawing.Point(626, 96);
            this.WorkerName.Name = "WorkerName";
            this.WorkerName.Size = new System.Drawing.Size(104, 21);
            this.WorkerName.TabIndex = 17;
            this.WorkerName.Text = "WorkerName";
            // 
            // WorkerEmail
            // 
            this.WorkerEmail.AutoSize = true;
            this.WorkerEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerEmail.Location = new System.Drawing.Point(626, 117);
            this.WorkerEmail.Name = "WorkerEmail";
            this.WorkerEmail.Size = new System.Drawing.Size(100, 21);
            this.WorkerEmail.TabIndex = 18;
            this.WorkerEmail.Text = "WorkerEmail";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(MAS_PROJECT_WF.Form1);
            // 
            // FinishMessage
            // 
            this.FinishMessage.AutoSize = true;
            this.FinishMessage.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishMessage.Location = new System.Drawing.Point(656, 257);
            this.FinishMessage.Name = "FinishMessage";
            this.FinishMessage.Size = new System.Drawing.Size(174, 32);
            this.FinishMessage.TabIndex = 19;
            this.FinishMessage.Text = "There is practice in Progress\r\nYou can finish it now";
            // 
            // StartMessage
            // 
            this.StartMessage.AutoSize = true;
            this.StartMessage.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartMessage.Location = new System.Drawing.Point(555, 208);
            this.StartMessage.Name = "StartMessage";
            this.StartMessage.Size = new System.Drawing.Size(303, 16);
            this.StartMessage.TabIndex = 20;
            this.StartMessage.Text = "There is no practive in progress, you can start new";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(862, 496);
            this.Controls.Add(this.StartMessage);
            this.Controls.Add(this.FinishMessage);
            this.Controls.Add(this.WorkerEmail);
            this.Controls.Add(this.WorkerName);
            this.Controls.Add(this.WorkerId);
            this.Controls.Add(this.KindLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.NoteError);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WorkerComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BranchesComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.ComboBox BranchesComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox WorkerComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.RichTextBox NoteTextBox;
        private System.Windows.Forms.Label NoteError;
        private System.Windows.Forms.Label MessageText;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label KindLabel;
        private System.Windows.Forms.Label WorkerId;
        private System.Windows.Forms.Label WorkerName;
        private System.Windows.Forms.Label WorkerEmail;
        private System.Windows.Forms.Label FinishMessage;
        private System.Windows.Forms.Label StartMessage;
    }
}

