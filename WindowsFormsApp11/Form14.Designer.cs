namespace WindowsFormsApp11
{
    partial class Form14
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
            this.yPDataSet4 = new WindowsFormsApp11.YPDataSet4();
            this.записьНаУслугуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запись_на_услугу_TableAdapter = new WindowsFormsApp11.YPDataSet4TableAdapters.Запись_на_услугу_TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yPDataSet5 = new WindowsFormsApp11.YPDataSet5();
            this.записатьНаУслугуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.записать_на_услугу_TableAdapter = new WindowsFormsApp11.YPDataSet5TableAdapters.Записать_на_услугу_TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.записатьНаУслугуBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yPDataSet6 = new WindowsFormsApp11.YPDataSet6();
            this.записатьНаУслугуBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.записать_на_услугу_TableAdapter1 = new WindowsFormsApp11.YPDataSet6TableAdapters.Записать_на_услугу_TableAdapter();
            this.кодЗаписиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.организацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.услугаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yPDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.записьНаУслугуBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.записатьНаУслугуBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.записатьНаУслугуBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.записатьНаУслугуBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // yPDataSet4
            // 
            this.yPDataSet4.DataSetName = "YPDataSet4";
            this.yPDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // записьНаУслугуBindingSource
            // 
            this.записьНаУслугуBindingSource.DataMember = "Запись на услугу ";
            this.записьНаУслугуBindingSource.DataSource = this.yPDataSet4;
            // 
            // запись_на_услугу_TableAdapter
            // 
            this.запись_на_услугу_TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодЗаписиDataGridViewTextBoxColumn,
            this.организацияDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.услугаDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.записатьНаУслугуBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // yPDataSet5
            // 
            this.yPDataSet5.DataSetName = "YPDataSet5";
            this.yPDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // записатьНаУслугуBindingSource
            // 
            this.записатьНаУслугуBindingSource.DataMember = "Записать на услугу(";
            this.записатьНаУслугуBindingSource.DataSource = this.yPDataSet5;
            // 
            // записать_на_услугу_TableAdapter
            // 
            this.записать_на_услугу_TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(140, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Выйти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(257, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(377, 194);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(492, 194);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Код записи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Услуга";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дата";
            // 
            // записатьНаУслугуBindingSource1
            // 
            this.записатьНаУслугуBindingSource1.DataMember = "Записать на услугу(";
            this.записатьНаУслугуBindingSource1.DataSource = this.yPDataSet5;
            // 
            // yPDataSet6
            // 
            this.yPDataSet6.DataSetName = "YPDataSet6";
            this.yPDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // записатьНаУслугуBindingSource2
            // 
            this.записатьНаУслугуBindingSource2.DataMember = "Записать на услугу(";
            this.записатьНаУслугуBindingSource2.DataSource = this.yPDataSet6;
            // 
            // записать_на_услугу_TableAdapter1
            // 
            this.записать_на_услугу_TableAdapter1.ClearBeforeFill = true;
            // 
            // кодЗаписиDataGridViewTextBoxColumn
            // 
            this.кодЗаписиDataGridViewTextBoxColumn.DataPropertyName = "Код записи";
            this.кодЗаписиDataGridViewTextBoxColumn.HeaderText = "Код записи";
            this.кодЗаписиDataGridViewTextBoxColumn.Name = "кодЗаписиDataGridViewTextBoxColumn";
            // 
            // организацияDataGridViewTextBoxColumn
            // 
            this.организацияDataGridViewTextBoxColumn.DataPropertyName = "Организация";
            this.организацияDataGridViewTextBoxColumn.HeaderText = "Организация";
            this.организацияDataGridViewTextBoxColumn.Name = "организацияDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // услугаDataGridViewTextBoxColumn
            // 
            this.услугаDataGridViewTextBoxColumn.DataPropertyName = "Услуга";
            this.услугаDataGridViewTextBoxColumn.HeaderText = "Услуга";
            this.услугаDataGridViewTextBoxColumn.Name = "услугаDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Организация";
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form14";
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yPDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.записьНаУслугуBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.записатьНаУслугуBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.записатьНаУслугуBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.записатьНаУслугуBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private YPDataSet4 yPDataSet4;
        private System.Windows.Forms.BindingSource записьНаУслугуBindingSource;
        private YPDataSet4TableAdapters.Запись_на_услугу_TableAdapter запись_на_услугу_TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YPDataSet5 yPDataSet5;
        private System.Windows.Forms.BindingSource записатьНаУслугуBindingSource;
        private YPDataSet5TableAdapters.Записать_на_услугу_TableAdapter записать_на_услугу_TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource записатьНаУслугуBindingSource1;
        private YPDataSet6 yPDataSet6;
        private System.Windows.Forms.BindingSource записатьНаУслугуBindingSource2;
        private YPDataSet6TableAdapters.Записать_на_услугу_TableAdapter записать_на_услугу_TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЗаписиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn организацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn услугаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}