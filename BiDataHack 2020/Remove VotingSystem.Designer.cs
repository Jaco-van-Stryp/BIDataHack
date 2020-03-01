namespace BiDataHack_2020
{
    partial class Remove_VotingSystem
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BackRemoveSystem = new System.Windows.Forms.Button();
            this.btn_RemoveSystem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remove System";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select system to remove";
            // 
            // btn_BackRemoveSystem
            // 
            this.btn_BackRemoveSystem.Location = new System.Drawing.Point(255, 351);
            this.btn_BackRemoveSystem.Name = "btn_BackRemoveSystem";
            this.btn_BackRemoveSystem.Size = new System.Drawing.Size(75, 23);
            this.btn_BackRemoveSystem.TabIndex = 3;
            this.btn_BackRemoveSystem.Text = "Back";
            this.btn_BackRemoveSystem.UseVisualStyleBackColor = true;
            this.btn_BackRemoveSystem.Click += new System.EventHandler(this.btn_BackRemoveSystem_Click);
            // 
            // btn_RemoveSystem
            // 
            this.btn_RemoveSystem.Location = new System.Drawing.Point(53, 351);
            this.btn_RemoveSystem.Name = "btn_RemoveSystem";
            this.btn_RemoveSystem.Size = new System.Drawing.Size(75, 23);
            this.btn_RemoveSystem.TabIndex = 4;
            this.btn_RemoveSystem.Text = "Remove";
            this.btn_RemoveSystem.UseVisualStyleBackColor = true;
            // 
            // Remove_VotingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.btn_RemoveSystem);
            this.Controls.Add(this.btn_BackRemoveSystem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Remove_VotingSystem";
            this.Text = "Remove_VotingSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BackRemoveSystem;
        private System.Windows.Forms.Button btn_RemoveSystem;
    }
}