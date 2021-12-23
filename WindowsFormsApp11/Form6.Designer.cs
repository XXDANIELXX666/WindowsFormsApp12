namespace WindowsFormsApp11
{
    partial class Form6
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
            this.yPDataSet3 = new WindowsFormsApp11.YPDataSet3();
            this.информационнаяБезопасностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.информационная_безопасностьTableAdapter = new WindowsFormsApp11.YPDataSet3TableAdapters.Информационная_безопасностьTableAdapter();
            this.информационныеСистемыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.информационные_системыTableAdapter = new WindowsFormsApp11.YPDataSet3TableAdapters.Информационные_системыTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.услугаИнформационнойБезопасностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.информационнаяБезопасностьBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Выход = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yPDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информационнаяБезопасностьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информационныеСистемыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информационнаяБезопасностьBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // yPDataSet3
            // 
            this.yPDataSet3.DataSetName = "YPDataSet3";
            this.yPDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // информационнаяБезопасностьBindingSource
            // 
            this.информационнаяБезопасностьBindingSource.DataMember = "Информационная безопасность";
            this.информационнаяБезопасностьBindingSource.DataSource = this.yPDataSet3;
            // 
            // информационная_безопасностьTableAdapter
            // 
            this.информационная_безопасностьTableAdapter.ClearBeforeFill = true;
            // 
            // информационныеСистемыBindingSource
            // 
            this.информационныеСистемыBindingSource.DataMember = "Информационные системы";
            this.информационныеСистемыBindingSource.DataSource = this.yPDataSet3;
            // 
            // информационные_системыTableAdapter
            // 
            this.информационные_системыTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.услугаИнформационнойБезопасностиDataGridViewTextBoxColumn,
            this.ценаУслугиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.информационнаяБезопасностьBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(36, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(715, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // услугаИнформационнойБезопасностиDataGridViewTextBoxColumn
            // 
            this.услугаИнформационнойБезопасностиDataGridViewTextBoxColumn.DataPropertyName = "Услуга Информационной безопасности";
            this.услугаИнформационнойБезопасностиDataGridViewTextBoxColumn.FillWeight = 1000F;
            this.услугаИнформационнойБезопасностиDataGridViewTextBoxColumn.HeaderText = "Услуга Информационной безопасности";
            this.услугаИнформационнойБезопасностиDataGridViewTextBoxColumn.Name = "услугаИнформационнойБезопасностиDataGridViewTextBoxColumn";
            this.услугаИнформационнойБезопасностиDataGridViewTextBoxColumn.Width = 150;
            // 
            // ценаУслугиDataGridViewTextBoxColumn
            // 
            this.ценаУслугиDataGridViewTextBoxColumn.DataPropertyName = "Цена Услуги";
            this.ценаУслугиDataGridViewTextBoxColumn.HeaderText = "Цена Услуги";
            this.ценаУслугиDataGridViewTextBoxColumn.Name = "ценаУслугиDataGridViewTextBoxColumn";
            this.ценаУслугиDataGridViewTextBoxColumn.Width = 89;
            // 
            // информационнаяБезопасностьBindingSource1
            // 
            this.информационнаяБезопасностьBindingSource1.DataMember = "Информационная безопасность";
            this.информационнаяБезопасностьBindingSource1.DataSource = this.yPDataSet3;
            // 
            // Выход
            // 
            this.Выход.BackColor = System.Drawing.Color.Red;
            this.Выход.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Выход.ForeColor = System.Drawing.Color.White;
            this.Выход.Location = new System.Drawing.Point(309, 301);
            this.Выход.Name = "Выход";
            this.Выход.Size = new System.Drawing.Size(157, 39);
            this.Выход.TabIndex = 12;
            this.Выход.Text = "Выход";
            this.Выход.UseVisualStyleBackColor = false;
            this.Выход.Click += new System.EventHandler(this.Выход_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 420);
            this.Controls.Add(this.Выход);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yPDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информационнаяБезопасностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информационныеСистемыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информационнаяБезопасностьBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private YPDataSet3 yPDataSet3;
        private System.Windows.Forms.BindingSource информационнаяБезопасностьBindingSource;
        private YPDataSet3TableAdapters.Информационная_безопасностьTableAdapter информационная_безопасностьTableAdapter;
        private System.Windows.Forms.BindingSource информационныеСистемыBindingSource;
        private YPDataSet3TableAdapters.Информационные_системыTableAdapter информационные_системыTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn услугаИнформационнойБезопасностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаУслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource информационнаяБезопасностьBindingSource1;
        private System.Windows.Forms.Button Выход;
    }
}