namespace BigoudBoxUserInterface
{
    partial class Home_UserControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Home_DataGridView = new System.Windows.Forms.DataGridView();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Home_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Home_DataGridView
            // 
            this.Home_DataGridView.AllowUserToAddRows = false;
            this.Home_DataGridView.AllowUserToDeleteRows = false;
            this.Home_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Home_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Home_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Home_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Event,
            this.Message});
            this.Home_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.Home_DataGridView.Name = "Home_DataGridView";
            this.Home_DataGridView.ReadOnly = true;
            this.Home_DataGridView.RowTemplate.Height = 24;
            this.Home_DataGridView.Size = new System.Drawing.Size(1050, 650);
            this.Home_DataGridView.TabIndex = 5;
            // 
            // Event
            // 
            this.Event.HeaderText = "Event";
            this.Event.Name = "Event";
            this.Event.ReadOnly = true;
            this.Event.Width = 80;
            // 
            // Message
            // 
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Width = 106;
            // 
            // Home_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.Home_DataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home_UserControl";
            this.Size = new System.Drawing.Size(1050, 650);
            ((System.ComponentModel.ISupportInitialize)(this.Home_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Home_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
    }
}
