using System.Text.RegularExpressions;
using System.Data.SQLite;
using LiveCharts.WinForms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public static List<TextBox> textBoxes = new List<TextBox>();
        public static int breadValue;
        public static int potatoesValue;
        public static int vegetablesValue;
        public static int fruitsValue;
        public static int sugarValue;
        public static int meatValue;
        public static int fishValue;
        public static int milkValue;
        public static int eggsValue;
        public static int oilValue;
        public static int othersValue;
        public static string cityValue;
        public static string dateValue;

        public MainForm()
        {
            InitializeComponent();
            this.calculate.Enabled = false;
            textBoxes.Add(breadForm);
            textBoxes.Add(potatoesForm);
            textBoxes.Add(vegetablesForm);
            textBoxes.Add(fruitsForm);
            textBoxes.Add(sugarForm);
            textBoxes.Add(meatForm);
            textBoxes.Add(fishForm);
            textBoxes.Add(milkForm);
            textBoxes.Add(eggsForm);
            textBoxes.Add(oilForm);
            textBoxes.Add(othersForm);
            foreach(TextBox textBox in textBoxes) // Подписка на проверку ввода
            {
                textBox.TextChanged += TextChanged;
                textBox.TextChanged += buttonDisabledWhileFormsNull1;
            }
            cityForm.TextChanged += buttonDisabledWhileFormsNull1;
            dateTimePicker.ValueChanged += buttonDisabledWhileFormsNull1;
            calculate.Click += calculateClick;
            analyze.Click += analyzeClick;
        }
        public static void TextChanged(object sender, EventArgs args)
        {
            TextBox? tb = sender as TextBox;
            if (tb == null) return;
            var actual = tb.Text;
            var disallowed = @"[^0-9]";
            var newText = Regex.Replace(actual, disallowed, string.Empty);
            if (string.CompareOrdinal(tb.Text, newText) != 0)
            {
                var sstart = tb.SelectionStart;
                tb.Text = newText;
                tb.SelectionStart = sstart - 1;
            }
        }
        private void buttonDisabledWhileFormsNull(object sender, EventArgs e)
        {
            bool ok = !string.IsNullOrWhiteSpace(breadForm.Text) & !string.IsNullOrWhiteSpace(potatoesForm.Text) & !string.IsNullOrWhiteSpace(vegetablesForm.Text) &
                !string.IsNullOrWhiteSpace(fruitsForm.Text) & !string.IsNullOrWhiteSpace(sugarForm.Text) & !string.IsNullOrWhiteSpace(meatForm.Text) &
                !string.IsNullOrWhiteSpace(fishForm.Text) & !string.IsNullOrWhiteSpace(milkForm.Text) & !string.IsNullOrWhiteSpace(eggsForm.Text) &
                !string.IsNullOrWhiteSpace(oilForm.Text) & !string.IsNullOrWhiteSpace(othersForm.Text) & !string.IsNullOrWhiteSpace(cityForm.Text) & 
                (dateTimePicker.Value <= DateTime.Now);
            this.calculate.Enabled = ok;
        }
        private void buttonDisabledWhileFormsNull1(object sender, EventArgs e)
        {
            bool ok = !string.IsNullOrWhiteSpace(breadForm.Text) & !string.IsNullOrWhiteSpace(potatoesForm.Text) & !string.IsNullOrWhiteSpace(vegetablesForm.Text) &
                !string.IsNullOrWhiteSpace(fruitsForm.Text) & !string.IsNullOrWhiteSpace(sugarForm.Text) & !string.IsNullOrWhiteSpace(meatForm.Text) &
                !string.IsNullOrWhiteSpace(fishForm.Text) & !string.IsNullOrWhiteSpace(milkForm.Text) & !string.IsNullOrWhiteSpace(eggsForm.Text) &
                !string.IsNullOrWhiteSpace(oilForm.Text) & !string.IsNullOrWhiteSpace(othersForm.Text);
            this.calculate.Enabled = ok;
        }
        private void analyzeClick(object sender, EventArgs e)
        {
            
            Анализ analysis = new Анализ();
            analysis.Show();
            if (!string.IsNullOrWhiteSpace(breadForm.Text) & !string.IsNullOrWhiteSpace(potatoesForm.Text) & !string.IsNullOrWhiteSpace(vegetablesForm.Text) &
                !string.IsNullOrWhiteSpace(fruitsForm.Text) & !string.IsNullOrWhiteSpace(sugarForm.Text) & !string.IsNullOrWhiteSpace(meatForm.Text) &
                !string.IsNullOrWhiteSpace(fishForm.Text) & !string.IsNullOrWhiteSpace(milkForm.Text) & !string.IsNullOrWhiteSpace(eggsForm.Text) &
                !string.IsNullOrWhiteSpace(oilForm.Text) & !string.IsNullOrWhiteSpace(othersForm.Text) & !string.IsNullOrWhiteSpace(cityForm.Text) &
                (dateTimePicker.Value <= DateTime.Now))
            {
                Анализ.addButton.Enabled = true;
            }
            else
                Анализ.addButton.Enabled = false;
        }
        private void calculateClick(object sender, EventArgs e)
        {
            cityValue = cityForm.Text;
            dateValue = dateTimePicker.Value.ToString().Replace('.', '/');

            breadValue = Convert.ToInt32(breadForm.Text);
            potatoesValue = Convert.ToInt32(potatoesForm.Text);
            vegetablesValue = Convert.ToInt32(vegetablesForm.Text);
            fruitsValue = Convert.ToInt32(fruitsForm.Text);
            sugarValue = Convert.ToInt32(sugarForm.Text);
            meatValue = Convert.ToInt32(meatForm.Text);
            fishValue = Convert.ToInt32(fishForm.Text);
            milkValue = Convert.ToInt32(milkForm.Text);
            eggsValue = Convert.ToInt32(eggsForm.Text);
            oilValue = Convert.ToInt32(oilForm.Text);
            othersValue = Convert.ToInt32(othersForm.Text);
            Calculation calc = new Calculation();
            calc.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void breadForm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}