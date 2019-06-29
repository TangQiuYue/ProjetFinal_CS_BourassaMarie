namespace ProjetFinal_CS_BourassaMarie
{
    partial class DeleteProgram
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
            this.comboBoxDeleteSelection = new System.Windows.Forms.ComboBox();
            this.labelDeleteSelection = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDeleteSelection
            // 
            this.comboBoxDeleteSelection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDeleteSelection.FormattingEnabled = true;
            this.comboBoxDeleteSelection.Location = new System.Drawing.Point(66, 62);
            this.comboBoxDeleteSelection.Name = "comboBoxDeleteSelection";
            this.comboBoxDeleteSelection.Size = new System.Drawing.Size(181, 27);
            this.comboBoxDeleteSelection.TabIndex = 0;
            this.comboBoxDeleteSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeleteSelection_SelectedIndexChanged);
            // 
            // labelDeleteSelection
            // 
            this.labelDeleteSelection.AutoSize = true;
            this.labelDeleteSelection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteSelection.Location = new System.Drawing.Point(62, 9);
            this.labelDeleteSelection.Name = "labelDeleteSelection";
            this.labelDeleteSelection.Size = new System.Drawing.Size(185, 38);
            this.labelDeleteSelection.TabIndex = 1;
            this.labelDeleteSelection.Text = "Please select the program\r\n you wan\'t to delete";
            this.labelDeleteSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(172, 206);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 27);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(66, 206);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 27);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // DeleteProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelDeleteSelection);
            this.Controls.Add(this.comboBoxDeleteSelection);
            this.Name = "DeleteProgram";
            this.Text = "DeleteProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDeleteSelection;
        private System.Windows.Forms.Label labelDeleteSelection;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBack;
    }
}