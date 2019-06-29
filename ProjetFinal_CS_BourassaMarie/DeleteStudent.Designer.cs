namespace ProjetFinal_CS_BourassaMarie
{
    partial class DeleteStudent
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelDeleteSelection = new System.Windows.Forms.Label();
            this.textBoxEnterPermCode = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PermCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.labelAreYouSure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(646, 272);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 28);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelDeleteSelection
            // 
            this.labelDeleteSelection.AutoSize = true;
            this.labelDeleteSelection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteSelection.Location = new System.Drawing.Point(12, 9);
            this.labelDeleteSelection.Name = "labelDeleteSelection";
            this.labelDeleteSelection.Size = new System.Drawing.Size(249, 38);
            this.labelDeleteSelection.TabIndex = 5;
            this.labelDeleteSelection.Text = "Please enter the permanenet code \r\nof the student your wish to ";
            this.labelDeleteSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEnterPermCode
            // 
            this.textBoxEnterPermCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnterPermCode.Location = new System.Drawing.Point(54, 75);
            this.textBoxEnterPermCode.Name = "textBoxEnterPermCode";
            this.textBoxEnterPermCode.Size = new System.Drawing.Size(165, 27);
            this.textBoxEnterPermCode.TabIndex = 8;
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.Location = new System.Drawing.Point(54, 121);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 28);
            this.buttonFind.TabIndex = 9;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PermCode,
            this.FirstName,
            this.LastName,
            this.DoB});
            this.dataGridView1.Location = new System.Drawing.Point(276, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 76);
            this.dataGridView1.TabIndex = 10;
            // 
            // PermCode
            // 
            this.PermCode.HeaderText = "Permanent Code";
            this.PermCode.Name = "PermCode";
            this.PermCode.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // DoB
            // 
            this.DoB.HeaderText = "Date of Birth";
            this.DoB.Name = "DoB";
            this.DoB.ReadOnly = true;
            // 
            // buttonYes
            // 
            this.buttonYes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYes.ForeColor = System.Drawing.Color.Red;
            this.buttonYes.Location = new System.Drawing.Point(401, 201);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(75, 31);
            this.buttonYes.TabIndex = 11;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Visible = false;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNo.Location = new System.Drawing.Point(523, 201);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 31);
            this.buttonNo.TabIndex = 12;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Visible = false;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // labelAreYouSure
            // 
            this.labelAreYouSure.AutoSize = true;
            this.labelAreYouSure.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAreYouSure.ForeColor = System.Drawing.Color.Red;
            this.labelAreYouSure.Location = new System.Drawing.Point(305, 161);
            this.labelAreYouSure.Name = "labelAreYouSure";
            this.labelAreYouSure.Size = new System.Drawing.Size(370, 19);
            this.labelAreYouSure.TabIndex = 13;
            this.labelAreYouSure.Text = "Are you sure this is the student you wish to remove?";
            this.labelAreYouSure.Visible = false;
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 312);
            this.Controls.Add(this.labelAreYouSure);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxEnterPermCode);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelDeleteSelection);
            this.Name = "DeleteStudent";
            this.Text = "DeleteStudent";
            this.Load += new System.EventHandler(this.DeleteStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelDeleteSelection;
        private System.Windows.Forms.TextBox textBoxEnterPermCode;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoB;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Label labelAreYouSure;
    }
}