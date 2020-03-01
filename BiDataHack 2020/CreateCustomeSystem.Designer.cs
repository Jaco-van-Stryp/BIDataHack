namespace BiDataHack_2020
{
    partial class CreateCustomeSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_VotingSettings = new System.Windows.Forms.Button();
            this.btn_CreationBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Your Profile";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(360, 117);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(172, 20);
            this.fileName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Enter Your New Profile Name";
            // 
            // btn_VotingSettings
            // 
            this.btn_VotingSettings.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_VotingSettings.Location = new System.Drawing.Point(426, 180);
            this.btn_VotingSettings.Name = "btn_VotingSettings";
            this.btn_VotingSettings.Size = new System.Drawing.Size(82, 23);
            this.btn_VotingSettings.TabIndex = 3;
            this.btn_VotingSettings.Text = "Next";
            this.btn_VotingSettings.UseVisualStyleBackColor = false;
            this.btn_VotingSettings.Click += new System.EventHandler(this.btn_VotingSettings_Click);
            // 
            // btn_CreationBack
            // 
            this.btn_CreationBack.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_CreationBack.Location = new System.Drawing.Point(90, 180);
            this.btn_CreationBack.Name = "btn_CreationBack";
            this.btn_CreationBack.Size = new System.Drawing.Size(75, 23);
            this.btn_CreationBack.TabIndex = 6;
            this.btn_CreationBack.Text = "Back";
            this.btn_CreationBack.UseVisualStyleBackColor = false;
            this.btn_CreationBack.Click += new System.EventHandler(this.btn_CreationBack_Click);
            // 
            // CreateCustomeSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(566, 232);
            this.Controls.Add(this.btn_CreationBack);
            this.Controls.Add(this.btn_VotingSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label1);
            this.Name = "CreateCustomeSystem";
            this.Text = "CreateCustomeSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_VotingSettings;
        private System.Windows.Forms.Button btn_CreationBack;
    }
}