using LiveCharts;
using LiveCharts.Wpf;
using System.Data;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Media;

namespace Calculator
{

    public partial class Анализ : Form
    {
        SQLiteConnection connection = new SQLiteConnection(@"data source=calc.db");
        DataTable dt;
        public double generalLivingWage;
        public double adultsLivingWage;
        public double childrenLivingWage;
        public double pensionersLivingWage;
        public static int adultsValue;
        public static int childrenValue;
        public static int pensionersValue;
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

        public Анализ()
        { 
            InitializeComponent();
            DisplayData();
            this.chartButton.Enabled = false;
            this.deleteButton.Enabled = false;
            dataGridView1.SelectionChanged += deleteButtonDisabledWhileRowNotSelected;
            comboBox1.TextChanged += buttonDisabledWhileCityNotSelected;
            comboBox2.TextChanged += buttonDisabledWhileCityNotSelected;
            deleteButton.Click += deleteButton_Click;
            chartButton.Click += chartButton_Click;
            FillCombobox();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Город";
            dataGridView1.Columns[2].HeaderText = "Дата";
            dataGridView1.Columns[3].HeaderText = "Хлеб";
            dataGridView1.Columns[4].HeaderText = "Картофель";
            dataGridView1.Columns[5].HeaderText = "Овощи";
            dataGridView1.Columns[6].HeaderText = "Фрукты";
            dataGridView1.Columns[7].HeaderText = "Сахар";
            dataGridView1.Columns[8].HeaderText = "Мясо";
            dataGridView1.Columns[9].HeaderText = "Рыба";
            dataGridView1.Columns[10].HeaderText = "Молоко";
            dataGridView1.Columns[11].HeaderText = "Яйца";
            dataGridView1.Columns[12].HeaderText = "Масло";
            dataGridView1.Columns[13].HeaderText = "Другое";
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if(column.HeaderText != "ID" && column.HeaderText != "Город" && column.HeaderText != "Дата")
                comboBox2.Items.Add(column.HeaderText);
            }
            foreach (TextBox textBox in MainForm.textBoxes) // Подписка на проверку ввода
            {
                textBox.TextChanged += TextChanged;
                textBox.TextChanged += buttonDisabledWhileFormsNull;
            }
            MainForm.cityForm.TextChanged += buttonDisabledWhileFormsNull;
            MainForm.dateTimePicker.ValueChanged += buttonDisabledWhileFormsNull;
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
        private void chartButton_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();
            cartesianChart1.Series.Clear();
            DisplayChart();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            cityValue = FirstUpper(MainForm.cityForm.Text);
            dateValue = MainForm.dateTimePicker.Value.ToString().Replace('.', '/');
            dateValue = dateValue.Substring(0, dateValue.Length - 8);
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
            connection.Open();
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = $"INSERT INTO product_table " +
                $"(City, Date, Bread, Potatoes, Vegetables, Fruits, " +
                $"Sugar, Meat, Fish, Milk, Eggs, Oil, Others) " +
                $"VALUES ('{cityValue}', '{dateValue}', {breadValue}, {potatoesValue}, " +
                $"{vegetablesValue}, {fruitsValue}, {sugarValue}, {meatValue}, {fishValue}, " +
                $"{milkValue}, {eggsValue}, {oilValue}, {othersValue})";
            command.ExecuteNonQuery();
            connection.Close();
            dataGridView1.Update();
            dataGridView1.Refresh();
            DisplayData();
            comboBox1.Items.Clear();
            FillCombobox();
            if (dataGridView1.Rows.Count > 0)
            {
                comboBox1.Enabled = true;
            }
        }
        private void DisplayChart()
        {
            string cityToFind = comboBox1.Text;
            string valueToFind = comboBox2.Text;
            ChartValues<string> sortedValues = new ChartValues<string>();
            List<Tuple<string, int>> datesAndValues = new List<Tuple<string, int>>();
            //Dictionary<string, int> datesAndValues = new Dictionary<string, int>();
            ChartValues<int> values = new ChartValues<int>();
            ChartValues<string> dates = new ChartValues<string>();
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>()
            {
                { "Хлеб", 3 },
                { "Картофель", 4 },
                { "Овощи", 5 },
                { "Фрукты", 6},
                { "Сахар", 7 },
                { "Мясо", 8 },
                { "Рыба", 9 },
                { "Молоко", 10 },
                { "Яйца", 11 },
                { "Масло", 12 },
                { "Другое", 13 }
            };
            int cellToFind;
            bool isFound = keyValuePairs.TryGetValue(comboBox2.Text, out cellToFind);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells[1].Value.ToString() == cityToFind)
                {
                    datesAndValues.Add(new Tuple<string, int>((string)row.Cells[2].Value, (int)Convert.ToInt64(row.Cells[cellToFind].Value)));
                }
            }
            Func<string, DateTime> cond = delegate (string date)
            {
                int day = Convert.ToInt32(date.Substring(0, 2));
                int month = Convert.ToInt32(date.Substring(3, 2));
                int year = Convert.ToInt32(date.Substring(6, 4));
                return new DateTime(year, month, day);
            };
            var sorted = datesAndValues.OrderBy(x => cond(x.Item1));
            foreach(var element in sorted)
            {
                dates.Add(element.Item1);
                values.Add(element.Item2);
            }
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = values,
                DataLabels = true

            });
            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = dates,
                Separator = new Separator
                {
                    StrokeDashArray = new DoubleCollection(10)
                }
            }) ;
            cartesianChart1.AxisY.Add(new Axis
            {
                Separator = new Separator
                {
                    StrokeDashArray = new DoubleCollection(4)
                }
            });
        }
        private void DisplayData()
        {
            string query = "SELECT* from product_table";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FillCombobox()
        {
            List<string> cities = new List<string>();
            connection.Open();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string city = row.Cells[1].Value.ToString();
                cities.Add(city);
            }
            cities = cities.Distinct().ToList();
            foreach (string city in cities)
            {
                comboBox1.Items.Add(city);
            }
            if (dataGridView1.Rows.Count == 0)
            {
                comboBox1.Text = "";
                comboBox1.Enabled = false;
            }
            connection.Close();
        }
        
        private void deleteButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    SQLiteCommand command = new SQLiteCommand($"DELETE FROM product_table WHERE ID = {id}", connection);
                    int result = command.ExecuteNonQuery();
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
            }
            connection.Close();
            dataGridView1.Update();
            dataGridView1.Refresh();
            comboBox1.Items.Clear();
            FillCombobox();
            
        }
        private void deleteButtonDisabledWhileRowNotSelected(object sender, EventArgs e)
        {
            this.deleteButton.Enabled = dataGridView1.SelectedRows.Count != 0;
        }
        public static string FirstUpper(string str)
        {
            string[] s = str.Split(' ');

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > 1)
                    s[i] = s[i].Substring(0, 1).ToUpper() + s[i].Substring(1, s[i].Length - 1).ToLower();
                else s[i] = s[i].ToUpper();
            }
            return string.Join(" ", s);
        }
        private void buttonDisabledWhileFormsNull(object sender, EventArgs e)
        {
            bool ok = !string.IsNullOrWhiteSpace(MainForm.breadForm.Text) & !string.IsNullOrWhiteSpace(MainForm.potatoesForm.Text) & !string.IsNullOrWhiteSpace(MainForm.vegetablesForm.Text) &
                !string.IsNullOrWhiteSpace(MainForm.fruitsForm.Text) & !string.IsNullOrWhiteSpace(MainForm.sugarForm.Text) & !string.IsNullOrWhiteSpace(MainForm.meatForm.Text) &
                !string.IsNullOrWhiteSpace(MainForm.fishForm.Text) & !string.IsNullOrWhiteSpace(MainForm.milkForm.Text) & !string.IsNullOrWhiteSpace(MainForm.eggsForm.Text) &
                !string.IsNullOrWhiteSpace(MainForm.oilForm.Text) & !string.IsNullOrWhiteSpace(MainForm.othersForm.Text) & !string.IsNullOrWhiteSpace(MainForm.cityForm.Text) &
                (MainForm.dateTimePicker.Value <= DateTime.Now);
            addButton.Enabled = ok;
        }
        private void buttonDisabledWhileCityNotSelected(object sender, EventArgs e)
        {
            chartButton.Enabled = comboBox1.Text != "" && comboBox2.Text != "";
        }
    }

}
