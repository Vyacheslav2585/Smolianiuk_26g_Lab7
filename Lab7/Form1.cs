using System.Data;
namespace Lab7
{
    public partial class Lab7 : Form
    {
        double x;
        double y;
        double z;
        double x1;
        double x2;
        public Lab7()
        {
            InitializeComponent();
        }
        private bool InputDouble(ref double value, string message, double value1)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(message, "Введення значення");
            if (input == "")
            {
                // Якщо користувач не ввів жодного значення, присвоїти значення за замовчуванням
                value = value1;
                return true;
            }
            if (!double.TryParse(input, out value))
            {
                MessageBox.Show("Введіть коректне числове значення.");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x = 12.743;
            double y = 0.654;
            double z = 0.0208;
            if (!InputDouble(ref x, "Введіть значення х", this.x))
                return;
            if (!InputDouble(ref y, "Введіть значення y", this.y))
                return;
            if (!InputDouble(ref z, "Введіть значення z", this.z))
                return;
            double result = (x * y - 4 * z) / (x + 4 * y);

            MessageBox.Show($"x = {x}\ny = {y}\nz = {z}\nРезультат = {result}");
            this.x = x;
            this.y = y;
            this.z = z;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double x1 = 0;
            if (!InputDouble(ref x1, "Введіть значення x", this.x1))
                return;
            this.x1 = x1;
            double y;
            if (x1 > 0 && x1 <= 12)
            {
                y = 2 * x1 * x1 * x1 * Math.Sqrt(x1 * x1 + 5);
            }
            else if (x1 > 12)
            {
                y = x1;
            }
            else
            {
                y = Math.Atan(x1);
            }
            MessageBox.Show($"x = {x1}\nЗначення функції = {y}");
        }
        private void button2_Click(object sender, EventArgs e)
        {

            double x2 = 0;
            if (!InputDouble(ref x2, "Введіть значення x", this.x2))
                return;
            const double deltaX = 0.2;
            const int n = 7;
            this.x2 = x2;
            DataTable table = new DataTable();
            table.Columns.Add("x");
            table.Columns.Add("y");
            for (int i = 0; i < n; i++)
            {
                double xi = x2 + i * deltaX;
                double yi = (xi + Math.Cos(2 * xi)) / (3 * xi);
                table.Rows.Add(xi, yi);
            }
            string result = "";
            foreach (DataRow row in table.Rows)
            {
                result += $"{row["x"]}\t{row["y"]}\n";
            }
            MessageBox.Show(result);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lab7_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}