namespace ProjetFinal_CS_BourassaMarie
{
    partial class ListAllPrograms
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
            this.components = new System.ComponentModel.Container();
            this.programsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalProjDBDataSet = new ProjetFinal_CS_BourassaMarie.FinalProjDBDataSet();
            this.programsTableAdapter = new ProjetFinal_CS_BourassaMarie.FinalProjDBDataSetTableAdapters.ProgramsTableAdapter();
            this.buttonListAll = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodeProgram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProgram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // programsBindingSource
            // 
            this.programsBindingSource.DataMember = "Programs";
            this.programsBindingSource.DataSource = this.finalProjDBDataSet;
            // 
            // finalProjDBDataSet
            // 
            this.finalProjDBDataSet.DataSetName = "FinalProjDBDataSet";
            this.finalProjDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programsTableAdapter
            // 
            this.programsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonListAll
            // 
            this.buttonListAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListAll.Location = new System.Drawing.Point(55, 256);
            this.buttonListAll.Name = "buttonListAll";
            this.buttonListAll.Size = new System.Drawing.Size(75, 34);
            this.buttonListAll.TabIndex = 1;
            this.buttonListAll.Text = "List All";
            this.buttonListAll.UseVisualStyleBackColor = true;
            this.buttonListAll.Click += new System.EventHandler(this.buttonListAll_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(723, 256);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 34);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeProgram,
            this.NameProgram,
            this.Course1,
            this.Course2,
            this.Course3,
            this.Column4,
            this.Course5});
            this.dataGridView1.Location = new System.Drawing.Point(40, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // CodeProgram
            // 
            this.CodeProgram.HeaderText = "Column1";
            this.CodeProgram.Name = "CodeProgram";
            // 
            // NameProgram
            // 
            this.NameProgram.HeaderText = "Name Program";
            this.NameProgram.Name = "NameProgram";
            // 
            // Course1
            // 
            this.Course1.HeaderText = "Course1";
            this.Course1.Name = "Course1";
            // 
            // Course2
            // 
            this.Course2.HeaderText = "Course2";
            this.Course2.Name = "Course2";
            // 
            // Course3
            // 
            this.Course3.HeaderText = "Course3";
            this.Course3.Name = "Course3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Course5
            // 
            this.Course5.HeaderText = "Course5";
            this.Course5.Name = "Course5";
            // 
            // ListAllPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 302);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonListAll);
            this.Name = "ListAllPrograms";
            this.Text = "ListAllPrograms";
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FinalProjDBDataSet finalProjDBDataSet;
        private System.Windows.Forms.BindingSource programsBindingSource;
        private FinalProjDBDataSetTableAdapters.ProgramsTableAdapter programsTableAdapter;
        private System.Windows.Forms.Button buttonListAll;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course5;
    }
}