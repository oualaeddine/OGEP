using OGEP.Data;

namespace OGEP
{
    partial class StudentsList
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
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.FinishBtn = new MetroFramework.Controls.MetroButton();
            this.PaimentsButton = new MetroFramework.Controls.MetroButton();
            this.DeleteBtn = new MetroFramework.Controls.MetroButton();
            this.editBtn = new MetroFramework.Controls.MetroButton();
            this.ModulesBtn = new MetroFramework.Controls.MetroButton();
            this.addBtn = new MetroFramework.Controls.MetroButton();
            this.studentsNbr = new MetroFramework.Controls.MetroLabel();
            this.SearchBox = new MetroFramework.Controls.MetroTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niveauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajoutéParDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oGEPdataSet = new OGEP.Data.OGEPdataSet();
            this.students_infoTableAdapter = new OGEP.Data.OGEPdataSetTableAdapters.students_infoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGEPdataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AllowUserToAddRows = false;
            this.studentsDataGridView.AllowUserToDeleteRows = false;
            this.studentsDataGridView.AutoGenerateColumns = false;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.tel2DataGridViewTextBoxColumn,
            this.niveauDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.dateInscriptionDataGridViewTextBoxColumn,
            this.ajoutéParDataGridViewTextBoxColumn});
            this.studentsDataGridView.DataSource = this.studentsinfoBindingSource;
            this.studentsDataGridView.Location = new System.Drawing.Point(23, 63);
            this.studentsDataGridView.MultiSelect = false;
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.ReadOnly = true;
            this.studentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsDataGridView.Size = new System.Drawing.Size(556, 391);
            this.studentsDataGridView.TabIndex = 1;
            this.studentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsDataGridView_CellContentClick);
            this.studentsDataGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.studentsDataGridView_RowStateChanged);
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
            this.metroPanel1.TabIndex = 3;
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
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
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
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // studentsNbr
            // 
            this.studentsNbr.AutoSize = true;
            this.studentsNbr.Location = new System.Drawing.Point(23, 461);
            this.studentsNbr.Name = "studentsNbr";
            this.studentsNbr.Size = new System.Drawing.Size(161, 19);
            this.studentsNbr.TabIndex = 4;
            this.studentsNbr.Text = "Nombre d\'élèves : 0 élève";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(350, 34);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PromptText = "Recherche ..";
            this.SearchBox.Size = new System.Drawing.Size(229, 23);
            this.SearchBox.TabIndex = 5;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.ReadOnly = true;
            this.numDataGridViewTextBoxColumn.Width = 5;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 5;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenomDataGridViewTextBoxColumn.Width = 5;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            this.telDataGridViewTextBoxColumn.Width = 5;
            // 
            // tel2DataGridViewTextBoxColumn
            // 
            this.tel2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.tel2DataGridViewTextBoxColumn.DataPropertyName = "Tel2";
            this.tel2DataGridViewTextBoxColumn.HeaderText = "Tel2";
            this.tel2DataGridViewTextBoxColumn.Name = "tel2DataGridViewTextBoxColumn";
            this.tel2DataGridViewTextBoxColumn.ReadOnly = true;
            this.tel2DataGridViewTextBoxColumn.Width = 5;
            // 
            // niveauDataGridViewTextBoxColumn
            // 
            this.niveauDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.niveauDataGridViewTextBoxColumn.DataPropertyName = "Niveau";
            this.niveauDataGridViewTextBoxColumn.HeaderText = "Niveau";
            this.niveauDataGridViewTextBoxColumn.Name = "niveauDataGridViewTextBoxColumn";
            this.niveauDataGridViewTextBoxColumn.ReadOnly = true;
            this.niveauDataGridViewTextBoxColumn.Width = 5;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateInscriptionDataGridViewTextBoxColumn
            // 
            this.dateInscriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.dateInscriptionDataGridViewTextBoxColumn.DataPropertyName = "Date inscription";
            this.dateInscriptionDataGridViewTextBoxColumn.HeaderText = "Date inscription";
            this.dateInscriptionDataGridViewTextBoxColumn.Name = "dateInscriptionDataGridViewTextBoxColumn";
            this.dateInscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateInscriptionDataGridViewTextBoxColumn.Width = 5;
            // 
            // ajoutéParDataGridViewTextBoxColumn
            // 
            this.ajoutéParDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.ajoutéParDataGridViewTextBoxColumn.DataPropertyName = "Ajouté par";
            this.ajoutéParDataGridViewTextBoxColumn.HeaderText = "Ajouté par";
            this.ajoutéParDataGridViewTextBoxColumn.Name = "ajoutéParDataGridViewTextBoxColumn";
            this.ajoutéParDataGridViewTextBoxColumn.ReadOnly = true;
            this.ajoutéParDataGridViewTextBoxColumn.Width = 5;
            // 
            // studentsinfoBindingSource
            // 
            this.studentsinfoBindingSource.DataMember = "students_info";
            this.studentsinfoBindingSource.DataSource = this.oGEPdataSet;
            // 
            // oGEPdataSet
            // 
            this.oGEPdataSet.DataSetName = "OGEPdataSet";
            this.oGEPdataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // students_infoTableAdapter
            // 
            this.students_infoTableAdapter.ClearBeforeFill = true;
            // 
            // StudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.studentsNbr);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.studentsDataGridView);
            this.MaximizeBox = false;
            this.Name = "StudentsList";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Liste des etudiants";
            this.Load += new System.EventHandler(this.StudentsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGEPdataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton FinishBtn;
        private MetroFramework.Controls.MetroButton PaimentsButton;
        private MetroFramework.Controls.MetroButton DeleteBtn;
        private MetroFramework.Controls.MetroButton editBtn;
        private MetroFramework.Controls.MetroButton ModulesBtn;
        private MetroFramework.Controls.MetroButton addBtn;
        private MetroFramework.Controls.MetroLabel studentsNbr;
        public System.Windows.Forms.DataGridView studentsDataGridView;
        private MetroFramework.Controls.MetroTextBox SearchBox;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Timer timer1;
        private OGEPdataSet oGEPdataSet;
        private System.Windows.Forms.BindingSource studentsinfoBindingSource;
        private Data.OGEPdataSetTableAdapters.students_infoTableAdapter students_infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niveauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ajoutéParDataGridViewTextBoxColumn;
    }
}