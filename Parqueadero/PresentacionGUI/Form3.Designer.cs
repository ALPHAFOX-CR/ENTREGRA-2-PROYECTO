namespace PresentacionGUI
{
    partial class ReporteSistemas
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
            this.gbReportes = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbReportes = new System.Windows.Forms.Label();
            this.btAtras1 = new System.Windows.Forms.Button();
            this.gbReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbReportes
            // 
            this.gbReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbReportes.Controls.Add(this.dataGridView1);
            this.gbReportes.Location = new System.Drawing.Point(12, 54);
            this.gbReportes.Name = "gbReportes";
            this.gbReportes.Size = new System.Drawing.Size(822, 436);
            this.gbReportes.TabIndex = 0;
            this.gbReportes.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(784, 419);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbReportes
            // 
            this.lbReportes.AutoSize = true;
            this.lbReportes.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReportes.Location = new System.Drawing.Point(236, 19);
            this.lbReportes.Name = "lbReportes";
            this.lbReportes.Size = new System.Drawing.Size(366, 32);
            this.lbReportes.TabIndex = 1;
            this.lbReportes.Text = "REPORTES DEL SISTEMA";
            // 
            // btAtras1
            // 
            this.btAtras1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtras1.Location = new System.Drawing.Point(12, 496);
            this.btAtras1.Name = "btAtras1";
            this.btAtras1.Size = new System.Drawing.Size(75, 31);
            this.btAtras1.TabIndex = 2;
            this.btAtras1.Text = "Atras";
            this.btAtras1.UseVisualStyleBackColor = true;
            this.btAtras1.Click += new System.EventHandler(this.btAtras1_Click);
            // 
            // ReporteSistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(846, 535);
            this.Controls.Add(this.btAtras1);
            this.Controls.Add(this.lbReportes);
            this.Controls.Add(this.gbReportes);
            this.Name = "ReporteSistemas";
            this.Text = "REPORTES DEL SISTEMA";
            this.Load += new System.EventHandler(this.ReporteSistemas_Load);
            this.gbReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReportes;
        private System.Windows.Forms.Label lbReportes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btAtras1;
    }
}