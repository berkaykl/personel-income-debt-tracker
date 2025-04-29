namespace PresentationLayer
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpDebts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDebtAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddWage = new System.Windows.Forms.Button();
            this.flpWages = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = "";
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flpDebts);
            this.panel1.Controls.Add(this.btnDebtAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 515);
            this.panel1.TabIndex = 0;
            // 
            // flpDebts
            // 
            this.flpDebts.AutoScroll = true;
            this.flpDebts.Location = new System.Drawing.Point(0, 62);
            this.flpDebts.Name = "flpDebts";
            this.flpDebts.Size = new System.Drawing.Size(525, 452);
            this.flpDebts.TabIndex = 1;
            // 
            // btnDebtAdd
            // 
            this.btnDebtAdd.BackColor = System.Drawing.Color.Green;
            this.btnDebtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDebtAdd.Location = new System.Drawing.Point(495, -1);
            this.btnDebtAdd.Name = "btnDebtAdd";
            this.btnDebtAdd.Size = new System.Drawing.Size(30, 31);
            this.btnDebtAdd.TabIndex = 2;
            this.btnDebtAdd.Text = "+";
            this.btnDebtAdd.UseVisualStyleBackColor = false;
            this.btnDebtAdd.Click += new System.EventHandler(this.btnDebtAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borçlar";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAddWage);
            this.panel2.Controls.Add(this.flpWages);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(554, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 515);
            this.panel2.TabIndex = 1;
            // 
            // btnAddWage
            // 
            this.btnAddWage.BackColor = System.Drawing.Color.Green;
            this.btnAddWage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddWage.Location = new System.Drawing.Point(494, -1);
            this.btnAddWage.Name = "btnAddWage";
            this.btnAddWage.Size = new System.Drawing.Size(30, 31);
            this.btnAddWage.TabIndex = 4;
            this.btnAddWage.Text = "+";
            this.btnAddWage.UseVisualStyleBackColor = false;
            this.btnAddWage.Click += new System.EventHandler(this.btnAddWage_Click);
            // 
            // flpWages
            // 
            this.flpWages.AutoScroll = true;
            this.flpWages.Location = new System.Drawing.Point(-1, 62);
            this.flpWages.Name = "flpWages";
            this.flpWages.Size = new System.Drawing.Size(525, 452);
            this.flpWages.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gelirler";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Kitap";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDebtAdd;
        private System.Windows.Forms.Button btnAddWage;
        private System.Windows.Forms.FlowLayoutPanel flpWages;
        private System.Windows.Forms.FlowLayoutPanel flpDebts;
    }
}

