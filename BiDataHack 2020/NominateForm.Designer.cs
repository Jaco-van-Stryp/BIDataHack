namespace BiDataHack_2020
{
    partial class NominateForm
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
            this.lblName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.txfID = new System.Windows.Forms.TextBox();
            this.txfEligible = new System.Windows.Forms.ComboBox();
            this.groupVal = new System.Windows.Forms.ComboBox();
            this.txfGender = new System.Windows.Forms.ComboBox();
            this.GEN = new System.Windows.Forms.Label();
            this.ELI = new System.Windows.Forms.Label();
            this.IDE = new System.Windows.Forms.Label();
            this.GV = new System.Windows.Forms.Label();
            this.surN = new System.Windows.Forms.Label();
            this.Nm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(125, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(453, 20);
            this.lblName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(201, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registration";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "Return To Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txbSurname
            // 
            this.txbSurname.Location = new System.Drawing.Point(125, 94);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(453, 20);
            this.txbSurname.TabIndex = 7;
            // 
            // txfID
            // 
            this.txfID.Location = new System.Drawing.Point(125, 170);
            this.txfID.Name = "txfID";
            this.txfID.Size = new System.Drawing.Size(453, 20);
            this.txfID.TabIndex = 11;
            // 
            // txfEligible
            // 
            this.txfEligible.FormattingEnabled = true;
            this.txfEligible.Items.AddRange(new object[] {
            "Vote",
            "Be A Nominee",
            "Both"});
            this.txfEligible.Location = new System.Drawing.Point(125, 210);
            this.txfEligible.Name = "txfEligible";
            this.txfEligible.Size = new System.Drawing.Size(453, 21);
            this.txfEligible.TabIndex = 17;
            // 
            // groupVal
            // 
            this.groupVal.FormattingEnabled = true;
            this.groupVal.Location = new System.Drawing.Point(125, 134);
            this.groupVal.Name = "groupVal";
            this.groupVal.Size = new System.Drawing.Size(453, 21);
            this.groupVal.TabIndex = 18;
            // 
            // txfGender
            // 
            this.txfGender.FormattingEnabled = true;
            this.txfGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Not Applicable"});
            this.txfGender.Location = new System.Drawing.Point(125, 251);
            this.txfGender.Name = "txfGender";
            this.txfGender.Size = new System.Drawing.Size(453, 21);
            this.txfGender.TabIndex = 20;
            // 
            // GEN
            // 
            this.GEN.AutoSize = true;
            this.GEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GEN.Location = new System.Drawing.Point(26, 258);
            this.GEN.Name = "GEN";
            this.GEN.Size = new System.Drawing.Size(42, 13);
            this.GEN.TabIndex = 41;
            this.GEN.Text = "Gender";
            // 
            // ELI
            // 
            this.ELI.AutoSize = true;
            this.ELI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ELI.Location = new System.Drawing.Point(26, 212);
            this.ELI.Name = "ELI";
            this.ELI.Size = new System.Drawing.Size(46, 13);
            this.ELI.TabIndex = 40;
            this.ELI.Text = "Eligibility";
            // 
            // IDE
            // 
            this.IDE.AutoSize = true;
            this.IDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDE.Location = new System.Drawing.Point(26, 177);
            this.IDE.Name = "IDE";
            this.IDE.Size = new System.Drawing.Size(67, 13);
            this.IDE.TabIndex = 39;
            this.IDE.Text = "Identification";
            // 
            // GV
            // 
            this.GV.AutoSize = true;
            this.GV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GV.Location = new System.Drawing.Point(26, 141);
            this.GV.Name = "GV";
            this.GV.Size = new System.Drawing.Size(65, 13);
            this.GV.TabIndex = 38;
            this.GV.Text = "Group value";
            // 
            // surN
            // 
            this.surN.AutoSize = true;
            this.surN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surN.Location = new System.Drawing.Point(26, 101);
            this.surN.Name = "surN";
            this.surN.Size = new System.Drawing.Size(49, 13);
            this.surN.TabIndex = 37;
            this.surN.Text = "Surname";
            // 
            // Nm
            // 
            this.Nm.AutoSize = true;
            this.Nm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nm.Location = new System.Drawing.Point(26, 61);
            this.Nm.Name = "Nm";
            this.Nm.Size = new System.Drawing.Size(35, 13);
            this.Nm.TabIndex = 36;
            this.Nm.Text = "Name";
            // 
            // NominateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 372);
            this.Controls.Add(this.GEN);
            this.Controls.Add(this.ELI);
            this.Controls.Add(this.IDE);
            this.Controls.Add(this.GV);
            this.Controls.Add(this.surN);
            this.Controls.Add(this.Nm);
            this.Controls.Add(this.txfGender);
            this.Controls.Add(this.groupVal);
            this.Controls.Add(this.txfEligible);
            this.Controls.Add(this.txfID);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Name = "NominateForm";
            this.Text = "NominateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.TextBox txfID;
        private System.Windows.Forms.ComboBox txfEligible;
        private System.Windows.Forms.ComboBox groupVal;
        private System.Windows.Forms.ComboBox txfGender;
        private System.Windows.Forms.Label GEN;
        private System.Windows.Forms.Label ELI;
        private System.Windows.Forms.Label IDE;
        private System.Windows.Forms.Label GV;
        private System.Windows.Forms.Label surN;
        private System.Windows.Forms.Label Nm;
    }
}