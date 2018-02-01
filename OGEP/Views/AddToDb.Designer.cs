namespace OGEP.Views
{
    partial class AddToDb
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
            this.textBox = new MetroFramework.Controls.MetroTextBox();
            this.Confirm = new MetroFramework.Controls.MetroButton();
            this.cancelBtn = new MetroFramework.Controls.MetroButton();
            this.TitleLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(23, 63);
            this.textBox.Name = "textBox";
            this.textBox.PromptText = "...";
            this.textBox.Size = new System.Drawing.Size(238, 23);
            this.textBox.TabIndex = 0;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(186, 92);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 1;
            this.Confirm.Text = "Confirmer";
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(105, 92);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Annuler";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TitleLabel.Location = new System.Drawing.Point(23, 30);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(193, 19);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Entrez le nom de la matiere";
            // 
            // AddToDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 133);
            this.ControlBox = false;
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.textBox);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddToDb";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AddToDb";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddToDb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textBox;
        private MetroFramework.Controls.MetroButton Confirm;
        private MetroFramework.Controls.MetroButton cancelBtn;
        private MetroFramework.Controls.MetroLabel TitleLabel;
    }
}