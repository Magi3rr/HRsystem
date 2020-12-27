
namespace HR
{
    partial class ContractsAdd
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
            this.label1Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimeRozp = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUPWynagrodzenie = new System.Windows.Forms.NumericUpDown();
            this.checkBoxPrac = new System.Windows.Forms.CheckBox();
            this.checkBoxKier = new System.Windows.Forms.CheckBox();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.workerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gendersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gendersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gendersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.gendersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.radioButtonUOP = new System.Windows.Forms.CheckBox();
            this.radioButtonUZ = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUPWynagrodzenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1Name
            // 
            this.label1Name.AutoSize = true;
            this.label1Name.Location = new System.Drawing.Point(3, 0);
            this.label1Name.Name = "label1Name";
            this.label1Name.Size = new System.Drawing.Size(61, 13);
            this.label1Name.TabIndex = 8;
            this.label1Name.Text = "Typ umowy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data rozpoczęcia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data zakończenia";
            // 
            // dtBirth
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dtBirth, 2);
            this.dtBirth.Location = new System.Drawing.Point(91, 63);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(400, 20);
            this.dtBirth.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pracownik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(88, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 36);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dodawanie nowej umowy";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Wynagrodzenie";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtStatus
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtStatus, 2);
            this.txtStatus.Location = new System.Drawing.Point(91, 153);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(400, 20);
            this.txtStatus.TabIndex = 7;
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddWorker.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddWorker.Location = new System.Drawing.Point(195, 247);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(129, 32);
            this.btnAddWorker.TabIndex = 12;
            this.btnAddWorker.Text = "Dodaj";
            this.btnAddWorker.UseVisualStyleBackColor = false;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddContract_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.99229F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.00771F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimeRozp, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtStatus, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnAddWorker, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtBirth, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.numericUPWynagrodzenie, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxPrac, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxKier, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonUOP, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonUZ, 1, 0);
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
            this.tableLayoutPanel1.TabIndex = 14;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dateTimeRozp
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dateTimeRozp, 2);
            this.dateTimeRozp.Location = new System.Drawing.Point(91, 34);
            this.dateTimeRozp.Name = "dateTimeRozp";
            this.dateTimeRozp.Size = new System.Drawing.Size(400, 20);
            this.dateTimeRozp.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(407, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Stanowisko";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // numericUPWynagrodzenie
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.numericUPWynagrodzenie, 2);
            this.numericUPWynagrodzenie.Location = new System.Drawing.Point(91, 131);
            this.numericUPWynagrodzenie.Name = "numericUPWynagrodzenie";
            this.numericUPWynagrodzenie.Size = new System.Drawing.Size(400, 20);
            this.numericUPWynagrodzenie.TabIndex = 28;
            // 
            // checkBoxPrac
            // 
            this.checkBoxPrac.AutoSize = true;
            this.checkBoxPrac.Location = new System.Drawing.Point(330, 99);
            this.checkBoxPrac.Name = "checkBoxPrac";
            this.checkBoxPrac.Size = new System.Drawing.Size(76, 17);
            this.checkBoxPrac.TabIndex = 29;
            this.checkBoxPrac.Text = "Pracownik";
            this.checkBoxPrac.UseVisualStyleBackColor = true;
            // 
            // checkBoxKier
            // 
            this.checkBoxKier.AutoSize = true;
            this.checkBoxKier.Location = new System.Drawing.Point(91, 99);
            this.checkBoxKier.Name = "checkBoxKier";
            this.checkBoxKier.Size = new System.Drawing.Size(72, 17);
            this.checkBoxKier.TabIndex = 30;
            this.checkBoxKier.Text = "Kierownik";
            this.checkBoxKier.UseVisualStyleBackColor = true;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.gendersBindingSource;
            this.workerBindingSource.CurrentChanged += new System.EventHandler(this.workerBindingSource_CurrentChanged);
            // 
            // gendersBindingSource
            // 
            this.gendersBindingSource.DataSource = typeof(HR.Genders);
            this.gendersBindingSource.CurrentChanged += new System.EventHandler(this.gendersBindingSource_CurrentChanged);
            // 
            // workerBindingSource1
            // 
            this.workerBindingSource1.DataMember = "Worker";
            this.workerBindingSource1.DataSource = this.gendersBindingSource;
            this.workerBindingSource1.CurrentChanged += new System.EventHandler(this.workerBindingSource1_CurrentChanged);
            // 
            // workerBindingSource2
            // 
            this.workerBindingSource2.DataMember = "Worker";
            this.workerBindingSource2.DataSource = this.gendersBindingSource;
            // 
            // gendersBindingSource1
            // 
            this.gendersBindingSource1.DataSource = typeof(HR.Genders);
            this.gendersBindingSource1.CurrentChanged += new System.EventHandler(this.gendersBindingSource1_CurrentChanged);
            // 
            // gendersBindingSource3
            // 
            this.gendersBindingSource3.DataSource = typeof(HR.Genders);
            this.gendersBindingSource3.CurrentChanged += new System.EventHandler(this.gendersBindingSource3_CurrentChanged);
            // 
            // gendersBindingSource4
            // 
            this.gendersBindingSource4.DataSource = typeof(HR.Genders);
            this.gendersBindingSource4.CurrentChanged += new System.EventHandler(this.gendersBindingSource4_CurrentChanged);
            // 
            // gendersBindingSource2
            // 
            this.gendersBindingSource2.DataSource = typeof(HR.Genders);
            this.gendersBindingSource2.CurrentChanged += new System.EventHandler(this.gendersBindingSource2_CurrentChanged);
            // 
            // radioButtonUOP
            // 
            this.radioButtonUOP.AutoSize = true;
            this.radioButtonUOP.Location = new System.Drawing.Point(330, 3);
            this.radioButtonUOP.Name = "radioButtonUOP";
            this.radioButtonUOP.Size = new System.Drawing.Size(101, 17);
            this.radioButtonUOP.TabIndex = 31;
            this.radioButtonUOP.Text = "Umowa o pracę";
            this.radioButtonUOP.UseVisualStyleBackColor = true;
            // 
            // radioButtonUZ
            // 
            this.radioButtonUZ.AutoSize = true;
            this.radioButtonUZ.Location = new System.Drawing.Point(91, 3);
            this.radioButtonUZ.Name = "radioButtonUZ";
            this.radioButtonUZ.Size = new System.Drawing.Size(104, 17);
            this.radioButtonUZ.TabIndex = 32;
            this.radioButtonUZ.Text = "Umowa zlecenie";
            this.radioButtonUZ.UseVisualStyleBackColor = true;
            // 
            // ContractsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(543, 348);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContractsAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContractAdd";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUPWynagrodzenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource gendersBindingSource1;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private System.Windows.Forms.BindingSource gendersBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.BindingSource gendersBindingSource3;
        private System.Windows.Forms.BindingSource gendersBindingSource4;
        private System.Windows.Forms.BindingSource gendersBindingSource2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource workerBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimeRozp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource workerBindingSource2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUPWynagrodzenie;
        private System.Windows.Forms.CheckBox checkBoxPrac;
        private System.Windows.Forms.CheckBox checkBoxKier;
        private System.Windows.Forms.CheckBox radioButtonUOP;
        private System.Windows.Forms.CheckBox radioButtonUZ;
    }
}