namespace Calculator
{
    public partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            cityForm = new System.Windows.Forms.TextBox();
            city = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            breadForm = new System.Windows.Forms.TextBox();
            potatoesForm = new System.Windows.Forms.TextBox();
            vegetablesForm = new System.Windows.Forms.TextBox();
            fruitsForm = new System.Windows.Forms.TextBox();
            sugarForm = new System.Windows.Forms.TextBox();
            meatForm = new System.Windows.Forms.TextBox();
            fishForm = new System.Windows.Forms.TextBox();
            milkForm = new System.Windows.Forms.TextBox();
            eggsForm = new System.Windows.Forms.TextBox();
            oilForm = new System.Windows.Forms.TextBox();
            othersForm = new System.Windows.Forms.TextBox();
            dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bread = new System.Windows.Forms.Label();
            this.potatoes = new System.Windows.Forms.Label();
            this.fruits = new System.Windows.Forms.Label();
            this.vegetables = new System.Windows.Forms.Label();
            this.sugar = new System.Windows.Forms.Label();
            this.meat = new System.Windows.Forms.Label();
            this.fish = new System.Windows.Forms.Label();
            this.milk = new System.Windows.Forms.Label();
            this.eggs = new System.Windows.Forms.Label();
            this.oil = new System.Windows.Forms.Label();
            this.other = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.analyze = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityForm
            // 
            cityForm.Location = new System.Drawing.Point(81, 33);
            cityForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cityForm.MaxLength = 32;
            cityForm.Name = "cityForm";
            cityForm.Size = new System.Drawing.Size(159, 27);
            cityForm.TabIndex = 0;
            cityForm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(23, 37);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(54, 20);
            this.city.TabIndex = 2;
            this.city.Text = "Город:";
            this.city.Click += new System.EventHandler(this.label1_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(25, 85);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(44, 20);
            this.date.TabIndex = 3;
            this.date.Text = "Дата:";
            this.date.Click += new System.EventHandler(this.label2_Click);
            // 
            // breadForm
            // 
            breadForm.Location = new System.Drawing.Point(240, 151);
            breadForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            breadForm.MaxLength = 4;
            breadForm.Name = "breadForm";
            breadForm.Size = new System.Drawing.Size(114, 27);
            breadForm.TabIndex = 5;
            breadForm.TextChanged += new System.EventHandler(this.breadForm_TextChanged);
            // 
            // potatoesForm
            // 
            potatoesForm.Location = new System.Drawing.Point(240, 189);
            potatoesForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            potatoesForm.MaxLength = 4;
            potatoesForm.Name = "potatoesForm";
            potatoesForm.Size = new System.Drawing.Size(114, 27);
            potatoesForm.TabIndex = 6;
            // 
            // vegetablesForm
            // 
            vegetablesForm.Location = new System.Drawing.Point(240, 228);
            vegetablesForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            vegetablesForm.MaxLength = 4;
            vegetablesForm.Name = "vegetablesForm";
            vegetablesForm.Size = new System.Drawing.Size(114, 27);
            vegetablesForm.TabIndex = 7;
            // 
            // fruitsForm
            // 
            fruitsForm.Location = new System.Drawing.Point(240, 267);
            fruitsForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fruitsForm.MaxLength = 4;
            fruitsForm.Name = "fruitsForm";
            fruitsForm.Size = new System.Drawing.Size(114, 27);
            fruitsForm.TabIndex = 8;
            // 
            // sugarForm
            // 
            sugarForm.Location = new System.Drawing.Point(240, 305);
            sugarForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            sugarForm.MaxLength = 4;
            sugarForm.Name = "sugarForm";
            sugarForm.Size = new System.Drawing.Size(114, 27);
            sugarForm.TabIndex = 9;
            // 
            // meatForm
            // 
            meatForm.Location = new System.Drawing.Point(240, 344);
            meatForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            meatForm.MaxLength = 4;
            meatForm.Name = "meatForm";
            meatForm.Size = new System.Drawing.Size(114, 27);
            meatForm.TabIndex = 10;
            // 
            // fishForm
            // 
            fishForm.Location = new System.Drawing.Point(240, 383);
            fishForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fishForm.MaxLength = 4;
            fishForm.Name = "fishForm";
            fishForm.Size = new System.Drawing.Size(114, 27);
            fishForm.TabIndex = 11;
            // 
            // milkForm
            // 
            milkForm.Location = new System.Drawing.Point(240, 421);
            milkForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            milkForm.MaxLength = 4;
            milkForm.Name = "milkForm";
            milkForm.Size = new System.Drawing.Size(114, 27);
            milkForm.TabIndex = 12;
            // 
            // eggsForm
            // 
            eggsForm.Location = new System.Drawing.Point(240, 460);
            eggsForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            eggsForm.MaxLength = 4;
            eggsForm.Name = "eggsForm";
            eggsForm.Size = new System.Drawing.Size(114, 27);
            eggsForm.TabIndex = 13;
            // 
            // oilForm
            // 
            oilForm.Location = new System.Drawing.Point(240, 499);
            oilForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            oilForm.MaxLength = 4;
            oilForm.Name = "oilForm";
            oilForm.Size = new System.Drawing.Size(114, 27);
            oilForm.TabIndex = 14;
            // 
            // othersForm
            // 
            othersForm.Location = new System.Drawing.Point(240, 537);
            othersForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            othersForm.MaxLength = 4;
            othersForm.Name = "othersForm";
            othersForm.Size = new System.Drawing.Size(114, 27);
            othersForm.TabIndex = 15;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new System.Drawing.Point(81, 77);
            dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new System.Drawing.Size(159, 27);
            dateTimePicker.TabIndex = 17;
            dateTimePicker.Value = new System.DateTime(2022, 6, 11, 1, 25, 7, 0);
            dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // bread
            // 
            this.bread.AutoSize = true;
            this.bread.Location = new System.Drawing.Point(23, 151);
            this.bread.Name = "bread";
            this.bread.Size = new System.Drawing.Size(141, 20);
            this.bread.TabIndex = 18;
            this.bread.Text = "Хлебные продукты";
            this.bread.Click += new System.EventHandler(this.label3_Click);
            // 
            // potatoes
            // 
            this.potatoes.AutoSize = true;
            this.potatoes.Location = new System.Drawing.Point(23, 189);
            this.potatoes.Name = "potatoes";
            this.potatoes.Size = new System.Drawing.Size(84, 20);
            this.potatoes.TabIndex = 19;
            this.potatoes.Text = "Картофель";
            this.potatoes.Click += new System.EventHandler(this.label4_Click);
            // 
            // fruits
            // 
            this.fruits.AutoSize = true;
            this.fruits.Location = new System.Drawing.Point(23, 228);
            this.fruits.Name = "fruits";
            this.fruits.Size = new System.Drawing.Size(142, 20);
            this.fruits.TabIndex = 20;
            this.fruits.Text = "Овощи и бахчевые";
            // 
            // vegetables
            // 
            this.vegetables.AutoSize = true;
            this.vegetables.Location = new System.Drawing.Point(23, 267);
            this.vegetables.Name = "vegetables";
            this.vegetables.Size = new System.Drawing.Size(115, 20);
            this.vegetables.TabIndex = 21;
            this.vegetables.Text = "Фрукты свежие";
            // 
            // sugar
            // 
            this.sugar.AutoSize = true;
            this.sugar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sugar.Location = new System.Drawing.Point(23, 305);
            this.sugar.Name = "sugar";
            this.sugar.Size = new System.Drawing.Size(205, 19);
            this.sugar.TabIndex = 22;
            this.sugar.Text = "Сахар и кондитерские изделия";
            // 
            // meat
            // 
            this.meat.AutoSize = true;
            this.meat.Location = new System.Drawing.Point(23, 344);
            this.meat.Name = "meat";
            this.meat.Size = new System.Drawing.Size(112, 20);
            this.meat.TabIndex = 23;
            this.meat.Text = "Мясопродукты";
            // 
            // fish
            // 
            this.fish.AutoSize = true;
            this.fish.Location = new System.Drawing.Point(23, 383);
            this.fish.Name = "fish";
            this.fish.Size = new System.Drawing.Size(112, 20);
            this.fish.TabIndex = 24;
            this.fish.Text = "Рыбопродукты";
            // 
            // milk
            // 
            this.milk.AutoSize = true;
            this.milk.Location = new System.Drawing.Point(23, 421);
            this.milk.Name = "milk";
            this.milk.Size = new System.Drawing.Size(200, 20);
            this.milk.TabIndex = 25;
            this.milk.Text = "Молоко и молокопродукты";
            // 
            // eggs
            // 
            this.eggs.AutoSize = true;
            this.eggs.Location = new System.Drawing.Point(23, 460);
            this.eggs.Name = "eggs";
            this.eggs.Size = new System.Drawing.Size(44, 20);
            this.eggs.TabIndex = 26;
            this.eggs.Text = "Яйца";
            // 
            // oil
            // 
            this.oil.AutoSize = true;
            this.oil.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oil.Location = new System.Drawing.Point(23, 499);
            this.oil.Name = "oil";
            this.oil.Size = new System.Drawing.Size(207, 19);
            this.oil.TabIndex = 27;
            this.oil.Text = "Масло растительное, маргарин";
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.Location = new System.Drawing.Point(23, 537);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(141, 40);
            this.other.TabIndex = 28;
            this.other.Text = "Прочие продукты\r\n(соль, чай, специи)\r\n";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(371, 537);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 20);
            this.label16.TabIndex = 40;
            this.label16.Text = "руб. за кг";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(371, 499);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 20);
            this.label17.TabIndex = 39;
            this.label17.Text = "руб. за кг";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(371, 460);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 20);
            this.label18.TabIndex = 38;
            this.label18.Text = "руб. за шт.";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(371, 421);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 20);
            this.label19.TabIndex = 37;
            this.label19.Text = "руб. за кг";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(371, 383);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 20);
            this.label20.TabIndex = 36;
            this.label20.Text = "руб. за кг";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(371, 344);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 20);
            this.label21.TabIndex = 35;
            this.label21.Text = "руб. за кг";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(371, 305);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 20);
            this.label22.TabIndex = 34;
            this.label22.Text = "руб. за кг";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(371, 267);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 20);
            this.label23.TabIndex = 33;
            this.label23.Text = "руб. за кг";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(371, 228);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 20);
            this.label24.TabIndex = 32;
            this.label24.Text = "руб. за кг";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(371, 189);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 20);
            this.label25.TabIndex = 31;
            this.label25.Text = "руб. за кг";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(371, 155);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 20);
            this.label26.TabIndex = 30;
            this.label26.Text = "руб. за кг";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(251, 26);
            this.calculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(201, 40);
            this.calculate.TabIndex = 50;
            this.calculate.Text = "Рассчитать";
            this.calculate.UseVisualStyleBackColor = true;
            // 
            // analyze
            // 
            this.analyze.Location = new System.Drawing.Point(251, 72);
            this.analyze.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.analyze.Name = "analyze";
            this.analyze.Size = new System.Drawing.Size(201, 40);
            this.analyze.TabIndex = 51;
            this.analyze.Text = "Анализ";
            this.analyze.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 588);
            this.Controls.Add(this.analyze);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.other);
            this.Controls.Add(this.oil);
            this.Controls.Add(this.eggs);
            this.Controls.Add(this.milk);
            this.Controls.Add(this.fish);
            this.Controls.Add(this.meat);
            this.Controls.Add(this.sugar);
            this.Controls.Add(this.vegetables);
            this.Controls.Add(this.fruits);
            this.Controls.Add(this.potatoes);
            this.Controls.Add(this.bread);
            this.Controls.Add(dateTimePicker);
            this.Controls.Add(othersForm);
            this.Controls.Add(oilForm);
            this.Controls.Add(eggsForm);
            this.Controls.Add(milkForm);
            this.Controls.Add(fishForm);
            this.Controls.Add(meatForm);
            this.Controls.Add(sugarForm);
            this.Controls.Add(fruitsForm);
            this.Controls.Add(vegetablesForm);
            this.Controls.Add(potatoesForm);
            this.Controls.Add(breadForm);
            this.Controls.Add(this.date);
            this.Controls.Add(this.city);
            this.Controls.Add(cityForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Калькулятор потребительской корзины";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Label city;
        public Label date;
        public Label bread;
        public Label potatoes;
        public Label fruits;
        public Label vegetables;
        public Label sugar;
        public Label meat;
        public Label fish;
        public Label milk;
        public Label eggs;
        public Label oil;
        public Label other;
        public Label label16;
        public Label label17;
        public Label label18;
        public Label label19;
        public Label label20;
        public Label label21;
        public Label label22;
        public Label label23;
        public Label label24;
        public Label label25;
        public Label label26;
        public Button calculate;
        public Button analyze;
        public static TextBox cityForm;
        public static TextBox breadForm;
        public static TextBox potatoesForm;
        public static TextBox vegetablesForm;
        public static TextBox fruitsForm;
        public static TextBox sugarForm;
        public static TextBox meatForm;
        public static TextBox fishForm;
        public static TextBox milkForm;
        public static TextBox eggsForm;
        public static TextBox oilForm;
        public static TextBox othersForm;
        public static DateTimePicker dateTimePicker;
    }
}