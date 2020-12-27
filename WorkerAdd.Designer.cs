
namespace HR
{
    partial class WorkerAdd
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPESEL = new System.Windows.Forms.TextBox();
            this.rbButtonMale = new System.Windows.Forms.RadioButton();
            this.rbButtonFemale = new System.Windows.Forms.RadioButton();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gendersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gendersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.gendersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gendersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtName, 2);
            this.txtName.Location = new System.Drawing.Point(93, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(400, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtLastName, 2);
            this.txtLastName.Location = new System.Drawing.Point(93, 34);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(400, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // txtStatus
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtStatus, 2);
            this.txtStatus.Location = new System.Drawing.Point(93, 153);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(400, 20);
            this.txtStatus.TabIndex = 7;
            // 
            // label1Name
            // 
            this.label1Name.AutoSize = true;
            this.label1Name.Location = new System.Drawing.Point(3, 0);
            this.label1Name.Name = "label1Name";
            this.label1Name.Size = new System.Drawing.Size(26, 13);
            this.label1Name.TabIndex = 8;
            this.label1Name.Text = "Imie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Płeć";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.99229F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.00771F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel1.Controls.Add(this.label1Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtBirth, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtStatus, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtPESEL, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.rbButtonMale, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rbButtonFemale, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddWorker, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 282);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data urodzenia";
            // 
            // dtBirth
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dtBirth, 2);
            this.dtBirth.Location = new System.Drawing.Point(93, 99);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(400, 20);
            this.dtBirth.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "PESEL";
            // 
            // txtPESEL
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtPESEL, 2);
            this.txtPESEL.Location = new System.Drawing.Point(93, 131);
            this.txtPESEL.Name = "txtPESEL";
            this.txtPESEL.Size = new System.Drawing.Size(400, 20);
            this.txtPESEL.TabIndex = 17;
            // 
            // rbButtonMale
            // 
            this.rbButtonMale.AutoSize = true;
            this.rbButtonMale.Location = new System.Drawing.Point(93, 63);
            this.rbButtonMale.Name = "rbButtonMale";
            this.rbButtonMale.Size = new System.Drawing.Size(78, 17);
            this.rbButtonMale.TabIndex = 18;
            this.rbButtonMale.TabStop = true;
            this.rbButtonMale.Text = "Mężczyzna";
            this.rbButtonMale.UseVisualStyleBackColor = true;
            // 
            // rbButtonFemale
            // 
            this.rbButtonFemale.AutoSize = true;
            this.rbButtonFemale.Location = new System.Drawing.Point(336, 63);
            this.rbButtonFemale.Name = "rbButtonFemale";
            this.rbButtonFemale.Size = new System.Drawing.Size(61, 17);
            this.rbButtonFemale.TabIndex = 19;
            this.rbButtonFemale.TabStop = true;
            this.rbButtonFemale.Text = "Kobieta";
            this.rbButtonFemale.UseVisualStyleBackColor = true;
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddWorker.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddWorker.Location = new System.Drawing.Point(201, 247);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(129, 32);
            this.btnAddWorker.TabIndex = 12;
            this.btnAddWorker.Text = "Dodaj";
            this.btnAddWorker.UseVisualStyleBackColor = false;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(407, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 32);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(63, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(454, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dodawanie nowego pracownika";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // gendersBindingSource
            // 
            this.gendersBindingSource.DataSource = typeof(HR.Genders);
            // 
            // gendersBindingSource2
            // 
            this.gendersBindingSource2.DataSource = typeof(HR.Genders);
            // 
            // gendersBindingSource4
            // 
            this.gendersBindingSource4.DataSource = typeof(HR.Genders);
            // 
            // gendersBindingSource3
            // 
            this.gendersBindingSource3.DataSource = typeof(HR.Genders);
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.gendersBindingSource;
            // 
            // workerBindingSource1
            // 
            this.workerBindingSource1.DataMember = "Worker";
            this.workerBindingSource1.DataSource = this.gendersBindingSource;
            // 
            // gendersBindingSource1
            // 
            this.gendersBindingSource1.DataSource = typeof(HR.Genders);
            // 
            // WorkerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(543, 348);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkerAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddWorker";
            this.Load += new System.EventHandler(this.WorkerAdd_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource gendersBindingSource;
        private System.Windows.Forms.TextBox txtPESEL;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private System.Windows.Forms.BindingSource workerBindingSource1;
        private System.Windows.Forms.BindingSource gendersBindingSource2;
        private System.Windows.Forms.BindingSource gendersBindingSource1;
        private System.Windows.Forms.BindingSource gendersBindingSource4;
        private System.Windows.Forms.BindingSource gendersBindingSource3;
        private System.Windows.Forms.RadioButton rbButtonMale;
        private System.Windows.Forms.RadioButton rbButtonFemale;
        private System.Windows.Forms.Button btnCancel;
    }
}