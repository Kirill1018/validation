namespace Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculation_Click(object sender, EventArgs e)
        {
            if (startDate.Text == "") return;
            if (endDate.Text == "") return;
            if (cost.Text == "") return;
            if (DateTime.Parse(endDate.Text) < DateTime.Parse(startDate
                .Text))
            {
                tipOfDateOfWorkStart.Show("дата начала работ не может быть позже даты окончания работ", startDate);
                return;
            }
            if (DateTime.Parse(endDate.Text) < DateTime.Now
                .Date || DateTime.Parse(startDate.Text) < DateTime.Now
                .Date)
            {
                tipOfDateOfWorkEnd.Show("обе даты должны быть не в прошлом", endDate);
                return;
            }
            if (int.Parse(cost.Text) <= 0)
            {
                tipOfDayCost.Show("цена дня работ не может быть 0 или меньше", cost);
                return;
            }
            int span = (DateTime.Parse(endDate.Text).Date - DateTime
                .Parse(startDate.Text).Date).Days;
            value.Text = (span * int.Parse(cost.Text))
                .ToString();
        }

        private void entrance_Click(object sender, EventArgs e)
        {
            if (mailBox.Text != "kirillfedorov031@yandex.ru") MessageBox.Show("нужно ввести правильный почтовый адрес");
            else MessageBox.Show("валидация прошла успешно");
        }
    }
}