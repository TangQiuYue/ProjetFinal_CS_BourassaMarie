namespace ProjetFinal_CS_BourassaMarie
{
    partial class SystemDeGestion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addANewProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllProgramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addANewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programsToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programsToolStripMenuItem
            // 
            this.programsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addANewProgramToolStripMenuItem,
            this.deleteAProgramToolStripMenuItem,
            this.listAllProgramsToolStripMenuItem});
            this.programsToolStripMenuItem.Name = "programsToolStripMenuItem";
            this.programsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.programsToolStripMenuItem.Text = "Programs";
            // 
            // addANewProgramToolStripMenuItem
            // 
            this.addANewProgramToolStripMenuItem.Name = "addANewProgramToolStripMenuItem";
            this.addANewProgramToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.addANewProgramToolStripMenuItem.Text = "Add a new Program";
            this.addANewProgramToolStripMenuItem.Click += new System.EventHandler(this.addANewProgramToolStripMenuItem_Click);
            // 
            // deleteAProgramToolStripMenuItem
            // 
            this.deleteAProgramToolStripMenuItem.Name = "deleteAProgramToolStripMenuItem";
            this.deleteAProgramToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.deleteAProgramToolStripMenuItem.Text = "Delete a program";
            this.deleteAProgramToolStripMenuItem.Click += new System.EventHandler(this.deleteAProgramToolStripMenuItem_Click);
            // 
            // listAllProgramsToolStripMenuItem
            // 
            this.listAllProgramsToolStripMenuItem.Name = "listAllProgramsToolStripMenuItem";
            this.listAllProgramsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.listAllProgramsToolStripMenuItem.Text = "List all programs";
            this.listAllProgramsToolStripMenuItem.Click += new System.EventHandler(this.listAllProgramsToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addANewStudentToolStripMenuItem,
            this.deleteAStudentToolStripMenuItem,
            this.listStudentsToolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // addANewStudentToolStripMenuItem
            // 
            this.addANewStudentToolStripMenuItem.Name = "addANewStudentToolStripMenuItem";
            this.addANewStudentToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addANewStudentToolStripMenuItem.Text = "Add a new student";
            this.addANewStudentToolStripMenuItem.Click += new System.EventHandler(this.addANewStudentToolStripMenuItem_Click);
            // 
            // deleteAStudentToolStripMenuItem
            // 
            this.deleteAStudentToolStripMenuItem.Name = "deleteAStudentToolStripMenuItem";
            this.deleteAStudentToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.deleteAStudentToolStripMenuItem.Text = "Delete a student";
            this.deleteAStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteAStudentToolStripMenuItem_Click);
            // 
            // listStudentsToolStripMenuItem
            // 
            this.listStudentsToolStripMenuItem.Name = "listStudentsToolStripMenuItem";
            this.listStudentsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.listStudentsToolStripMenuItem.Text = "List students";
            this.listStudentsToolStripMenuItem.Click += new System.EventHandler(this.listStudentsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.quitToolStripMenuItem.Text = "Log Out";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // SystemDeGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SystemDeGestion";
            this.Text = "SystemDeGestion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addANewProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllProgramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addANewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}