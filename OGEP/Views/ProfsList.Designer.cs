namespace OGEP.Views
{
    partial class ProfsList
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
            this.SearchBox = new MetroFramework.Controls.MetroTextBox();
            this.studentsNbr = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.FinishBtn = new MetroFramework.Controls.MetroButton();
            this.PaimentsButton = new MetroFramework.Controls.MetroButton();
            this.DeleteBtn = new MetroFramework.Controls.MetroButton();
            this.editBtn = new MetroFramework.Controls.MetroButton();
            this.ModulesBtn = new MetroFramework.Controls.MetroButton();
            this.addBtn = new MetroFramework.Controls.MetroButton();
            this.profsDataGridView = new System.Windows.Forms.DataGridView();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodeDePayementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pourcentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixGNormalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixGVIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajoutéParDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profsinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oGEPdataSet = new OGEP.Data.OGEPdataSet();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.profs_infoTableAdapter = new OGEP.Data.OGEPdataSetTableAdapters.profs_infoTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profsinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGEPdataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(350, 34);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PromptText = "Recherche ..";
            this.SearchBox.Size = new System.Drawing.Size(229, 23);
            this.SearchBox.TabIndex = 9;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // studentsNbr
            // 
            this.studentsNbr.AutoSize = true;
            this.studentsNbr.Location = new System.Drawing.Point(23, 461);
            this.studentsNbr.Name = "studentsNbr";
            this.studentsNbr.Size = new System.Drawing.Size(161, 19);
            this.studentsNbr.TabIndex = 8;
            this.studentsNbr.Text = "Nombre d\'élèves : 0 élève";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.FinishBtn);
            this.metroPanel1.Controls.Add(this.PaimentsButton);
            this.metroPanel1.Controls.Add(this.DeleteBtn);
            this.metroPanel1.Controls.Add(this.editBtn);
            this.metroPanel1.Controls.Add(this.ModulesBtn);
            this.metroPanel1.Controls.Add(this.addBtn);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(585, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(92, 414);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(18, 359);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(71, 23);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Imprimer";
            // 
            // FinishBtn
            // 
            this.FinishBtn.Location = new System.Drawing.Point(18, 388);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(71, 23);
            this.FinishBtn.TabIndex = 6;
            this.FinishBtn.Text = "Terminer";
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // PaimentsButton
            // 
            this.PaimentsButton.Enabled = false;
            this.PaimentsButton.Location = new System.Drawing.Point(18, 171);
            this.PaimentsButton.Name = "PaimentsButton";
            this.PaimentsButton.Size = new System.Drawing.Size(71, 23);
            this.PaimentsButton.TabIndex = 5;
            this.PaimentsButton.Text = "Paiments";
            this.PaimentsButton.Click += new System.EventHandler(this.PaimentsButton_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.Location = new System.Drawing.Point(18, 87);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(71, 23);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Supprimer";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Enabled = false;
            this.editBtn.Location = new System.Drawing.Point(18, 45);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(71, 23);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Modifier";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // ModulesBtn
            // 
            this.ModulesBtn.Enabled = false;
            this.ModulesBtn.Location = new System.Drawing.Point(18, 129);
            this.ModulesBtn.Name = "ModulesBtn";
            this.ModulesBtn.Size = new System.Drawing.Size(71, 23);
            this.ModulesBtn.TabIndex = 4;
            this.ModulesBtn.Text = "Modules";
            this.ModulesBtn.Click += new System.EventHandler(this.ModulesBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(18, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(71, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Ajouter";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // profsDataGridView
            // 
            this.profsDataGridView.AllowUserToAddRows = false;
            this.profsDataGridView.AllowUserToDeleteRows = false;
            this.profsDataGridView.AllowUserToOrderColumns = true;
            this.profsDataGridView.AutoGenerateColumns = false;
            this.profsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.methodeDePayementDataGridViewTextBoxColumn,
            this.pourcentageDataGridViewTextBoxColumn,
            this.prixGNormalDataGridViewTextBoxColumn,
            this.prixGVIPDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.autresDataGridViewTextBoxColumn,
            this.dateInscriptionDataGridViewTextBoxColumn,
            this.ajoutéParDataGridViewTextBoxColumn});
            this.profsDataGridView.DataSource = this.profsinfoBindingSource1;
            this.profsDataGridView.Location = new System.Drawing.Point(23, 63);
            this.profsDataGridView.MultiSelect = false;
            this.profsDataGridView.Name = "profsDataGridView";
            this.profsDataGridView.ReadOnly = true;
            this.profsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.profsDataGridView.Size = new System.Drawing.Size(556, 391);
            this.profsDataGridView.TabIndex = 6;
            this.profsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.profsDataGridView_CellContentClick);
            this.profsDataGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.profsDataGridView_RowStateChanged);
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // methodeDePayementDataGridViewTextBoxColumn
            // 
            this.methodeDePayementDataGridViewTextBoxColumn.DataPropertyName = "Methode de payement";
            this.methodeDePayementDataGridViewTextBoxColumn.HeaderText = "Methode de payement";
            this.methodeDePayementDataGridViewTextBoxColumn.Name = "methodeDePayementDataGridViewTextBoxColumn";
            this.methodeDePayementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pourcentageDataGridViewTextBoxColumn
            // 
            this.pourcentageDataGridViewTextBoxColumn.DataPropertyName = "Pourcentage";
            this.pourcentageDataGridViewTextBoxColumn.HeaderText = "Pourcentage";
            this.pourcentageDataGridViewTextBoxColumn.Name = "pourcentageDataGridViewTextBoxColumn";
            this.pourcentageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixGNormalDataGridViewTextBoxColumn
            // 
            this.prixGNormalDataGridViewTextBoxColumn.DataPropertyName = "Prix G normal";
            this.prixGNormalDataGridViewTextBoxColumn.HeaderText = "Prix G normal";
            this.prixGNormalDataGridViewTextBoxColumn.Name = "prixGNormalDataGridViewTextBoxColumn";
            this.prixGNormalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixGVIPDataGridViewTextBoxColumn
            // 
            this.prixGVIPDataGridViewTextBoxColumn.DataPropertyName = "Prix G VIP";
            this.prixGVIPDataGridViewTextBoxColumn.HeaderText = "Prix G VIP";
            this.prixGVIPDataGridViewTextBoxColumn.Name = "prixGVIPDataGridViewTextBoxColumn";
            this.prixGVIPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autresDataGridViewTextBoxColumn
            // 
            this.autresDataGridViewTextBoxColumn.DataPropertyName = "Autres";
            this.autresDataGridViewTextBoxColumn.HeaderText = "Autres";
            this.autresDataGridViewTextBoxColumn.Name = "autresDataGridViewTextBoxColumn";
            this.autresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateInscriptionDataGridViewTextBoxColumn
            // 
            this.dateInscriptionDataGridViewTextBoxColumn.DataPropertyName = "Date inscription";
            this.dateInscriptionDataGridViewTextBoxColumn.HeaderText = "Date inscription";
            this.dateInscriptionDataGridViewTextBoxColumn.Name = "dateInscriptionDataGridViewTextBoxColumn";
            this.dateInscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ajoutéParDataGridViewTextBoxColumn
            // 
            this.ajoutéParDataGridViewTextBoxColumn.DataPropertyName = "Ajouté par";
            this.ajoutéParDataGridViewTextBoxColumn.HeaderText = "Ajouté par";
            this.ajoutéParDataGridViewTextBoxColumn.Name = "ajoutéParDataGridViewTextBoxColumn";
            this.ajoutéParDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profsinfoBindingSource1
            // 
            this.profsinfoBindingSource1.DataMember = "profs_info";
            this.profsinfoBindingSource1.DataSource = this.oGEPdataSet;
            // 
            // oGEPdataSet
            // 
            this.oGEPdataSet.DataSetName = "OGEPdataSet";
            this.oGEPdataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // profs_infoTableAdapter
            // 
            this.profs_infoTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Num";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "Prenom";
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            // 
            // ProfsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.studentsNbr);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.profsDataGridView);
            this.Name = "ProfsList";
            this.Text = "ProfsList";
            this.Load += new System.EventHandler(this.ProfsList_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profsinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGEPdataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox SearchBox;
        private MetroFramework.Controls.MetroLabel studentsNbr;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton FinishBtn;
        private MetroFramework.Controls.MetroButton PaimentsButton;
        private MetroFramework.Controls.MetroButton DeleteBtn;
        private MetroFramework.Controls.MetroButton editBtn;
        private MetroFramework.Controls.MetroButton ModulesBtn;
        private MetroFramework.Controls.MetroButton addBtn;
        public System.Windows.Forms.DataGridView profsDataGridView;
        private Data.OGEPdataSet oGEPdataSet;
        private System.Windows.Forms.Timer timer1;
        private Data.OGEPdataSetTableAdapters.profs_infoTableAdapter profs_infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodeDePayementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pourcentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixGNormalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixGVIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ajoutéParDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource profsinfoBindingSource1;
    }
}