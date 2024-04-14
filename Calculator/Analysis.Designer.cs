namespace Calculator
{
    partial class Анализ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Анализ));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.EnterCity = new System.Windows.Forms.Label();
            this.chartButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 503);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1063, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new System.Drawing.Point(94, 35);
            addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(153, 88);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить введенные значения\r\nв базу данных";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(266, 35);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(165, 88);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Удалить строку из базы данных";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EnterCity
            // 
            this.EnterCity.AutoSize = true;
            this.EnterCity.Location = new System.Drawing.Point(607, 40);
            this.EnterCity.Name = "EnterCity";
            this.EnterCity.Size = new System.Drawing.Size(332, 20);
            this.EnterCity.TabIndex = 3;
            this.EnterCity.Text = "Выберите город для построения графика цен:";
            this.EnterCity.Click += new System.EventHandler(this.label1_Click);
            // 
            // chartButton
            // 
            this.chartButton.Location = new System.Drawing.Point(451, 37);
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(128, 85);
            this.chartButton.TabIndex = 5;
            this.chartButton.Text = "Построить";
            this.chartButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(945, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(945, 84);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(165, 28);
            this.comboBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите продукт для построения графика цен:";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(94, 171);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1063, 299);
            this.cartesianChart1.TabIndex = 9;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // Анализ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 873);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chartButton);
            this.Controls.Add(this.EnterCity);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(addButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Анализ";
            this.Text = "Анализ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        public DataGridView dataGridView1;
        private Button deleteButton;
        private Label EnterCity;
        private Button chartButton;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        public LiveCharts.WinForms.CartesianChart cartesianChart1;
        public static Button addButton;
    }
}