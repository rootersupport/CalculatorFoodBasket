using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Calculation : Form
    {
        public double generalLivingWage;
        public double adultsLivingWage;
        public double childrenLivingWage;
        public double pensionersLivingWage;

        public static List<int> values = new List<int>();

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

        public static List<TextBox> textBoxes = new List<TextBox>();
        public Calculation()
        {
            InitializeComponent();
            this.printResultButton.Enabled = false;
            textBoxes.Add(pensionersForm);
            textBoxes.Add(adultsForm);
            textBoxes.Add(childrenForm);
            textBoxes.Add(MainForm.breadForm);
            textBoxes.Add(MainForm.potatoesForm);
            textBoxes.Add(MainForm.vegetablesForm);
            textBoxes.Add(MainForm.fruitsForm);
            textBoxes.Add(MainForm.sugarForm);
            textBoxes.Add(MainForm.meatForm);
            textBoxes.Add(MainForm.fishForm);
            textBoxes.Add(MainForm.milkForm);
            textBoxes.Add(MainForm.eggsForm);
            textBoxes.Add(MainForm.oilForm);
            textBoxes.Add(MainForm.othersForm);
            foreach (TextBox textBox in textBoxes) // Подписка на проверку ввода
            {
                textBox.TextChanged += TextChanged;
                textBox.TextChanged += buttonDisabledWhileFormsNull;
            }
            printResultButton.Click += resultButton_click;
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
            bool ok = !string.IsNullOrWhiteSpace(pensionersForm.Text) & !string.IsNullOrWhiteSpace(adultsForm.Text) & !string.IsNullOrWhiteSpace(childrenForm.Text) & !string.IsNullOrWhiteSpace(MainForm.breadForm.Text) & !string.IsNullOrWhiteSpace(MainForm.potatoesForm.Text) & !string.IsNullOrWhiteSpace(MainForm.vegetablesForm.Text) &
                !string.IsNullOrWhiteSpace(MainForm.fruitsForm.Text) & !string.IsNullOrWhiteSpace(MainForm.sugarForm.Text) & !string.IsNullOrWhiteSpace(MainForm.meatForm.Text) &
                !string.IsNullOrWhiteSpace(MainForm.fishForm.Text) & !string.IsNullOrWhiteSpace(MainForm.milkForm.Text) & !string.IsNullOrWhiteSpace(MainForm.eggsForm.Text) &
                !string.IsNullOrWhiteSpace(MainForm.oilForm.Text) & !string.IsNullOrWhiteSpace(MainForm.othersForm.Text) & !string.IsNullOrWhiteSpace(MainForm.cityForm.Text) &
                (MainForm.dateTimePicker.Value <= DateTime.Now); ;
            this.printResultButton.Enabled = ok;
        }
        private void resultButton_click(object sender, EventArgs e)
        {
            int adultsValue = 0; int childrenValue = 0; int pensionersValue = 0;
            adultsValue = Convert.ToInt32(pensionersForm.Text);
            childrenValue = Convert.ToInt32(adultsForm.Text);
            pensionersValue = Convert.ToInt32(childrenForm.Text);
            breadValue = Convert.ToInt32(MainForm.breadForm.Text);
            potatoesValue = Convert.ToInt32(MainForm.potatoesForm.Text);
            vegetablesValue = Convert.ToInt32(MainForm.vegetablesForm.Text);
            fruitsValue = Convert.ToInt32(MainForm.fruitsForm.Text);
            sugarValue = Convert.ToInt32(MainForm.sugarForm.Text);
            meatValue = Convert.ToInt32(MainForm.meatForm.Text);
            fishValue = Convert.ToInt32(MainForm.fishForm.Text);
            milkValue = Convert.ToInt32(MainForm.milkForm.Text);
            eggsValue = Convert.ToInt32(MainForm.eggsForm.Text);
            oilValue = Convert.ToInt32(MainForm.oilForm.Text);
            othersValue = Convert.ToInt32(MainForm.othersForm.Text);
            values.Add(breadValue);
            values.Add(potatoesValue);
            values.Add(vegetablesValue);
            values.Add(fruitsValue);
            values.Add(sugarValue);
            values.Add(meatValue);
            values.Add(fishValue);
            values.Add(milkValue);
            values.Add(eggsValue);
            values.Add(oilValue);
            values.Add(othersValue);
            List<double> adultsConsuption = new List<double>() { 126.5, 100.4, 114.6, 60, 23.8, 58.6, 18.5, 290, 210, 11, 4.9 };
            List<double> childrenConsuption = new List<double>() { 77.6, 88.1, 112.5, 118.1, 21.8, 44, 18.6, 360.7, 201, 5, 3.5 };
            List<double> pensionersConsuption = new List<double>() { 98.2, 80, 98, 45, 21.2, 54, 16, 257.8, 200, 10, 4.2 };
            adultsLivingWage = 0; childrenLivingWage = 0; pensionersLivingWage = 0; generalLivingWage = 0;
            for (int i = 0; i < adultsConsuption.Count; i++)
            {
                adultsConsuption[i] /= 12;
                childrenConsuption[i] /= 12;
                pensionersConsuption[i] /= 12;
            }
            for (int i = 0; i < values.Count; i++)
            {
                adultsLivingWage += adultsConsuption[i] * values[i];
            }
            for (int i = 0; i < values.Count; i++)
            {
                childrenLivingWage += childrenConsuption[i] * values[i];
            }
            for (int i = 0; i < values.Count; i++)
            {
                pensionersLivingWage += pensionersConsuption[i] * values[i];
            }
            generalLivingWage += (adultsValue * adultsLivingWage + childrenValue * childrenLivingWage + pensionersValue * pensionersLivingWage);
            resultForm.Text = Math.Round(generalLivingWage, 1).ToString();
            values.Clear();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
