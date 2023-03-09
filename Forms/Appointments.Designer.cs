namespace GPManagementApp
{
    partial class Appointments
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
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button3;
            System.Windows.Forms.Button button4;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appoimentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseGPDataSet = new GPManagementApp.DatabaseGPDataSet();
            this.appoimentsTableAdapter = new GPManagementApp.DatabaseGPDataSetTableAdapters.appoimentsTableAdapter();
            this.idAppoimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddoctorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonappoimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpatientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appoimentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            button1.BackColor = System.Drawing.SystemColors.Control;
            button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.Location = new System.Drawing.Point(11, 456);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(162, 64);
            button1.TabIndex = 2;
            button1.Text = "Book Appointment";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            button2.BackColor = System.Drawing.SystemColors.Control;
            button2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.Location = new System.Drawing.Point(617, 456);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(162, 64);
            button2.TabIndex = 5;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = false;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            button3.BackColor = System.Drawing.SystemColors.Control;
            button3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button3.Location = new System.Drawing.Point(213, 456);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(162, 64);
            button3.TabIndex = 3;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            button4.BackColor = System.Drawing.SystemColors.Control;
            button4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button4.Location = new System.Drawing.Point(415, 456);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(162, 64);
            button4.TabIndex = 4;
            button4.Text = "Search Appointments";
            button4.UseVisualStyleBackColor = false;
            button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.textBox1.Location = new System.Drawing.Point(275, 368);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(484, 30);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Appointment number :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 36);
            this.label3.TabIndex = 28;
            this.label3.Text = "Appointments";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::GPManagementApp.Properties.Resources.icon;
            this.pictureBox2.Image = global::GPManagementApp.Properties.Resources.icon;
            this.pictureBox2.Location = new System.Drawing.Point(18, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAppoimentDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.iddoctorsDataGridViewTextBoxColumn,
            this.reasonappoimentDataGridViewTextBoxColumn,
            this.idpatientsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appoimentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(741, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // appoimentsBindingSource
            // 
            this.appoimentsBindingSource.DataMember = "appoiments";
            this.appoimentsBindingSource.DataSource = this.databaseGPDataSet;
            // 
            // databaseGPDataSet
            // 
            this.databaseGPDataSet.DataSetName = "DatabaseGPDataSet";
            this.databaseGPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appoimentsTableAdapter
            // 
            this.appoimentsTableAdapter.ClearBeforeFill = true;
            // 
            // idAppoimentDataGridViewTextBoxColumn
            // 
            this.idAppoimentDataGridViewTextBoxColumn.DataPropertyName = "IdAppoiment";
            this.idAppoimentDataGridViewTextBoxColumn.HeaderText = "ID Appointment";
            this.idAppoimentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idAppoimentDataGridViewTextBoxColumn.Name = "idAppoimentDataGridViewTextBoxColumn";
            this.idAppoimentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // iddoctorsDataGridViewTextBoxColumn
            // 
            this.iddoctorsDataGridViewTextBoxColumn.DataPropertyName = "Id_doctors";
            this.iddoctorsDataGridViewTextBoxColumn.HeaderText = "ID doctors";
            this.iddoctorsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iddoctorsDataGridViewTextBoxColumn.Name = "iddoctorsDataGridViewTextBoxColumn";
            // 
            // reasonappoimentDataGridViewTextBoxColumn
            // 
            this.reasonappoimentDataGridViewTextBoxColumn.DataPropertyName = "reasonappoiment";
            this.reasonappoimentDataGridViewTextBoxColumn.HeaderText = "Reason Appointment";
            this.reasonappoimentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reasonappoimentDataGridViewTextBoxColumn.Name = "reasonappoimentDataGridViewTextBoxColumn";
            // 
            // idpatientsDataGridViewTextBoxColumn
            // 
            this.idpatientsDataGridViewTextBoxColumn.DataPropertyName = "Id_patients";
            this.idpatientsDataGridViewTextBoxColumn.HeaderText = "ID patients";
            this.idpatientsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpatientsDataGridViewTextBoxColumn.Name = "idpatientsDataGridViewTextBoxColumn";
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::GPManagementApp.Properties.Resources.PngItem_872503;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(790, 585);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Appointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.Appoiment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appoimentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGPDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseGPDataSet databaseGPDataSet;
        private System.Windows.Forms.BindingSource appoimentsBindingSource;
        private DatabaseGPDataSetTableAdapters.appoimentsTableAdapter appoimentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAppoimentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddoctorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonappoimentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpatientsDataGridViewTextBoxColumn;
    }
}