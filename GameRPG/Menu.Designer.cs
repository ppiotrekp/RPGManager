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
            this.editButton = new System.Windows.Forms.Button();
            this.manageButton = new System.Windows.Forms.Button();
            this.deleteCategorryButton = new System.Windows.Forms.Button();
            this.deleteArtefactButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(41, 25);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(171, 50);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(41, 98);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(171, 50);
            this.addCategoryButton.TabIndex = 1;
            this.addCategoryButton.Text = "Add category";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // addArtefactButton
            // 
            this.addArtefactButton.Location = new System.Drawing.Point(41, 171);
            this.addArtefactButton.Name = "addArtefactButton";
            this.addArtefactButton.Size = new System.Drawing.Size(171, 50);
            this.addArtefactButton.TabIndex = 2;
            this.addArtefactButton.Text = "Add artefact";
            this.addArtefactButton.UseVisualStyleBackColor = true;
            this.addArtefactButton.Click += new System.EventHandler(this.addArtefactButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(41, 241);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(171, 50);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit artefact";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // manageButton
            // 
            this.manageButton.Location = new System.Drawing.Point(422, 241);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(171, 50);
            this.manageButton.TabIndex = 4;
            this.manageButton.Text = "Manage account";
            this.manageButton.UseVisualStyleBackColor = true;
            // 
            // deleteCategorryButton
            // 
            this.deleteCategorryButton.Location = new System.Drawing.Point(422, 25);
            this.deleteCategorryButton.Name = "deleteCategorryButton";
            this.deleteCategorryButton.Size = new System.Drawing.Size(171, 50);
            this.deleteCategorryButton.TabIndex = 5;
            this.deleteCategorryButton.Text = "Delete category";
            this.deleteCategorryButton.UseVisualStyleBackColor = true;
            this.deleteCategorryButton.Click += new System.EventHandler(this.deleteCategorryButton_Click);
            // 
            // deleteArtefactButton
            // 
            this.deleteArtefactButton.Location = new System.Drawing.Point(422, 98);
            this.deleteArtefactButton.Name = "deleteArtefactButton";
            this.deleteArtefactButton.Size = new System.Drawing.Size(171, 50);
            this.deleteArtefactButton.TabIndex = 6;
            this.deleteArtefactButton.Text = "Delete artefact";
            this.deleteArtefactButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(422, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "Manage account";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.deleteArtefactButton);
            this.Controls.Add(this.deleteCategorryButton);
            this.Controls.Add(this.manageButton);
            this.Controls.Add(this.editButton);
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
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button manageButton;
        private System.Windows.Forms.Button deleteCategorryButton;
        private System.Windows.Forms.Button deleteArtefactButton;
        private System.Windows.Forms.Button button3;
    }
}