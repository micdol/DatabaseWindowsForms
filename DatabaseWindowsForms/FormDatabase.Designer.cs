namespace DatabaseWindowsForms
{
    partial class FormDatabase
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.listBoxTime = new System.Windows.Forms.ListBox();
            this.listBoxValue = new System.Windows.Forms.ListBox();
            this.listBoxID = new System.Windows.Forms.ListBox();
            this.listBoxComment = new System.Windows.Forms.ListBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.dataGridViewMeasurements = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new DatabaseWindowsForms.DatabaseDataSet();
            this.measurementsTableAdapter = new DatabaseWindowsForms.DatabaseDataSetTableAdapters.MeasurementsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeasurements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(175, 12);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(256, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(337, 12);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(69, 12);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxValue.TabIndex = 1;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(69, 38);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(98, 20);
            this.textBoxComment.TabIndex = 2;
            // 
            // listBoxTime
            // 
            this.listBoxTime.FormattingEnabled = true;
            this.listBoxTime.Location = new System.Drawing.Point(69, 64);
            this.listBoxTime.Name = "listBoxTime";
            this.listBoxTime.Size = new System.Drawing.Size(100, 199);
            this.listBoxTime.TabIndex = 3;
            // 
            // listBoxValue
            // 
            this.listBoxValue.FormattingEnabled = true;
            this.listBoxValue.Location = new System.Drawing.Point(175, 64);
            this.listBoxValue.Name = "listBoxValue";
            this.listBoxValue.Size = new System.Drawing.Size(109, 199);
            this.listBoxValue.TabIndex = 3;
            // 
            // listBoxID
            // 
            this.listBoxID.FormattingEnabled = true;
            this.listBoxID.Location = new System.Drawing.Point(12, 64);
            this.listBoxID.Name = "listBoxID";
            this.listBoxID.Size = new System.Drawing.Size(51, 199);
            this.listBoxID.TabIndex = 3;
            // 
            // listBoxComment
            // 
            this.listBoxComment.FormattingEnabled = true;
            this.listBoxComment.Location = new System.Drawing.Point(290, 64);
            this.listBoxComment.Name = "listBoxComment";
            this.listBoxComment.Size = new System.Drawing.Size(120, 199);
            this.listBoxComment.TabIndex = 3;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(12, 15);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(34, 13);
            this.labelValue.TabIndex = 4;
            this.labelValue.Text = "Value";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(12, 41);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(51, 13);
            this.labelComment.TabIndex = 4;
            this.labelComment.Text = "Comment";
            // 
            // dataGridViewMeasurements
            // 
            this.dataGridViewMeasurements.AutoGenerateColumns = false;
            this.dataGridViewMeasurements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeasurements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridViewMeasurements.DataSource = this.measurementsBindingSource;
            this.dataGridViewMeasurements.Location = new System.Drawing.Point(13, 270);
            this.dataGridViewMeasurements.Name = "dataGridViewMeasurements";
            this.dataGridViewMeasurements.Size = new System.Drawing.Size(662, 148);
            this.dataGridViewMeasurements.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // measurementsBindingSource
            // 
            this.measurementsBindingSource.DataMember = "Measurements";
            this.measurementsBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // measurementsTableAdapter
            // 
            this.measurementsTableAdapter.ClearBeforeFill = true;
            // 
            // FormDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 617);
            this.Controls.Add(this.dataGridViewMeasurements);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.listBoxComment);
            this.Controls.Add(this.listBoxID);
            this.Controls.Add(this.listBoxValue);
            this.Controls.Add(this.listBoxTime);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Name = "FormDatabase";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeasurements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.ListBox listBoxTime;
        private System.Windows.Forms.ListBox listBoxValue;
        private System.Windows.Forms.ListBox listBoxID;
        private System.Windows.Forms.ListBox listBoxComment;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.DataGridView dataGridViewMeasurements;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource measurementsBindingSource;
        private DatabaseDataSetTableAdapters.MeasurementsTableAdapter measurementsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}

