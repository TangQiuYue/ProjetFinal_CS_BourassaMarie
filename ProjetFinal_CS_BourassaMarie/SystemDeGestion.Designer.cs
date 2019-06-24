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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDeleteProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemListPrograms = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDeleteStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemListStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemProgram,
            this.menuItemStudent,
            this.MenuItemQuit});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // MenuItemProgram
            // 
            this.MenuItemProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAddProgram,
            this.menuItemDeleteProgram,
            this.menuItemListPrograms});
            this.MenuItemProgram.Name = "MenuItemProgram";
            this.MenuItemProgram.Size = new System.Drawing.Size(152, 22);
            this.MenuItemProgram.Text = "Program";
            // 
            // menuItemAddProgram
            // 
            this.menuItemAddProgram.Name = "menuItemAddProgram";
            this.menuItemAddProgram.Size = new System.Drawing.Size(161, 22);
            this.menuItemAddProgram.Text = "Add program";
            this.menuItemAddProgram.Click += new System.EventHandler(this.menuItemAddProgram_Click);
            // 
            // menuItemDeleteProgram
            // 
            this.menuItemDeleteProgram.Name = "menuItemDeleteProgram";
            this.menuItemDeleteProgram.Size = new System.Drawing.Size(161, 22);
            this.menuItemDeleteProgram.Text = "Delete program";
            // 
            // menuItemListPrograms
            // 
            this.menuItemListPrograms.Name = "menuItemListPrograms";
            this.menuItemListPrograms.Size = new System.Drawing.Size(161, 22);
            this.menuItemListPrograms.Text = "List all programs";
            // 
            // menuItemStudent
            // 
            this.menuItemStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAddStudent,
            this.menuItemDeleteStudent,
            this.menuItemListStudents});
            this.menuItemStudent.Name = "menuItemStudent";
            this.menuItemStudent.Size = new System.Drawing.Size(152, 22);
            this.menuItemStudent.Text = "Student";
            // 
            // menuItemAddStudent
            // 
            this.menuItemAddStudent.Name = "menuItemAddStudent";
            this.menuItemAddStudent.Size = new System.Drawing.Size(155, 22);
            this.menuItemAddStudent.Text = "Add student";
            // 
            // menuItemDeleteStudent
            // 
            this.menuItemDeleteStudent.Name = "menuItemDeleteStudent";
            this.menuItemDeleteStudent.Size = new System.Drawing.Size(155, 22);
            this.menuItemDeleteStudent.Text = "Delete student";
            // 
            // menuItemListStudents
            // 
            this.menuItemListStudents.Name = "menuItemListStudents";
            this.menuItemListStudents.Size = new System.Drawing.Size(155, 22);
            this.menuItemListStudents.Text = "List all students";
            // 
            // MenuItemQuit
            // 
            this.MenuItemQuit.Name = "MenuItemQuit";
            this.MenuItemQuit.Size = new System.Drawing.Size(152, 22);
            this.MenuItemQuit.Text = "Quit";
            this.MenuItemQuit.Click += new System.EventHandler(this.MenuItemQuit_Click);
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
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProgram;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddProgram;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeleteProgram;
        private System.Windows.Forms.ToolStripMenuItem menuItemListPrograms;
        private System.Windows.Forms.ToolStripMenuItem menuItemStudent;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddStudent;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeleteStudent;
        private System.Windows.Forms.ToolStripMenuItem menuItemListStudents;
        private System.Windows.Forms.ToolStripMenuItem MenuItemQuit;
    }
}