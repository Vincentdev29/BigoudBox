namespace BigoudBoxUserInterface
{
    partial class Dashboard_UserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_UserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChoiceAdhrent_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.Request_DataGridView = new System.Windows.Forms.DataGridView();
            this.Requête = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeleteSeance_Button = new System.Windows.Forms.Button();
            this.DeleteSeance_ComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteSeance_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DeleteSeance_DomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RechargeSeance_Button = new System.Windows.Forms.Button();
            this.RechargeSeance_domainUpDown = new System.Windows.Forms.DomainUpDown();
            this.Identite_DataGridView = new System.Windows.Forms.DataGridView();
            this.Property = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identite_CheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Request_DataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Identite_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChoiceAdhrent_CheckedListBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(300, 391);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sélection adhérent";
            // 
            // ChoiceAdhrent_CheckedListBox
            // 
            this.ChoiceAdhrent_CheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceAdhrent_CheckedListBox.FormattingEnabled = true;
            this.ChoiceAdhrent_CheckedListBox.Items.AddRange(new object[] {
            "ELEMENT TEST"});
            this.ChoiceAdhrent_CheckedListBox.Location = new System.Drawing.Point(10, 31);
            this.ChoiceAdhrent_CheckedListBox.Margin = new System.Windows.Forms.Padding(5);
            this.ChoiceAdhrent_CheckedListBox.Name = "ChoiceAdhrent_CheckedListBox";
            this.ChoiceAdhrent_CheckedListBox.Size = new System.Drawing.Size(280, 356);
            this.ChoiceAdhrent_CheckedListBox.TabIndex = 0;
            this.ChoiceAdhrent_CheckedListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChoiceAdhrent_CheckedListBox_MouseClick);
            // 
            // Request_DataGridView
            // 
            this.Request_DataGridView.AllowUserToAddRows = false;
            this.Request_DataGridView.AllowUserToDeleteRows = false;
            this.Request_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Request_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Request_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Request_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Requête});
            this.Request_DataGridView.Location = new System.Drawing.Point(337, 31);
            this.Request_DataGridView.Name = "Request_DataGridView";
            this.Request_DataGridView.ReadOnly = true;
            this.Request_DataGridView.RowTemplate.Height = 24;
            this.Request_DataGridView.Size = new System.Drawing.Size(695, 380);
            this.Request_DataGridView.TabIndex = 3;
            // 
            // Requête
            // 
            this.Requête.HeaderText = "Requête";
            this.Requête.Name = "Requête";
            this.Requête.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.DeleteSeance_ComboBox);
            this.groupBox2.Controls.Add(this.DeleteSeance_DateTimePicker);
            this.groupBox2.Controls.Add(this.DeleteSeance_DomainUpDown);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(337, 417);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 228);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrée Séance";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.DeleteSeance_Button);
            this.panel2.Location = new System.Drawing.Point(55, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 80);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // DeleteSeance_Button
            // 
            this.DeleteSeance_Button.FlatAppearance.BorderSize = 0;
            this.DeleteSeance_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSeance_Button.ForeColor = System.Drawing.Color.White;
            this.DeleteSeance_Button.Location = new System.Drawing.Point(80, 0);
            this.DeleteSeance_Button.Name = "DeleteSeance_Button";
            this.DeleteSeance_Button.Size = new System.Drawing.Size(150, 80);
            this.DeleteSeance_Button.TabIndex = 2;
            this.DeleteSeance_Button.Text = "Entrée";
            this.DeleteSeance_Button.UseVisualStyleBackColor = true;
            this.DeleteSeance_Button.Click += new System.EventHandler(this.DeleteSeance_Button_Click);
            // 
            // DeleteSeance_ComboBox
            // 
            this.DeleteSeance_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSeance_ComboBox.FormattingEnabled = true;
            this.DeleteSeance_ComboBox.Location = new System.Drawing.Point(7, 97);
            this.DeleteSeance_ComboBox.Name = "DeleteSeance_ComboBox";
            this.DeleteSeance_ComboBox.Size = new System.Drawing.Size(327, 30);
            this.DeleteSeance_ComboBox.TabIndex = 4;
            // 
            // DeleteSeance_DateTimePicker
            // 
            this.DeleteSeance_DateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSeance_DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSeance_DateTimePicker.Location = new System.Drawing.Point(6, 62);
            this.DeleteSeance_DateTimePicker.Name = "DeleteSeance_DateTimePicker";
            this.DeleteSeance_DateTimePicker.Size = new System.Drawing.Size(328, 28);
            this.DeleteSeance_DateTimePicker.TabIndex = 3;
            this.DeleteSeance_DateTimePicker.ValueChanged += new System.EventHandler(this.DeleteSeance_DateTimePicker_ValueChanged);
            // 
            // DeleteSeance_DomainUpDown
            // 
            this.DeleteSeance_DomainUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSeance_DomainUpDown.Items.Add("1");
            this.DeleteSeance_DomainUpDown.Items.Add("2");
            this.DeleteSeance_DomainUpDown.Items.Add("3");
            this.DeleteSeance_DomainUpDown.Items.Add("4");
            this.DeleteSeance_DomainUpDown.Items.Add("5");
            this.DeleteSeance_DomainUpDown.Items.Add("6");
            this.DeleteSeance_DomainUpDown.Items.Add("7");
            this.DeleteSeance_DomainUpDown.Items.Add("8");
            this.DeleteSeance_DomainUpDown.Items.Add("9");
            this.DeleteSeance_DomainUpDown.Items.Add("10");
            this.DeleteSeance_DomainUpDown.Items.Add("11");
            this.DeleteSeance_DomainUpDown.Items.Add("12");
            this.DeleteSeance_DomainUpDown.Items.Add("13");
            this.DeleteSeance_DomainUpDown.Items.Add("14");
            this.DeleteSeance_DomainUpDown.Items.Add("15");
            this.DeleteSeance_DomainUpDown.Items.Add("16");
            this.DeleteSeance_DomainUpDown.Items.Add("17");
            this.DeleteSeance_DomainUpDown.Items.Add("18");
            this.DeleteSeance_DomainUpDown.Items.Add("19");
            this.DeleteSeance_DomainUpDown.Items.Add("20");
            this.DeleteSeance_DomainUpDown.Items.Add("21");
            this.DeleteSeance_DomainUpDown.Items.Add("22");
            this.DeleteSeance_DomainUpDown.Items.Add("23");
            this.DeleteSeance_DomainUpDown.Items.Add("24");
            this.DeleteSeance_DomainUpDown.Items.Add("25");
            this.DeleteSeance_DomainUpDown.Items.Add("26");
            this.DeleteSeance_DomainUpDown.Items.Add("27");
            this.DeleteSeance_DomainUpDown.Items.Add("28");
            this.DeleteSeance_DomainUpDown.Items.Add("29");
            this.DeleteSeance_DomainUpDown.Items.Add("30");
            this.DeleteSeance_DomainUpDown.Location = new System.Drawing.Point(6, 29);
            this.DeleteSeance_DomainUpDown.Name = "DeleteSeance_DomainUpDown";
            this.DeleteSeance_DomainUpDown.Size = new System.Drawing.Size(328, 28);
            this.DeleteSeance_DomainUpDown.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.RechargeSeance_domainUpDown);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(692, 417);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 228);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rechargement Ticket";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.RechargeSeance_Button);
            this.panel1.Location = new System.Drawing.Point(69, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 80);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // RechargeSeance_Button
            // 
            this.RechargeSeance_Button.FlatAppearance.BorderSize = 0;
            this.RechargeSeance_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RechargeSeance_Button.ForeColor = System.Drawing.Color.White;
            this.RechargeSeance_Button.Location = new System.Drawing.Point(80, 0);
            this.RechargeSeance_Button.Name = "RechargeSeance_Button";
            this.RechargeSeance_Button.Size = new System.Drawing.Size(150, 80);
            this.RechargeSeance_Button.TabIndex = 3;
            this.RechargeSeance_Button.Text = "Recharger";
            this.RechargeSeance_Button.UseVisualStyleBackColor = true;
            // 
            // RechargeSeance_domainUpDown
            // 
            this.RechargeSeance_domainUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechargeSeance_domainUpDown.Location = new System.Drawing.Point(6, 60);
            this.RechargeSeance_domainUpDown.Name = "RechargeSeance_domainUpDown";
            this.RechargeSeance_domainUpDown.Size = new System.Drawing.Size(328, 28);
            this.RechargeSeance_domainUpDown.TabIndex = 1;
            // 
            // Identite_DataGridView
            // 
            this.Identite_DataGridView.AllowUserToAddRows = false;
            this.Identite_DataGridView.AllowUserToDeleteRows = false;
            this.Identite_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Identite_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Identite_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Identite_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Property,
            this.Value});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Identite_DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Identite_DataGridView.Location = new System.Drawing.Point(20, 447);
            this.Identite_DataGridView.Name = "Identite_DataGridView";
            this.Identite_DataGridView.ReadOnly = true;
            this.Identite_DataGridView.RowTemplate.Height = 24;
            this.Identite_DataGridView.Size = new System.Drawing.Size(300, 192);
            this.Identite_DataGridView.TabIndex = 6;
            // 
            // Property
            // 
            this.Property.HeaderText = "Property";
            this.Property.Name = "Property";
            this.Property.ReadOnly = true;
            this.Property.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Property.Width = 78;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Value.Width = 57;
            // 
            // Identite_CheckBox
            // 
            this.Identite_CheckBox.AutoSize = true;
            this.Identite_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Identite_CheckBox.Location = new System.Drawing.Point(20, 417);
            this.Identite_CheckBox.Name = "Identite_CheckBox";
            this.Identite_CheckBox.Size = new System.Drawing.Size(117, 24);
            this.Identite_CheckBox.TabIndex = 7;
            this.Identite_CheckBox.Text = "Identité(e)";
            this.Identite_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Dashboard_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.Identite_CheckBox);
            this.Controls.Add(this.Identite_DataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Request_DataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dashboard_UserControl";
            this.Size = new System.Drawing.Size(1050, 650);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Request_DataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Identite_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox ChoiceAdhrent_CheckedListBox;
        private System.Windows.Forms.DataGridView Request_DataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DomainUpDown DeleteSeance_DomainUpDown;
        private System.Windows.Forms.DomainUpDown RechargeSeance_domainUpDown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button DeleteSeance_Button;
        private System.Windows.Forms.Button RechargeSeance_Button;
        private System.Windows.Forms.DateTimePicker DeleteSeance_DateTimePicker;
        private System.Windows.Forms.ComboBox DeleteSeance_ComboBox;
        private System.Windows.Forms.DataGridView Identite_DataGridView;
        private System.Windows.Forms.CheckBox Identite_CheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Property;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requête;
    }
}
