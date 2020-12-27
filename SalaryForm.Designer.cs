
namespace HR
{
    partial class SalaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryForm));
            this.dataGridViewSalary = new System.Windows.Forms.DataGridView();
            this.Imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataUrodzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelWorkers = new System.Windows.Forms.Panel();
            this.test1 = new System.Windows.Forms.TextBox();
            this.test = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalary)).BeginInit();
            this.panelWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSalary
            // 
            this.dataGridViewSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imie,
            this.Nazwisko,
            this.DataUrodzenia,
            this.PESEL,
            this.Genders});
            this.dataGridViewSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSalary.Location = new System.Drawing.Point(0, 58);
            this.dataGridViewSalary.Name = "dataGridViewSalary";
            this.dataGridViewSalary.Size = new System.Drawing.Size(1036, 556);
            this.dataGridViewSalary.TabIndex = 3;
            // 
            // Imie
            // 
            this.Imie.DataPropertyName = "Imie";
            this.Imie.HeaderText = "Imie";
            this.Imie.Name = "Imie";
            // 
            // Nazwisko
            // 
            this.Nazwisko.DataPropertyName = "Nazwisko";
            this.Nazwisko.HeaderText = "Nazwisko";
            this.Nazwisko.Name = "Nazwisko";
            // 
            // DataUrodzenia
            // 
            this.DataUrodzenia.DataPropertyName = "DataUrodzenia";
            this.DataUrodzenia.HeaderText = "DataUrodzenia";
            this.DataUrodzenia.Name = "DataUrodzenia";
            // 
            // PESEL
            // 
            this.PESEL.DataPropertyName = "PESEL";
            this.PESEL.HeaderText = "PESEL";
            this.PESEL.Name = "PESEL";
            // 
            // Genders
            // 
            this.Genders.DataPropertyName = "Genders";
            this.Genders.HeaderText = "Genders";
            this.Genders.Name = "Genders";
            // 
            // panelWorkers
            // 
            this.panelWorkers.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelWorkers.Controls.Add(this.test1);
            this.panelWorkers.Controls.Add(this.test);
            this.panelWorkers.Controls.Add(this.button1);
            this.panelWorkers.Controls.Add(this.btnDelete);
            this.panelWorkers.Controls.Add(this.btnEdit);
            this.panelWorkers.Controls.Add(this.btnAdd);
            this.panelWorkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWorkers.Location = new System.Drawing.Point(0, 0);
            this.panelWorkers.Name = "panelWorkers";
            this.panelWorkers.Size = new System.Drawing.Size(1036, 58);
            this.panelWorkers.TabIndex = 2;
            // 
            // test1
            // 
            this.test1.Location = new System.Drawing.Point(855, 12);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(100, 20);
            this.test1.TabIndex = 4;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(709, 13);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(100, 20);
            this.test.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Odśwież";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(341, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 35);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(181, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(21, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.gendersBindingSource;
            // 
            // gendersBindingSource
            // 
            this.gendersBindingSource.DataSource = typeof(HR.Genders);
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataMember = "Contract";
            this.contractBindingSource.DataSource = this.workerBindingSource;
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 614);
            this.Controls.Add(this.dataGridViewSalary);
            this.Controls.Add(this.panelWorkers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalaryForm";
            this.Text = "SalaryForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalary)).EndInit();
            this.panelWorkers.ResumeLayout(false);
            this.panelWorkers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataUrodzenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genders;
        private System.Windows.Forms.Panel panelWorkers;
        private System.Windows.Forms.TextBox test1;
        private System.Windows.Forms.TextBox test;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private System.Windows.Forms.BindingSource gendersBindingSource;
        private System.Windows.Forms.BindingSource contractBindingSource;
    }
}