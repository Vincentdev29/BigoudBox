namespace BigoudBoxUserInterface
{
    partial class MainMenu_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu_UserControl));
            this.Home_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Home_Button
            // 
            this.Home_Button.FlatAppearance.BorderSize = 0;
            this.Home_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_Button.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_Button.ForeColor = System.Drawing.Color.White;
            this.Home_Button.Image = ((System.Drawing.Image)(resources.GetObject("Home_Button.Image")));
            this.Home_Button.Location = new System.Drawing.Point(0, 20);
            this.Home_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Size = new System.Drawing.Size(230, 80);
            this.Home_Button.TabIndex = 4;
            this.Home_Button.Text = "HOME";
            this.Home_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home_Button.UseVisualStyleBackColor = true;
            // 
            // MainMenu_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.Controls.Add(this.Home_Button);
            this.Name = "MainMenu_UserControl";
            this.Size = new System.Drawing.Size(230, 650);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Home_Button;
    }
}
