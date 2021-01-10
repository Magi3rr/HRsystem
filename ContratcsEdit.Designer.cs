
namespace HR
{
    partial class ContratcsEdit
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
            this.cbBoxPositionType = new System.Windows.Forms.ComboBox();
            this.cbBoxContractType = new System.Windows.Forms.ComboBox();
            this.dateTimeRozp = new System.Windows.Forms.DateTimePicker();
            this.label1Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeKonc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUPWynagrodzenie = new System.Windows.Forms.NumericUpDown();
            this.cbBoxWorkerName = new System.Windows.Forms.ComboBox();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.workerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gendersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gendersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gendersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gendersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUPWynagrodzenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource4)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBoxPositionType
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbBoxPositionType, 2);
            this.cbBoxPositionType.FormattingEnabled = true;
            this.cbBoxPositionType.Location = new System.Drawing.Point(103, 93);
            this.cbBoxPositionType.Name = "cbBoxPositionType";
            this.cbBoxPositionType.Size = new System.Drawing.Size(204, 21);
            this.cbBoxPositionType.TabIndex = 35;
            // 
            // cbBoxContractType
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbBoxContractType, 2);
            this.cbBoxContractType.FormattingEnabled = true;
            this.cbBoxContractType.Location = new System.Drawing.Point(103, 3);
            this.cbBoxContractType.Name = "cbBoxContractType";
            this.cbBoxContractType.Size = new System.Drawing.Size(204, 21);
            this.cbBoxContractType.TabIndex = 34;
            // 
            // dateTimeRozp
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dateTimeRozp, 2);
            this.dateTimeRozp.Location = new System.Drawing.Point(103, 33);
            this.dateTimeRozp.Name = "dateTimeRozp";
            this.dateTimeRozp.Size = new System.Drawing.Size(204, 20);
            this.dateTimeRozp.TabIndex = 23;
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
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data rozpoczęcia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Wynagrodzenie";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(208, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddWorker.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddWorker.Location = new System.Drawing.Point(103, 195);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(99, 32);
            this.btnAddWorker.TabIndex = 12;
            this.btnAddWorker.Text = "Zatwierdz";
            this.btnAddWorker.UseVisualStyleBackColor = false;
            this.btnAddWorker.Click += new System.EventHandler(this.btnEditContract_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data zakończenia";
            // 
            // dateTimeKonc
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dateTimeKonc, 2);
            this.dateTimeKonc.Location = new System.Drawing.Point(103, 63);
            this.dateTimeKonc.Name = "dateTimeKonc";
            this.dateTimeKonc.Size = new System.Drawing.Size(204, 20);
            this.dateTimeKonc.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Stanowisko";
            // 
            // numericUPWynagrodzenie
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.numericUPWynagrodzenie, 2);
            this.numericUPWynagrodzenie.Location = new System.Drawing.Point(103, 123);
            this.numericUPWynagrodzenie.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUPWynagrodzenie.Name = "numericUPWynagrodzenie";
            this.numericUPWynagrodzenie.Size = new System.Drawing.Size(204, 20);
            this.numericUPWynagrodzenie.TabIndex = 28;
            // 
            // cbBoxWorkerName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbBoxWorkerName, 2);
            this.cbBoxWorkerName.FormattingEnabled = true;
            this.cbBoxWorkerName.Location = new System.Drawing.Point(103, 153);
            this.cbBoxWorkerName.Name = "cbBoxWorkerName";
            this.cbBoxWorkerName.Size = new System.Drawing.Size(204, 21);
            this.cbBoxWorkerName.TabIndex = 33;
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
            // workerBindingSource1
            // 
            this.workerBindingSource1.DataMember = "Worker";
            this.workerBindingSource1.DataSource = this.gendersBindingSource;
            // 
            // workerBindingSource2
            // 
            this.workerBindingSource2.DataMember = "Worker";
            this.workerBindingSource2.DataSource = this.gendersBindingSource;
            // 
            // gendersBindingSource1
            // 
            this.gendersBindingSource1.DataSource = typeof(HR.Genders);
            // 
            // gendersBindingSource3
            // 
            this.gendersBindingSource3.DataSource = typeof(HR.Genders);
            // 
            // gendersBindingSource2
            // 
            this.gendersBindingSource2.DataSource = typeof(HR.Genders);
            // 
            // gendersBindingSource4
            // 
            this.gendersBindingSource4.DataSource = typeof(HR.Genders);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(68, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 36);
            this.label6.TabIndex = 21;
            this.label6.Text = "Edycja umowy";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cbBoxPositionType, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbBoxContractType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimeRozp, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnAddWorker, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimeKonc, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUPWynagrodzenie, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbBoxWorkerName, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 230);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // ContratcsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 311);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ContratcsEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edytuj umowę";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ContratcsEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUPWynagrodzenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource4)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxPositionType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbBoxContractType;
        private System.Windows.Forms.DateTimePicker dateTimeRozp;
        private System.Windows.Forms.Label label1Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeKonc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUPWynagrodzenie;
        private System.Windows.Forms.ComboBox cbBoxWorkerName;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private System.Windows.Forms.BindingSource gendersBindingSource;
        private System.Windows.Forms.BindingSource workerBindingSource1;
        private System.Windows.Forms.BindingSource workerBindingSource2;
        private System.Windows.Forms.BindingSource gendersBindingSource1;
        private System.Windows.Forms.BindingSource gendersBindingSource3;
        private System.Windows.Forms.BindingSource gendersBindingSource2;
        private System.Windows.Forms.BindingSource gendersBindingSource4;
        private System.Windows.Forms.Label label6;
    }
}