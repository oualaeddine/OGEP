namespace OGEP.Views
{
    partial class ProfModules
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
            this.newModule = new MetroFramework.Controls.MetroButton();
            this.PrenomLabel = new MetroFramework.Controls.MetroLabel();
            this.NomLabel = new MetroFramework.Controls.MetroLabel();
            this.NumLabel = new MetroFramework.Controls.MetroLabel();
            this.closeBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.profModulesGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierGroupesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.profModulesGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newModule
            // 
            this.newModule.Location = new System.Drawing.Point(123, 345);
            this.newModule.Name = "newModule";
            this.newModule.Size = new System.Drawing.Size(106, 23);
            this.newModule.TabIndex = 17;
            this.newModule.Text = "Nouveau Module";
            // 
            // PrenomLabel
            // 
            this.PrenomLabel.Location = new System.Drawing.Point(92, 98);
            this.PrenomLabel.Name = "PrenomLabel";
            this.PrenomLabel.Size = new System.Drawing.Size(145, 19);
            this.PrenomLabel.TabIndex = 16;
            this.PrenomLabel.Text = "Ouala eddine";
            // 
            // NomLabel
            // 
            this.NomLabel.Location = new System.Drawing.Point(75, 79);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(120, 19);
            this.NomLabel.TabIndex = 15;
            this.NomLabel.Text = "Berrehal";
            // 
            // NumLabel
            // 
            this.NumLabel.Location = new System.Drawing.Point(189, 60);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(83, 19);
            this.NumLabel.TabIndex = 14;
            this.NumLabel.Text = "123";
            this.NumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(235, 345);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 13;
            this.closeBtn.Text = "Fermer";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 98);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Prenom :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Nom :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(160, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Numero de l\'enseignant : ";
            // 
            // profModulesGridView
            // 
            this.profModulesGridView.AllowUserToAddRows = false;
            this.profModulesGridView.AllowUserToDeleteRows = false;
            this.profModulesGridView.AllowUserToResizeRows = false;
            this.profModulesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.profModulesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profModulesGridView.Location = new System.Drawing.Point(23, 120);
            this.profModulesGridView.MultiSelect = false;
            this.profModulesGridView.Name = "profModulesGridView";
            this.profModulesGridView.ReadOnly = true;
            this.profModulesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.profModulesGridView.Size = new System.Drawing.Size(287, 219);
            this.profModulesGridView.TabIndex = 9;
            this.profModulesGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.profModulesGridView_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem,
            this.modifierGroupesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 48);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // modifierGroupesToolStripMenuItem
            // 
            this.modifierGroupesToolStripMenuItem.Name = "modifierGroupesToolStripMenuItem";
            this.modifierGroupesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.modifierGroupesToolStripMenuItem.Text = "Modifier Groupes";
            this.modifierGroupesToolStripMenuItem.Click += new System.EventHandler(this.modifierGroupesToolStripMenuItem_Click);
            // 
            // ProfModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 384);
            this.Controls.Add(this.newModule);
            this.Controls.Add(this.PrenomLabel);
            this.Controls.Add(this.NomLabel);
            this.Controls.Add(this.NumLabel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.profModulesGridView);
            this.Name = "ProfModules";
            this.Text = "Groupes de l\'enseignant";
            this.Load += new System.EventHandler(this.ProfModules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profModulesGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton newModule;
        private MetroFramework.Controls.MetroLabel PrenomLabel;
        private MetroFramework.Controls.MetroLabel NomLabel;
        private MetroFramework.Controls.MetroLabel NumLabel;
        private MetroFramework.Controls.MetroButton closeBtn;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView profModulesGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierGroupesToolStripMenuItem;
    }
}