namespace OGEP.Views
{
    partial class Groupes
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
            this.groupesDatagrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matiereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomprofDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomprofDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oGEPdataSet = new OGEP.Data.OGEPdataSet();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.niveauxCb = new MetroFramework.Controls.MetroComboBox();
            this.niveauxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matieresCB = new MetroFramework.Controls.MetroComboBox();
            this.matieresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profCb = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.deleteGroupBtn = new MetroFramework.Controls.MetroButton();
            this.editGroupBtn = new MetroFramework.Controls.MetroButton();
            this.addGroupBtn = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.deleteStudFromGroupBtn = new MetroFramework.Controls.MetroButton();
            this.editStudGroupBtn = new MetroFramework.Controls.MetroButton();
            this.addStudToGroupBtn = new MetroFramework.Controls.MetroButton();
            this.elevesDataGrid = new System.Windows.Forms.DataGridView();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.studSearchBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.planningList = new System.Windows.Forms.ListView();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.finishBtn = new MetroFramework.Controls.MetroButton();
            this.niveauxTableAdapter = new OGEP.Data.OGEPdataSetTableAdapters.NiveauxTableAdapter();
            this.matieresTableAdapter = new OGEP.Data.OGEPdataSetTableAdapters.MatieresTableAdapter();
            this.groups_infoTableAdapter = new OGEP.Data.OGEPdataSetTableAdapters.Groups_infoTableAdapter();
            this.studentsgroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_groupsTableAdapter = new OGEP.Data.OGEPdataSetTableAdapters.Students_groupsTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAffectationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.affectéParDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupesDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGEPdataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveauxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matieresBindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elevesDataGrid)).BeginInit();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsgroupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupesDatagrid
            // 
            this.groupesDatagrid.AllowUserToAddRows = false;
            this.groupesDatagrid.AllowUserToDeleteRows = false;
            this.groupesDatagrid.AllowUserToResizeRows = false;
            this.groupesDatagrid.AutoGenerateColumns = false;
            this.groupesDatagrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.groupesDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupesDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.matiereDataGridViewTextBoxColumn,
            this.nomprofDataGridViewTextBoxColumn,
            this.prenomprofDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn});
            this.groupesDatagrid.DataSource = this.groupsinfoBindingSource;
            this.groupesDatagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.groupesDatagrid.Location = new System.Drawing.Point(3, 137);
            this.groupesDatagrid.MultiSelect = false;
            this.groupesDatagrid.Name = "groupesDatagrid";
            this.groupesDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupesDatagrid.Size = new System.Drawing.Size(287, 181);
            this.groupesDatagrid.TabIndex = 0;
            this.groupesDatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupesDatagrid_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 5;
            // 
            // matiereDataGridViewTextBoxColumn
            // 
            this.matiereDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.matiereDataGridViewTextBoxColumn.DataPropertyName = "matiere";
            this.matiereDataGridViewTextBoxColumn.HeaderText = "matiere";
            this.matiereDataGridViewTextBoxColumn.Name = "matiereDataGridViewTextBoxColumn";
            // 
            // nomprofDataGridViewTextBoxColumn
            // 
            this.nomprofDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomprofDataGridViewTextBoxColumn.DataPropertyName = "Nom_prof";
            this.nomprofDataGridViewTextBoxColumn.HeaderText = "Nom_prof";
            this.nomprofDataGridViewTextBoxColumn.Name = "nomprofDataGridViewTextBoxColumn";
            // 
            // prenomprofDataGridViewTextBoxColumn
            // 
            this.prenomprofDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prenomprofDataGridViewTextBoxColumn.DataPropertyName = "prenom_prof";
            this.prenomprofDataGridViewTextBoxColumn.HeaderText = "prenom_prof";
            this.prenomprofDataGridViewTextBoxColumn.Name = "prenomprofDataGridViewTextBoxColumn";
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "group";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.Width = 5;
            // 
            // groupsinfoBindingSource
            // 
            this.groupsinfoBindingSource.DataMember = "Groups_info";
            this.groupsinfoBindingSource.DataSource = this.oGEPdataSet;
            // 
            // oGEPdataSet
            // 
            this.oGEPdataSet.DataSetName = "OGEPdataSet";
            this.oGEPdataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(143, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Liste des groupes";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(3, 25);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 15);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Filtrer par:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(7, 48);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 15);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Niveau:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.Location = new System.Drawing.Point(3, 79);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 15);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Matiere:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.Location = new System.Drawing.Point(3, 109);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 15);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "enseignant:";
            // 
            // niveauxCb
            // 
            this.niveauxCb.DataSource = this.niveauxBindingSource;
            this.niveauxCb.DisplayMember = "Description";
            this.niveauxCb.FontSize = MetroFramework.MetroLinkSize.Small;
            this.niveauxCb.FormattingEnabled = true;
            this.niveauxCb.ItemHeight = 19;
            this.niveauxCb.Location = new System.Drawing.Point(73, 43);
            this.niveauxCb.Name = "niveauxCb";
            this.niveauxCb.Size = new System.Drawing.Size(200, 25);
            this.niveauxCb.TabIndex = 6;
            this.niveauxCb.ValueMember = "Id";
            this.niveauxCb.SelectedIndexChanged += new System.EventHandler(this.niveauxCb_SelectedIndexChanged);
            // 
            // niveauxBindingSource
            // 
            this.niveauxBindingSource.DataMember = "Niveaux";
            this.niveauxBindingSource.DataSource = this.oGEPdataSet;
            // 
            // matieresCB
            // 
            this.matieresCB.DataSource = this.matieresBindingSource;
            this.matieresCB.DisplayMember = "Description";
            this.matieresCB.FontSize = MetroFramework.MetroLinkSize.Small;
            this.matieresCB.FormattingEnabled = true;
            this.matieresCB.ItemHeight = 19;
            this.matieresCB.Location = new System.Drawing.Point(73, 74);
            this.matieresCB.Name = "matieresCB";
            this.matieresCB.Size = new System.Drawing.Size(200, 25);
            this.matieresCB.TabIndex = 7;
            this.matieresCB.ValueMember = "Id";
            this.matieresCB.SelectedIndexChanged += new System.EventHandler(this.matieresCB_SelectedIndexChanged);
            // 
            // matieresBindingSource
            // 
            this.matieresBindingSource.DataMember = "Matieres";
            this.matieresBindingSource.DataSource = this.oGEPdataSet;
            // 
            // profCb
            // 
            this.profCb.FontSize = MetroFramework.MetroLinkSize.Small;
            this.profCb.FormattingEnabled = true;
            this.profCb.ItemHeight = 19;
            this.profCb.Location = new System.Drawing.Point(73, 105);
            this.profCb.Name = "profCb";
            this.profCb.Size = new System.Drawing.Size(200, 25);
            this.profCb.TabIndex = 8;
            this.profCb.SelectedIndexChanged += new System.EventHandler(this.profCb_SelectedIndexChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.deleteGroupBtn);
            this.metroPanel1.Controls.Add(this.editGroupBtn);
            this.metroPanel1.Controls.Add(this.addGroupBtn);
            this.metroPanel1.Controls.Add(this.profCb);
            this.metroPanel1.Controls.Add(this.matieresCB);
            this.metroPanel1.Controls.Add(this.groupesDatagrid);
            this.metroPanel1.Controls.Add(this.niveauxCb);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(293, 350);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // deleteGroupBtn
            // 
            this.deleteGroupBtn.Location = new System.Drawing.Point(134, 324);
            this.deleteGroupBtn.Name = "deleteGroupBtn";
            this.deleteGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteGroupBtn.TabIndex = 11;
            this.deleteGroupBtn.Text = "Supprimer";
            this.deleteGroupBtn.Click += new System.EventHandler(this.deleteGroupBtn_Click);
            // 
            // editGroupBtn
            // 
            this.editGroupBtn.Location = new System.Drawing.Point(53, 324);
            this.editGroupBtn.Name = "editGroupBtn";
            this.editGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.editGroupBtn.TabIndex = 10;
            this.editGroupBtn.Text = "Modifier";
            this.editGroupBtn.Click += new System.EventHandler(this.editGroupBtn_Click);
            // 
            // addGroupBtn
            // 
            this.addGroupBtn.Location = new System.Drawing.Point(215, 324);
            this.addGroupBtn.Name = "addGroupBtn";
            this.addGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.addGroupBtn.TabIndex = 9;
            this.addGroupBtn.Text = "Ajouter";
            this.addGroupBtn.Click += new System.EventHandler(this.addGroupBtn_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.deleteStudFromGroupBtn);
            this.metroPanel2.Controls.Add(this.editStudGroupBtn);
            this.metroPanel2.Controls.Add(this.addStudToGroupBtn);
            this.metroPanel2.Controls.Add(this.elevesDataGrid);
            this.metroPanel2.Controls.Add(this.metroLabel8);
            this.metroPanel2.Controls.Add(this.studSearchBox);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(322, 63);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(293, 350);
            this.metroPanel2.TabIndex = 10;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // deleteStudFromGroupBtn
            // 
            this.deleteStudFromGroupBtn.Location = new System.Drawing.Point(134, 324);
            this.deleteStudFromGroupBtn.Name = "deleteStudFromGroupBtn";
            this.deleteStudFromGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteStudFromGroupBtn.TabIndex = 14;
            this.deleteStudFromGroupBtn.Text = "Supprimer";
            this.deleteStudFromGroupBtn.Click += new System.EventHandler(this.deleteStudFromGroupBtn_Click);
            // 
            // editStudGroupBtn
            // 
            this.editStudGroupBtn.Location = new System.Drawing.Point(53, 324);
            this.editStudGroupBtn.Name = "editStudGroupBtn";
            this.editStudGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.editStudGroupBtn.TabIndex = 13;
            this.editStudGroupBtn.Text = "Modifier";
            this.editStudGroupBtn.Click += new System.EventHandler(this.editStudGroupBtn_Click);
            // 
            // addStudToGroupBtn
            // 
            this.addStudToGroupBtn.Location = new System.Drawing.Point(215, 324);
            this.addStudToGroupBtn.Name = "addStudToGroupBtn";
            this.addStudToGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.addStudToGroupBtn.TabIndex = 12;
            this.addStudToGroupBtn.Text = "Ajouter";
            this.addStudToGroupBtn.Click += new System.EventHandler(this.addStudToGroupBtn_Click);
            // 
            // elevesDataGrid
            // 
            this.elevesDataGrid.AllowUserToAddRows = false;
            this.elevesDataGrid.AllowUserToDeleteRows = false;
            this.elevesDataGrid.AllowUserToOrderColumns = true;
            this.elevesDataGrid.AutoGenerateColumns = false;
            this.elevesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elevesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.prenomDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.dateAffectationDataGridViewTextBoxColumn,
            this.affectéParDataGridViewTextBoxColumn});
            this.elevesDataGrid.DataSource = this.studentsgroupsBindingSource;
            this.elevesDataGrid.Location = new System.Drawing.Point(4, 105);
            this.elevesDataGrid.Name = "elevesDataGrid";
            this.elevesDataGrid.ReadOnly = true;
            this.elevesDataGrid.Size = new System.Drawing.Size(286, 213);
            this.elevesDataGrid.TabIndex = 9;
            this.elevesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.elevesDataGrid_CellContentClick);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(3, 70);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(129, 19);
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "Rechercher un élève:";
            // 
            // studSearchBox
            // 
            this.studSearchBox.Location = new System.Drawing.Point(139, 66);
            this.studSearchBox.Name = "studSearchBox";
            this.studSearchBox.Size = new System.Drawing.Size(151, 23);
            this.studSearchBox.TabIndex = 4;
            this.studSearchBox.Click += new System.EventHandler(this.studSearchBox_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Location = new System.Drawing.Point(3, 25);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(287, 23);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "A | Physique | Boukhmiss";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(147, 25);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "élèves du groupe:";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroLabel9);
            this.metroPanel3.Controls.Add(this.planningList);
            this.metroPanel3.Controls.Add(this.metroButton7);
            this.metroPanel3.Controls.Add(this.metroButton8);
            this.metroPanel3.Controls.Add(this.metroButton9);
            this.metroPanel3.Controls.Add(this.metroLabel11);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(618, 63);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(159, 241);
            this.metroPanel3.TabIndex = 15;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.Location = new System.Drawing.Point(4, 181);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(152, 51);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "*click droit sur la seance pour \r\neffectuer une action :\r\n(suppression,modificati" +
    "on,ajout)";
            // 
            // planningList
            // 
            this.planningList.Location = new System.Drawing.Point(4, 28);
            this.planningList.Name = "planningList";
            this.planningList.Size = new System.Drawing.Size(152, 146);
            this.planningList.TabIndex = 15;
            this.planningList.UseCompatibleStateImageBehavior = false;
            this.planningList.SelectedIndexChanged += new System.EventHandler(this.planningList_SelectedIndexChanged);
            // 
            // metroButton7
            // 
            this.metroButton7.Location = new System.Drawing.Point(134, 459);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(75, 23);
            this.metroButton7.TabIndex = 14;
            this.metroButton7.Text = "Supprimer";
            // 
            // metroButton8
            // 
            this.metroButton8.Location = new System.Drawing.Point(53, 459);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(75, 23);
            this.metroButton8.TabIndex = 13;
            this.metroButton8.Text = "Modifier";
            // 
            // metroButton9
            // 
            this.metroButton9.Location = new System.Drawing.Point(215, 459);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(75, 23);
            this.metroButton9.TabIndex = 12;
            this.metroButton9.Text = "Ajouter";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.Location = new System.Drawing.Point(4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(83, 25);
            this.metroLabel11.TabIndex = 2;
            this.metroLabel11.Text = "Planning:";
            // 
            // finishBtn
            // 
            this.finishBtn.Location = new System.Drawing.Point(702, 389);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(75, 23);
            this.finishBtn.TabIndex = 15;
            this.finishBtn.Text = "Terminer";
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // niveauxTableAdapter
            // 
            this.niveauxTableAdapter.ClearBeforeFill = true;
            // 
            // matieresTableAdapter
            // 
            this.matieresTableAdapter.ClearBeforeFill = true;
            // 
            // groups_infoTableAdapter
            // 
            this.groups_infoTableAdapter.ClearBeforeFill = true;
            // 
            // studentsgroupsBindingSource
            // 
            this.studentsgroupsBindingSource.DataMember = "Students_groups";
            this.studentsgroupsBindingSource.DataSource = this.oGEPdataSet;
            // 
            // students_groupsTableAdapter
            // 
            this.students_groupsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 5;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAffectationDataGridViewTextBoxColumn
            // 
            this.dateAffectationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dateAffectationDataGridViewTextBoxColumn.DataPropertyName = "Date affectation";
            this.dateAffectationDataGridViewTextBoxColumn.HeaderText = "Date affectation";
            this.dateAffectationDataGridViewTextBoxColumn.Name = "dateAffectationDataGridViewTextBoxColumn";
            this.dateAffectationDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateAffectationDataGridViewTextBoxColumn.Width = 5;
            // 
            // affectéParDataGridViewTextBoxColumn
            // 
            this.affectéParDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.affectéParDataGridViewTextBoxColumn.DataPropertyName = "affecté par";
            this.affectéParDataGridViewTextBoxColumn.HeaderText = "affecté par";
            this.affectéParDataGridViewTextBoxColumn.Name = "affectéParDataGridViewTextBoxColumn";
            this.affectéParDataGridViewTextBoxColumn.ReadOnly = true;
            this.affectéParDataGridViewTextBoxColumn.Width = 5;
            // 
            // Groupes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.ControlBox = false;
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Groupes";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Groupes";
            this.Load += new System.EventHandler(this.Groupes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupesDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGEPdataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveauxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matieresBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elevesDataGrid)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsgroupsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView groupesDatagrid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox niveauxCb;
        private MetroFramework.Controls.MetroComboBox matieresCB;
        private MetroFramework.Controls.MetroComboBox profCb;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton deleteGroupBtn;
        private MetroFramework.Controls.MetroButton editGroupBtn;
        private MetroFramework.Controls.MetroButton addGroupBtn;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton deleteStudFromGroupBtn;
        private MetroFramework.Controls.MetroButton editStudGroupBtn;
        private MetroFramework.Controls.MetroButton addStudToGroupBtn;
        private System.Windows.Forms.DataGridView elevesDataGrid;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox studSearchBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.ListView planningList;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroButton metroButton8;
        private MetroFramework.Controls.MetroButton metroButton9;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroButton finishBtn;
        private Data.OGEPdataSet oGEPdataSet;
        private System.Windows.Forms.BindingSource niveauxBindingSource;
        private Data.OGEPdataSetTableAdapters.NiveauxTableAdapter niveauxTableAdapter;
        private System.Windows.Forms.BindingSource matieresBindingSource;
        private Data.OGEPdataSetTableAdapters.MatieresTableAdapter matieresTableAdapter;
        private System.Windows.Forms.BindingSource groupsinfoBindingSource;
        private Data.OGEPdataSetTableAdapters.Groups_infoTableAdapter groups_infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matiereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomprofDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomprofDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentsgroupsBindingSource;
        private Data.OGEPdataSetTableAdapters.Students_groupsTableAdapter students_groupsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAffectationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn affectéParDataGridViewTextBoxColumn;
    }
}