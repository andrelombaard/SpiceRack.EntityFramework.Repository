namespace SpiceRack.NetFramework.EntityFrameworkCore.Repository
{
    partial class ExampleForm
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
            this.CreateDatabaseButton = new System.Windows.Forms.Button();
            this.DeleteDatabaseButton = new System.Windows.Forms.Button();
            this.CreateDeleteDatabaseGroupBox = new System.Windows.Forms.GroupBox();
            this.SeedDatabaseDataGroupBox = new System.Windows.Forms.GroupBox();
            this.SeedDebugDataButton = new System.Windows.Forms.Button();
            this.SeedProductionDataButton = new System.Windows.Forms.Button();
            this.CrudGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CreateDeleteDatabaseGroupBox.SuspendLayout();
            this.SeedDatabaseDataGroupBox.SuspendLayout();
            this.CrudGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateDatabaseButton
            // 
            this.CreateDatabaseButton.Location = new System.Drawing.Point(20, 32);
            this.CreateDatabaseButton.Name = "CreateDatabaseButton";
            this.CreateDatabaseButton.Size = new System.Drawing.Size(220, 52);
            this.CreateDatabaseButton.TabIndex = 0;
            this.CreateDatabaseButton.Text = "Create Database";
            this.CreateDatabaseButton.UseVisualStyleBackColor = true;
            this.CreateDatabaseButton.Click += new System.EventHandler(this.CreateDatabaseButton_Click);
            // 
            // DeleteDatabaseButton
            // 
            this.DeleteDatabaseButton.Location = new System.Drawing.Point(246, 32);
            this.DeleteDatabaseButton.Name = "DeleteDatabaseButton";
            this.DeleteDatabaseButton.Size = new System.Drawing.Size(220, 52);
            this.DeleteDatabaseButton.TabIndex = 1;
            this.DeleteDatabaseButton.Text = "Delete Database";
            this.DeleteDatabaseButton.UseVisualStyleBackColor = true;
            this.DeleteDatabaseButton.Click += new System.EventHandler(this.DeleteDatabaseButton_Click);
            // 
            // CreateDeleteDatabaseGroupBox
            // 
            this.CreateDeleteDatabaseGroupBox.Controls.Add(this.CreateDatabaseButton);
            this.CreateDeleteDatabaseGroupBox.Controls.Add(this.DeleteDatabaseButton);
            this.CreateDeleteDatabaseGroupBox.Location = new System.Drawing.Point(13, 13);
            this.CreateDeleteDatabaseGroupBox.Name = "CreateDeleteDatabaseGroupBox";
            this.CreateDeleteDatabaseGroupBox.Size = new System.Drawing.Size(497, 108);
            this.CreateDeleteDatabaseGroupBox.TabIndex = 2;
            this.CreateDeleteDatabaseGroupBox.TabStop = false;
            this.CreateDeleteDatabaseGroupBox.Text = "Create/Delete Database";
            // 
            // SeedDatabaseDataGroupBox
            // 
            this.SeedDatabaseDataGroupBox.Controls.Add(this.SeedProductionDataButton);
            this.SeedDatabaseDataGroupBox.Controls.Add(this.SeedDebugDataButton);
            this.SeedDatabaseDataGroupBox.Location = new System.Drawing.Point(13, 138);
            this.SeedDatabaseDataGroupBox.Name = "SeedDatabaseDataGroupBox";
            this.SeedDatabaseDataGroupBox.Size = new System.Drawing.Size(497, 116);
            this.SeedDatabaseDataGroupBox.TabIndex = 3;
            this.SeedDatabaseDataGroupBox.TabStop = false;
            this.SeedDatabaseDataGroupBox.Text = "Seed Database Data";
            // 
            // SeedDebugDataButton
            // 
            this.SeedDebugDataButton.Location = new System.Drawing.Point(20, 35);
            this.SeedDebugDataButton.Name = "SeedDebugDataButton";
            this.SeedDebugDataButton.Size = new System.Drawing.Size(220, 52);
            this.SeedDebugDataButton.TabIndex = 1;
            this.SeedDebugDataButton.Text = "Seed Debug Data";
            this.SeedDebugDataButton.UseVisualStyleBackColor = true;
            this.SeedDebugDataButton.Click += new System.EventHandler(this.SeedDebugDataButton_Click);
            // 
            // SeedProductionDataButton
            // 
            this.SeedProductionDataButton.Location = new System.Drawing.Point(246, 35);
            this.SeedProductionDataButton.Name = "SeedProductionDataButton";
            this.SeedProductionDataButton.Size = new System.Drawing.Size(220, 52);
            this.SeedProductionDataButton.TabIndex = 2;
            this.SeedProductionDataButton.Text = "Seed Production Data";
            this.SeedProductionDataButton.UseVisualStyleBackColor = true;
            this.SeedProductionDataButton.Click += new System.EventHandler(this.SeedProductionDataButton_Click);
            // 
            // CrudGroupBox
            // 
            this.CrudGroupBox.Controls.Add(this.DeleteButton);
            this.CrudGroupBox.Controls.Add(this.UpdateButton);
            this.CrudGroupBox.Controls.Add(this.ReadButton);
            this.CrudGroupBox.Controls.Add(this.CreateButton);
            this.CrudGroupBox.Location = new System.Drawing.Point(13, 270);
            this.CrudGroupBox.Name = "CrudGroupBox";
            this.CrudGroupBox.Size = new System.Drawing.Size(497, 166);
            this.CrudGroupBox.TabIndex = 4;
            this.CrudGroupBox.TabStop = false;
            this.CrudGroupBox.Text = "CRUD";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(20, 33);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(220, 52);
            this.CreateButton.TabIndex = 2;
            this.CreateButton.Text = "Create a Database Entry";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(246, 33);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(220, 52);
            this.ReadButton.TabIndex = 3;
            this.ReadButton.Text = "Read a Database Entry";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(20, 91);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(220, 52);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update a Database Entry";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(246, 91);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(220, 52);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete a Database Entry";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 467);
            this.Controls.Add(this.CrudGroupBox);
            this.Controls.Add(this.SeedDatabaseDataGroupBox);
            this.Controls.Add(this.CreateDeleteDatabaseGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExampleForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SpiceRack.NetFramework.EntityFrameworkCore.Repository";
            this.Load += new System.EventHandler(this.ExampleForm_Load);
            this.CreateDeleteDatabaseGroupBox.ResumeLayout(false);
            this.SeedDatabaseDataGroupBox.ResumeLayout(false);
            this.CrudGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateDatabaseButton;
        private System.Windows.Forms.Button DeleteDatabaseButton;
        private System.Windows.Forms.GroupBox CreateDeleteDatabaseGroupBox;
        private System.Windows.Forms.GroupBox SeedDatabaseDataGroupBox;
        private System.Windows.Forms.Button SeedProductionDataButton;
        private System.Windows.Forms.Button SeedDebugDataButton;
        private System.Windows.Forms.GroupBox CrudGroupBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button CreateButton;
    }
}

