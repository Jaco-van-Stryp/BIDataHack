namespace BiDataHack_2020
{
    partial class ListExistingVotingSystems
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
            this.btn_Proceed = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.mainList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of systems";
            // 
            // btn_Proceed
            // 
            this.btn_Proceed.Location = new System.Drawing.Point(182, 255);
            this.btn_Proceed.Name = "btn_Proceed";
            this.btn_Proceed.Size = new System.Drawing.Size(75, 23);
            this.btn_Proceed.TabIndex = 2;
            this.btn_Proceed.Text = "Proceed";
            this.btn_Proceed.UseVisualStyleBackColor = true;
            this.btn_Proceed.Click += new System.EventHandler(this.btn_Proceed_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(48, 255);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // mainList
            // 
            this.mainList.FormattingEnabled = true;
            this.mainList.Location = new System.Drawing.Point(48, 72);
            this.mainList.Name = "mainList";
            this.mainList.Size = new System.Drawing.Size(199, 160);
            this.mainList.TabIndex = 4;
            // 
            // ListExistingVotingSystems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 316);
            this.Controls.Add(this.mainList);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_Proceed);
            this.Controls.Add(this.label1);
            this.Name = "ListExistingVotingSystems";
            this.Text = "ListExistingVotingSystems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Proceed;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ListBox mainList;
    }
}