namespace WindowsFormsApp11
{
    partial class Form9
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.услугаМедиаПроектыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.медиаПроектыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yPDataSet3 = new WindowsFormsApp11.YPDataSet3();
            this.Выход = new System.Windows.Forms.Button();
            this.медиа_проектыTableAdapter = new WindowsFormsApp11.YPDataSet3TableAdapters.Медиа_проектыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.медиаПроектыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.услугаМедиаПроектыDataGridViewTextBoxColumn,
            this.ценаУслугиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.медиаПроектыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // услугаМедиаПроектыDataGridViewTextBoxColumn
            // 
            this.услугаМедиаПроектыDataGridViewTextBoxColumn.DataPropertyName = "Услуга Медиа проекты";
            this.услугаМедиаПроектыDataGridViewTextBoxColumn.HeaderText = "Услуга Медиа проекты";
            this.услугаМедиаПроектыDataGridViewTextBoxColumn.Name = "услугаМедиаПроектыDataGridViewTextBoxColumn";
            this.услугаМедиаПроектыDataGridViewTextBoxColumn.Width = 98;
            // 
            // ценаУслугиDataGridViewTextBoxColumn
            // 
            this.ценаУслугиDataGridViewTextBoxColumn.DataPropertyName = "Цена Услуги";
            this.ценаУслугиDataGridViewTextBoxColumn.HeaderText = "Цена Услуги";
            this.ценаУслугиDataGridViewTextBoxColumn.Name = "ценаУслугиDataGridViewTextBoxColumn";
            this.ценаУслугиDataGridViewTextBoxColumn.Width = 89;
            // 
            // медиаПроектыBindingSource
            // 
            this.медиаПроектыBindingSource.DataMember = "Медиа проекты";
            this.медиаПроектыBindingSource.DataSource = this.yPDataSet3;
            // 
            // yPDataSet3
            // 
            this.yPDataSet3.DataSetName = "YPDataSet3";
            this.yPDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Выход
            // 
            this.Выход.BackColor = System.Drawing.Color.Red;
            this.Выход.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Выход.ForeColor = System.Drawing.Color.White;
            this.Выход.Location = new System.Drawing.Point(631, 399);
            this.Выход.Name = "Выход";
            this.Выход.Size = new System.Drawing.Size(157, 39);
            this.Выход.TabIndex = 14;
            this.Выход.Text = "Выход";
            this.Выход.UseVisualStyleBackColor = false;
            this.Выход.Click += new System.EventHandler(this.Выход_Click);
            // 
            // медиа_проектыTableAdapter
            // 
            this.медиа_проектыTableAdapter.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Выход);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.медиаПроектыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Выход;
        private YPDataSet3 yPDataSet3;
        private System.Windows.Forms.BindingSource медиаПроектыBindingSource;
        private YPDataSet3TableAdapters.Медиа_проектыTableAdapter медиа_проектыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn услугаМедиаПроектыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаУслугиDataGridViewTextBoxColumn;
    }
}