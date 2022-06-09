namespace GameRPG
{
    partial class Menu
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
            this.showButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.addArtefactButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.manageaccountButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(310, 12);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(171, 50);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show my artefacts";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(310, 85);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(171, 50);
            this.addCategoryButton.TabIndex = 1;
            this.addCategoryButton.Text = "Add category";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // addArtefactButton
            // 
            this.addArtefactButton.Location = new System.Drawing.Point(310, 158);
            this.addArtefactButton.Name = "addArtefactButton";
            this.addArtefactButton.Size = new System.Drawing.Size(171, 50);
            this.addArtefactButton.TabIndex = 2;
            this.addArtefactButton.Text = "Add artefact";
            this.addArtefactButton.UseVisualStyleBackColor = true;
            this.addArtefactButton.Click += new System.EventHandler(this.addArtefactButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(310, 307);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(171, 50);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // manageaccountButton
            // 
            this.manageaccountButton.Location = new System.Drawing.Point(310, 233);
            this.manageaccountButton.Name = "manageaccountButton";
            this.manageaccountButton.Size = new System.Drawing.Size(171, 50);
            this.manageaccountButton.TabIndex = 7;
            this.manageaccountButton.Text = "Manage account";
            this.manageaccountButton.UseVisualStyleBackColor = true;
            this.manageaccountButton.Click += new System.EventHandler(this.manageaccountButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(310, 382);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(171, 50);
            this.adminButton.TabIndex = 8;
            this.adminButton.Text = "Admin zone";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.manageaccountButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.addArtefactButton);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.showButton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Button addArtefactButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button manageaccountButton;
        private System.Windows.Forms.Button adminButton;
    }
}