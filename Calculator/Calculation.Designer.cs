namespace Calculator
{
    partial class Calculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculation));
            this.printResultButton = new System.Windows.Forms.Button();
            this.adultsForm = new System.Windows.Forms.TextBox();
            this.childrenForm = new System.Windows.Forms.TextBox();
            this.pensionersForm = new System.Windows.Forms.TextBox();
            this.resultForm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printResultButton
            // 
            this.printResultButton.Location = new System.Drawing.Point(10, 110);
            this.printResultButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printResultButton.Name = "printResultButton";
            this.printResultButton.Size = new System.Drawing.Size(194, 22);
            this.printResultButton.TabIndex = 0;
            this.printResultButton.Text = "Вывести результат";
            this.printResultButton.UseVisualStyleBackColor = true;
            // 
            // adultsForm
            // 
            this.adultsForm.Location = new System.Drawing.Point(172, 9);
            this.adultsForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adultsForm.MaxLength = 3;
            this.adultsForm.Name = "adultsForm";
            this.adultsForm.Size = new System.Drawing.Size(34, 23);
            this.adultsForm.TabIndex = 1;
            // 
            // childrenForm
            // 
            this.childrenForm.Location = new System.Drawing.Point(172, 34);
            this.childrenForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.childrenForm.MaxLength = 3;
            this.childrenForm.Name = "childrenForm";
            this.childrenForm.Size = new System.Drawing.Size(34, 23);
            this.childrenForm.TabIndex = 2;
            // 
            // pensionersForm
            // 
            this.pensionersForm.Location = new System.Drawing.Point(172, 58);
            this.pensionersForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pensionersForm.MaxLength = 3;
            this.pensionersForm.Name = "pensionersForm";
            this.pensionersForm.Size = new System.Drawing.Size(34, 23);
            this.pensionersForm.TabIndex = 3;
            // 
            // resultForm
            // 
            this.resultForm.Location = new System.Drawing.Point(10, 143);
            this.resultForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultForm.Name = "resultForm";
            this.resultForm.ReadOnly = true;
            this.resultForm.Size = new System.Drawing.Size(112, 23);
            this.resultForm.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кол-во взрослых";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кол-во детей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кол-во пенсионеров";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "руб. в месяц";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 170);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultForm);
            this.Controls.Add(this.pensionersForm);
            this.Controls.Add(this.childrenForm);
            this.Controls.Add(this.adultsForm);
            this.Controls.Add(this.printResultButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculation";
            this.Text = "Рассчёт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button printResultButton;
        private TextBox adultsForm;
        private TextBox childrenForm;
        private TextBox pensionersForm;
        private TextBox resultForm;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}