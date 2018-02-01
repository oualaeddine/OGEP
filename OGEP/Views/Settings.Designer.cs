namespace OGEP.Views
{
    partial class Settings
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
            this.tabView = new MetroFramework.Controls.MetroTabControl();
            this.GeneralTab = new MetroFramework.Controls.MetroTabPage();
            this.ModulesMatieresTab = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panelNiveau = new MetroFramework.Controls.MetroPanel();
            this.editNiveauBtn = new MetroFramework.Controls.MetroButton();
            this.deleteNiveauBtn = new MetroFramework.Controls.MetroButton();
            this.AddNiveauBtn = new MetroFramework.Controls.MetroButton();
            this.NiveauxdataGridView = new System.Windows.Forms.DataGridView();
            this.niveauId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niveauxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oGEPdataSet = new OGEP.Data.OGEPdataSet();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.EditMatiereBtn = new MetroFramework.Controls.MetroButton();
            this.deleteMatiereBtn = new MetroFramework.Controls.MetroButton();
            this.addMatiereBtn = new MetroFramework.Controls.MetroButton();
            this.matieresDataGridView = new System.Windows.Forms.DataGridView();
            this.matiereId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matieresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.PrinterTab = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.matieresTableAdapter = new OGEP.Data.OGEPdataSetTableAdapters.MatieresTableAdapter();
            this.tableAdapterManager = new OGEP.Data.OGEPdataSetTableAdapters.TableAdapterManager();
            this.metroTextBox1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.niveauxTableAdapter = new OGEP.Data.OGEPdataSetTableAdapters.NiveauxTableAdapter();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tabView.SuspendLayout();
            this.ModulesMatieresTab.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.panelNiveau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NiveauxdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveauxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGEPdataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matieresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matieresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.GeneralTab);
            this.tabView.Controls.Add(this.ModulesMatieresTab);
            this.tabView.Controls.Add(this.PrinterTab);
            this.tabView.Controls.Add(this.metroTabPage3);
            this.tabView.Controls.Add(this.metroTabPage1);
            this.tabView.HotTrack = true;
            this.tabView.Location = new System.Drawing.Point(23, 63);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 1;
            this.tabView.Size = new System.Drawing.Size(754, 388);
            this.tabView.Style = MetroFramework.MetroColorStyle.Brown;
            this.tabView.TabIndex = 0;
            // 
            // GeneralTab
            // 
            this.GeneralTab.HorizontalScrollbarBarColor = true;
            this.GeneralTab.Location = new System.Drawing.Point(4, 35);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Size = new System.Drawing.Size(746, 349);
            this.GeneralTab.TabIndex = 0;
            this.GeneralTab.Text = "Generale";
            this.GeneralTab.VerticalScrollbarBarColor = true;
            // 
            // ModulesMatieresTab
            // 
            this.ModulesMatieresTab.AutoScroll = true;
            this.ModulesMatieresTab.Controls.Add(this.metroPanel1);
            this.ModulesMatieresTab.HorizontalScrollbar = true;
            this.ModulesMatieresTab.HorizontalScrollbarBarColor = true;
            this.ModulesMatieresTab.Location = new System.Drawing.Point(4, 35);
            this.ModulesMatieresTab.Name = "ModulesMatieresTab";
            this.ModulesMatieresTab.Size = new System.Drawing.Size(746, 349);
            this.ModulesMatieresTab.TabIndex = 1;
            this.ModulesMatieresTab.Text = "Modules et Niveaux";
            this.ModulesMatieresTab.VerticalScrollbar = true;
            this.ModulesMatieresTab.VerticalScrollbarBarColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.panelNiveau);
            this.metroPanel1.Controls.Add(this.EditMatiereBtn);
            this.metroPanel1.Controls.Add(this.deleteMatiereBtn);
            this.metroPanel1.Controls.Add(this.addMatiereBtn);
            this.metroPanel1.Controls.Add(this.matieresDataGridView);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(740, 343);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // panelNiveau
            // 
            this.panelNiveau.Controls.Add(this.editNiveauBtn);
            this.panelNiveau.Controls.Add(this.deleteNiveauBtn);
            this.panelNiveau.Controls.Add(this.AddNiveauBtn);
            this.panelNiveau.Controls.Add(this.NiveauxdataGridView);
            this.panelNiveau.Controls.Add(this.metroLabel2);
            this.panelNiveau.HorizontalScrollbarBarColor = true;
            this.panelNiveau.HorizontalScrollbarHighlightOnWheel = false;
            this.panelNiveau.HorizontalScrollbarSize = 10;
            this.panelNiveau.Location = new System.Drawing.Point(373, 3);
            this.panelNiveau.Name = "panelNiveau";
            this.panelNiveau.Size = new System.Drawing.Size(364, 343);
            this.panelNiveau.TabIndex = 4;
            this.panelNiveau.VerticalScrollbarBarColor = true;
            this.panelNiveau.VerticalScrollbarHighlightOnWheel = false;
            this.panelNiveau.VerticalScrollbarSize = 10;
            // 
            // editNiveauBtn
            // 
            this.editNiveauBtn.Location = new System.Drawing.Point(205, 314);
            this.editNiveauBtn.Name = "editNiveauBtn";
            this.editNiveauBtn.Size = new System.Drawing.Size(75, 23);
            this.editNiveauBtn.TabIndex = 11;
            this.editNiveauBtn.Text = "Modifier";
            this.editNiveauBtn.Click += new System.EventHandler(this.editNiveauBtn_Click);
            // 
            // deleteNiveauBtn
            // 
            this.deleteNiveauBtn.Location = new System.Drawing.Point(124, 314);
            this.deleteNiveauBtn.Name = "deleteNiveauBtn";
            this.deleteNiveauBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteNiveauBtn.TabIndex = 10;
            this.deleteNiveauBtn.Text = "Supprimer";
            this.deleteNiveauBtn.Click += new System.EventHandler(this.deleteNiveauBtn_Click);
            // 
            // AddNiveauBtn
            // 
            this.AddNiveauBtn.Location = new System.Drawing.Point(286, 314);
            this.AddNiveauBtn.Name = "AddNiveauBtn";
            this.AddNiveauBtn.Size = new System.Drawing.Size(75, 23);
            this.AddNiveauBtn.TabIndex = 9;
            this.AddNiveauBtn.Text = "Ajouter";
            this.AddNiveauBtn.Click += new System.EventHandler(this.AddNiveauBtn_Click);
            // 
            // NiveauxdataGridView
            // 
            this.NiveauxdataGridView.AllowUserToAddRows = false;
            this.NiveauxdataGridView.AllowUserToDeleteRows = false;
            this.NiveauxdataGridView.AllowUserToResizeColumns = false;
            this.NiveauxdataGridView.AllowUserToResizeRows = false;
            this.NiveauxdataGridView.AutoGenerateColumns = false;
            this.NiveauxdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NiveauxdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NiveauxdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.niveauId,
            this.dataGridViewTextBoxColumn1});
            this.NiveauxdataGridView.DataSource = this.niveauxBindingSource;
            this.NiveauxdataGridView.Location = new System.Drawing.Point(2, 22);
            this.NiveauxdataGridView.Name = "NiveauxdataGridView";
            this.NiveauxdataGridView.ReadOnly = true;
            this.NiveauxdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NiveauxdataGridView.Size = new System.Drawing.Size(359, 286);
            this.NiveauxdataGridView.TabIndex = 8;
            // 
            // niveauId
            // 
            this.niveauId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.niveauId.DataPropertyName = "Id";
            this.niveauId.HeaderText = "id";
            this.niveauId.Name = "niveauId";
            this.niveauId.ReadOnly = true;
            this.niveauId.Width = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn1.HeaderText = "Niveau";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // niveauxBindingSource
            // 
            this.niveauxBindingSource.DataMember = "Niveaux";
            this.niveauxBindingSource.DataSource = this.oGEPdataSet;
            // 
            // oGEPdataSet
            // 
            this.oGEPdataSet.DataSetName = "OGEPdataSet";
            this.oGEPdataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Liste des Niveaux:";
            // 
            // EditMatiereBtn
            // 
            this.EditMatiereBtn.Location = new System.Drawing.Point(211, 317);
            this.EditMatiereBtn.Name = "EditMatiereBtn";
            this.EditMatiereBtn.Size = new System.Drawing.Size(75, 23);
            this.EditMatiereBtn.TabIndex = 6;
            this.EditMatiereBtn.Text = "Modifier";
            this.EditMatiereBtn.Click += new System.EventHandler(this.EditMatiereBtn_Click);
            // 
            // deleteMatiereBtn
            // 
            this.deleteMatiereBtn.Location = new System.Drawing.Point(130, 317);
            this.deleteMatiereBtn.Name = "deleteMatiereBtn";
            this.deleteMatiereBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteMatiereBtn.TabIndex = 5;
            this.deleteMatiereBtn.Text = "Supprimer";
            this.deleteMatiereBtn.Click += new System.EventHandler(this.deleteMatiereBtn_Click);
            // 
            // addMatiereBtn
            // 
            this.addMatiereBtn.Location = new System.Drawing.Point(292, 317);
            this.addMatiereBtn.Name = "addMatiereBtn";
            this.addMatiereBtn.Size = new System.Drawing.Size(75, 23);
            this.addMatiereBtn.TabIndex = 4;
            this.addMatiereBtn.Text = "Ajouter";
            this.addMatiereBtn.Click += new System.EventHandler(this.addMatiereBtn_Click);
            // 
            // matieresDataGridView
            // 
            this.matieresDataGridView.AllowUserToAddRows = false;
            this.matieresDataGridView.AllowUserToDeleteRows = false;
            this.matieresDataGridView.AllowUserToResizeColumns = false;
            this.matieresDataGridView.AllowUserToResizeRows = false;
            this.matieresDataGridView.AutoGenerateColumns = false;
            this.matieresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matieresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matieresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matiereId,
            this.dataGridViewTextBoxColumn2});
            this.matieresDataGridView.DataSource = this.matieresBindingSource;
            this.matieresDataGridView.Location = new System.Drawing.Point(3, 25);
            this.matieresDataGridView.MultiSelect = false;
            this.matieresDataGridView.Name = "matieresDataGridView";
            this.matieresDataGridView.ReadOnly = true;
            this.matieresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.matieresDataGridView.ShowCellErrors = false;
            this.matieresDataGridView.ShowEditingIcon = false;
            this.matieresDataGridView.ShowRowErrors = false;
            this.matieresDataGridView.Size = new System.Drawing.Size(364, 286);
            this.matieresDataGridView.TabIndex = 3;
            // 
            // matiereId
            // 
            this.matiereId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.matiereId.DataPropertyName = "Id";
            this.matiereId.HeaderText = "id";
            this.matiereId.Name = "matiereId";
            this.matiereId.ReadOnly = true;
            this.matiereId.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Matiére";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // matieresBindingSource
            // 
            this.matieresBindingSource.DataMember = "Matieres";
            this.matieresBindingSource.DataSource = this.oGEPdataSet;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Liste des Matieres :";
            // 
            // PrinterTab
            // 
            this.PrinterTab.HorizontalScrollbarBarColor = true;
            this.PrinterTab.Location = new System.Drawing.Point(4, 35);
            this.PrinterTab.Name = "PrinterTab";
            this.PrinterTab.Size = new System.Drawing.Size(746, 349);
            this.PrinterTab.TabIndex = 2;
            this.PrinterTab.Text = "Compte d\'utilisateur";
            this.PrinterTab.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(746, 349);
            this.metroTabPage3.TabIndex = 3;
            this.metroTabPage3.Text = "Imprimentes et peripheriques";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(746, 349);
            this.metroTabPage1.TabIndex = 4;
            this.metroTabPage1.Text = "Sauvegarde et restauration";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // matieresTableAdapter
            // 
            this.matieresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MatieresTableAdapter = this.matieresTableAdapter;
            this.tableAdapterManager.ModulesTableAdapter = null;
            this.tableAdapterManager.NiveauxTableAdapter = null;
            this.tableAdapterManager.ProfPaymentTableAdapter = null;
            this.tableAdapterManager.ProfsTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.StudModuleTableAdapter = null;
            this.tableAdapterManager.StudPaymentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OGEP.Data.OGEPdataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.UserTypesTableAdapter = null;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Owner = null;
            // 
            // niveauxTableAdapter
            // 
            this.niveauxTableAdapter.ClearBeforeFill = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(705, 457);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Terminer";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 494);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tabView);
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Parametres";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabView.ResumeLayout(false);
            this.ModulesMatieresTab.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panelNiveau.ResumeLayout(false);
            this.panelNiveau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NiveauxdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveauxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGEPdataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matieresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matieresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroTextBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabView;
        private MetroFramework.Controls.MetroTabPage GeneralTab;
        private MetroFramework.Controls.MetroTabPage ModulesMatieresTab;
        private MetroFramework.Controls.MetroTabPage PrinterTab;
        private Data.OGEPdataSet oGEPdataSet;
        private System.Windows.Forms.BindingSource matieresBindingSource;
        private Data.OGEPdataSetTableAdapters.MatieresTableAdapter matieresTableAdapter;
        private Data.OGEPdataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView matieresDataGridView;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager metroTextBox1;
        private MetroFramework.Controls.MetroPanel panelNiveau;
        private MetroFramework.Controls.MetroButton editNiveauBtn;
        private MetroFramework.Controls.MetroButton deleteNiveauBtn;
        private MetroFramework.Controls.MetroButton AddNiveauBtn;
        private System.Windows.Forms.DataGridView NiveauxdataGridView;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton EditMatiereBtn;
        private MetroFramework.Controls.MetroButton deleteMatiereBtn;
        private MetroFramework.Controls.MetroButton addMatiereBtn;
        private System.Windows.Forms.BindingSource niveauxBindingSource;
        private Data.OGEPdataSetTableAdapters.NiveauxTableAdapter niveauxTableAdapter;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn matiereId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn niveauId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}