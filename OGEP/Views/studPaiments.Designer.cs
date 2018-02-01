namespace OGEP.Views
{
    partial class studPaiments
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
            this.studPaymentsGridView = new System.Windows.Forms.DataGridView();
            this.studPaymentTableAdapter1 = new OGEP.Data.OGEPdataSetTableAdapters.StudPaymentTableAdapter();
            this.ogePdataSet1 = new OGEP.Data.OGEPdataSet();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.closeBtn = new MetroFramework.Controls.MetroButton();
            this.NumLabel = new MetroFramework.Controls.MetroLabel();
            this.NomLabel = new MetroFramework.Controls.MetroLabel();
            this.PrenomLabel = new MetroFramework.Controls.MetroLabel();
            this.newPaymentBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.studPaymentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogePdataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // studPaymentsGridView
            // 
            this.studPaymentsGridView.AllowUserToAddRows = false;
            this.studPaymentsGridView.AllowUserToDeleteRows = false;
            this.studPaymentsGridView.AllowUserToResizeRows = false;
            this.studPaymentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studPaymentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studPaymentsGridView.Location = new System.Drawing.Point(23, 82);
            this.studPaymentsGridView.MultiSelect = false;
            this.studPaymentsGridView.Name = "studPaymentsGridView";
            this.studPaymentsGridView.ReadOnly = true;
            this.studPaymentsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studPaymentsGridView.Size = new System.Drawing.Size(654, 327);
            this.studPaymentsGridView.TabIndex = 0;
            // 
            // studPaymentTableAdapter1
            // 
            this.studPaymentTableAdapter1.ClearBeforeFill = true;
            // 
            // ogePdataSet1
            // 
            this.ogePdataSet1.DataSetName = "OGEPdataSet";
            this.ogePdataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(128, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Numero de l\'élève : ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(249, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Nom :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(463, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Prenom :";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(602, 415);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Fermer";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // NumLabel
            // 
            this.NumLabel.Location = new System.Drawing.Point(160, 60);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(83, 19);
            this.NumLabel.TabIndex = 5;
            this.NumLabel.Text = "123";
            this.NumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NomLabel
            // 
            this.NomLabel.Location = new System.Drawing.Point(301, 60);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(120, 19);
            this.NomLabel.TabIndex = 6;
            this.NomLabel.Text = "Berrehal";
            // 
            // PrenomLabel
            // 
            this.PrenomLabel.Location = new System.Drawing.Point(532, 60);
            this.PrenomLabel.Name = "PrenomLabel";
            this.PrenomLabel.Size = new System.Drawing.Size(145, 19);
            this.PrenomLabel.TabIndex = 7;
            this.PrenomLabel.Text = "Ouala eddine";
            // 
            // newPaymentBtn
            // 
            this.newPaymentBtn.Location = new System.Drawing.Point(490, 415);
            this.newPaymentBtn.Name = "newPaymentBtn";
            this.newPaymentBtn.Size = new System.Drawing.Size(106, 23);
            this.newPaymentBtn.TabIndex = 8;
            this.newPaymentBtn.Text = "Nouveau paiment";
            this.newPaymentBtn.Click += new System.EventHandler(this.newPaymentBtn_Click);
            // 
            // studPaiments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 449);
            this.Controls.Add(this.newPaymentBtn);
            this.Controls.Add(this.PrenomLabel);
            this.Controls.Add(this.NomLabel);
            this.Controls.Add(this.NumLabel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.studPaymentsGridView);
            this.MaximizeBox = false;
            this.Name = "studPaiments";
            this.Resizable = false;
            this.Text = "Historique des paiments";
            this.Load += new System.EventHandler(this.studPaiments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studPaymentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogePdataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studPaymentsGridView;
        private Data.OGEPdataSetTableAdapters.StudPaymentTableAdapter studPaymentTableAdapter1;
        private Data.OGEPdataSet ogePdataSet1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton closeBtn;
        private MetroFramework.Controls.MetroLabel NumLabel;
        private MetroFramework.Controls.MetroLabel NomLabel;
        private MetroFramework.Controls.MetroLabel PrenomLabel;
        private MetroFramework.Controls.MetroButton newPaymentBtn;
    }
}