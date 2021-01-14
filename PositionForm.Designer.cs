
namespace HR
{
    partial class PositionForm
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
            this.dataGridViewPositions = new System.Windows.Forms.DataGridView();
            this.panelContracts = new System.Windows.Forms.Panel();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPositions)).BeginInit();
            this.panelContracts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPositions
            // 
            this.dataGridViewPositions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPositions.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewPositions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPositions.Location = new System.Drawing.Point(0, 60);
            this.dataGridViewPositions.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewPositions.Name = "dataGridViewPositions";
            this.dataGridViewPositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPositions.Size = new System.Drawing.Size(563, 246);
            this.dataGridViewPositions.TabIndex = 5;
            // 
            // panelContracts
            // 
            this.panelContracts.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelContracts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelContracts.Controls.Add(this.label1);
            this.panelContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContracts.Location = new System.Drawing.Point(0, 0);
            this.panelContracts.Margin = new System.Windows.Forms.Padding(0);
            this.panelContracts.Name = "panelContracts";
            this.panelContracts.Size = new System.Drawing.Size(563, 60);
            this.panelContracts.TabIndex = 4;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelContracts, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewPositions, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 306);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista stanowisk";
            // 
            // PositionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(563, 306);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PositionForm";
            this.Text = "PositionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPositions)).EndInit();
            this.panelContracts.ResumeLayout(false);
            this.panelContracts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPositions;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private System.Windows.Forms.BindingSource gendersBindingSource;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private System.Windows.Forms.Panel panelContracts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}