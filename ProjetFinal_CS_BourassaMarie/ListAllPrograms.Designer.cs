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
            this.dataGridViewPrograms = new System.Windows.Forms.DataGridView();
            this.finalProjDBDataSet = new ProjetFinal_CS_BourassaMarie.FinalProjDBDataSet();
            this.programsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programsTableAdapter = new ProjetFinal_CS_BourassaMarie.FinalProjDBDataSetTableAdapters.ProgramsTableAdapter();
            this.codeProgramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProgramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPrograms
            // 
            this.dataGridViewPrograms.AutoGenerateColumns = false;
            this.dataGridViewPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrograms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeProgramDataGridViewTextBoxColumn,
            this.nameProgramDataGridViewTextBoxColumn,
            this.course1DataGridViewTextBoxColumn,
            this.course2DataGridViewTextBoxColumn,
            this.course3DataGridViewTextBoxColumn,
            this.course4DataGridViewTextBoxColumn,
            this.course5DataGridViewTextBoxColumn});
            this.dataGridViewPrograms.DataSource = this.programsBindingSource;
            this.dataGridViewPrograms.Location = new System.Drawing.Point(55, 42);
            this.dataGridViewPrograms.Name = "dataGridViewPrograms";
            this.dataGridViewPrograms.Size = new System.Drawing.Size(743, 150);
            this.dataGridViewPrograms.TabIndex = 0;
            this.dataGridViewPrograms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrograms_CellContentClick);
            // 
            // finalProjDBDataSet
            // 
            this.finalProjDBDataSet.DataSetName = "FinalProjDBDataSet";
            this.finalProjDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programsBindingSource
            // 
            this.programsBindingSource.DataMember = "Programs";
            this.programsBindingSource.DataSource = this.finalProjDBDataSet;
            // 
            // programsTableAdapter
            // 
            this.programsTableAdapter.ClearBeforeFill = true;
            // 
            // codeProgramDataGridViewTextBoxColumn
            // 
            this.codeProgramDataGridViewTextBoxColumn.DataPropertyName = "CodeProgram";
            this.codeProgramDataGridViewTextBoxColumn.HeaderText = "CodeProgram";
            this.codeProgramDataGridViewTextBoxColumn.Name = "codeProgramDataGridViewTextBoxColumn";
            // 
            // nameProgramDataGridViewTextBoxColumn
            // 
            this.nameProgramDataGridViewTextBoxColumn.DataPropertyName = "NameProgram";
            this.nameProgramDataGridViewTextBoxColumn.HeaderText = "NameProgram";
            this.nameProgramDataGridViewTextBoxColumn.Name = "nameProgramDataGridViewTextBoxColumn";
            // 
            // course1DataGridViewTextBoxColumn
            // 
            this.course1DataGridViewTextBoxColumn.DataPropertyName = "Course1";
            this.course1DataGridViewTextBoxColumn.HeaderText = "Course1";
            this.course1DataGridViewTextBoxColumn.Name = "course1DataGridViewTextBoxColumn";
            // 
            // course2DataGridViewTextBoxColumn
            // 
            this.course2DataGridViewTextBoxColumn.DataPropertyName = "Course2";
            this.course2DataGridViewTextBoxColumn.HeaderText = "Course2";
            this.course2DataGridViewTextBoxColumn.Name = "course2DataGridViewTextBoxColumn";
            // 
            // course3DataGridViewTextBoxColumn
            // 
            this.course3DataGridViewTextBoxColumn.DataPropertyName = "Course3";
            this.course3DataGridViewTextBoxColumn.HeaderText = "Course3";
            this.course3DataGridViewTextBoxColumn.Name = "course3DataGridViewTextBoxColumn";
            // 
            // course4DataGridViewTextBoxColumn
            // 
            this.course4DataGridViewTextBoxColumn.DataPropertyName = "Course4";
            this.course4DataGridViewTextBoxColumn.HeaderText = "Course4";
            this.course4DataGridViewTextBoxColumn.Name = "course4DataGridViewTextBoxColumn";
            // 
            // course5DataGridViewTextBoxColumn
            // 
            this.course5DataGridViewTextBoxColumn.DataPropertyName = "Course5";
            this.course5DataGridViewTextBoxColumn.HeaderText = "Course5";
            this.course5DataGridViewTextBoxColumn.Name = "course5DataGridViewTextBoxColumn";
            // 
            // ListAllPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 302);
            this.Controls.Add(this.dataGridViewPrograms);
            this.Name = "ListAllPrograms";
            this.Text = "ListAllPrograms";
            this.Load += new System.EventHandler(this.ListAllPrograms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrograms;
        private FinalProjDBDataSet finalProjDBDataSet;
        private System.Windows.Forms.BindingSource programsBindingSource;
        private FinalProjDBDataSetTableAdapters.ProgramsTableAdapter programsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeProgramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProgramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn course1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn course2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn course3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn course4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn course5DataGridViewTextBoxColumn;
    }
}