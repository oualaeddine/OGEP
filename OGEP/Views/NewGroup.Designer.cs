namespace OGEP.Views
{
    partial class NewGroup
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.niveauCb = new MetroFramework.Controls.MetroComboBox();
            this.matiereCb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.profCb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.groupNameTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cancelBtn = new MetroFramework.Controls.MetroButton();
            this.finishBtn = new MetroFramework.Controls.MetroButton();
            this.oGEPdataSet = new OGEP.Data.OGEPdataSet();
            this.niveauxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.niveauxTableAdapter = new OGEP.Data.OGEPdataSetTableAdapters.NiveauxTableAdapter();
            this.matieresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matieresTableAdapter = new OGEP.Data.OGEPdataSetTableAdapters.MatieresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.oGEPdataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveauxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matieresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 134);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Enseignant:";
            // 
            // niveauCb
            // 
            this.niveauCb.DataSource = this.niveauxBindingSource;
            this.niveauCb.DisplayMember = "Description";
            this.niveauCb.FontSize = MetroFramework.MetroLinkSize.Small;
            this.niveauCb.FormattingEnabled = true;
            this.niveauCb.ItemHeight = 19;
            this.niveauCb.Location = new System.Drawing.Point(104, 70);
            this.niveauCb.Name = "niveauCb";
            this.niveauCb.Size = new System.Drawing.Size(121, 25);
            this.niveauCb.TabIndex = 1;
            this.niveauCb.ValueMember = "Id";
            // 
            // matiereCb
            // 
            this.matiereCb.DataSource = this.matieresBindingSource;
            this.matiereCb.DisplayMember = "Description";
            this.matiereCb.FontSize = MetroFramework.MetroLinkSize.Small;
            this.matiereCb.FormattingEnabled = true;
            this.matiereCb.ItemHeight = 19;
            this.matiereCb.Location = new System.Drawing.Point(104, 101);
            this.matiereCb.Name = "matiereCb";
            this.matiereCb.Size = new System.Drawing.Size(143, 25);
            this.matiereCb.TabIndex = 3;
            this.matiereCb.ValueMember = "Id";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Niveau:";
            // 
            // profCb
            // 
            this.profCb.FontSize = MetroFramework.MetroLinkSize.Small;
            this.profCb.FormattingEnabled = true;
            this.profCb.ItemHeight = 19;
            this.profCb.Location = new System.Drawing.Point(104, 132);
            this.profCb.Name = "profCb";
            this.profCb.Size = new System.Drawing.Size(158, 25);
            this.profCb.TabIndex = 5;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 105);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Matiere:";
            // 
            // groupNameTB
            // 
            this.groupNameTB.Location = new System.Drawing.Point(134, 167);
            this.groupNameTB.Name = "groupNameTB";
            this.groupNameTB.Size = new System.Drawing.Size(128, 23);
            this.groupNameTB.TabIndex = 6;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 167);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(105, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "nom du groupe:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(104, 226);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Annuler";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // finishBtn
            // 
            this.finishBtn.Location = new System.Drawing.Point(189, 226);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(75, 23);
            this.finishBtn.TabIndex = 9;
            this.finishBtn.Text = "Terminer";
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // oGEPdataSet
            // 
            this.oGEPdataSet.DataSetName = "OGEPdataSet";
            this.oGEPdataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // niveauxBindingSource
            // 
            this.niveauxBindingSource.DataMember = "Niveaux";
            this.niveauxBindingSource.DataSource = this.oGEPdataSet;
            // 
            // niveauxTableAdapter
            // 
            this.niveauxTableAdapter.ClearBeforeFill = true;
            // 
            // matieresBindingSource
            // 
            this.matieresBindingSource.DataMember = "Matieres";
            this.matieresBindingSource.DataSource = this.oGEPdataSet;
            // 
            // matieresTableAdapter
            // 
            this.matieresTableAdapter.ClearBeforeFill = true;
            // 
            // NewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 271);
            this.ControlBox = false;
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.groupNameTB);
            this.Controls.Add(this.profCb);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.matiereCb);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.niveauCb);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewGroup";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ajouter un groupe";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NewGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oGEPdataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveauxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matieresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox niveauCb;
        private MetroFramework.Controls.MetroComboBox matiereCb;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox profCb;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox groupNameTB;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton finishBtn;
        private MetroFramework.Controls.MetroButton cancelBtn;
        private Data.OGEPdataSet oGEPdataSet;
        private System.Windows.Forms.BindingSource niveauxBindingSource;
        private Data.OGEPdataSetTableAdapters.NiveauxTableAdapter niveauxTableAdapter;
        private System.Windows.Forms.BindingSource matieresBindingSource;
        private Data.OGEPdataSetTableAdapters.MatieresTableAdapter matieresTableAdapter;
    }
}