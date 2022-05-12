namespace WHManager
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnAddEmployer_Click(object sender, EventArgs e)
        {
            var formAddEmployer = new EmployerForm();
            formAddEmployer.ShowDialog();
        }

        private void btnOpenMonth_Click(object sender, EventArgs e)
        {
            var formOpenMonth = new OpenMonthForm();
            formOpenMonth.ShowDialog();
        }

        private void btnAddHours_Click(object sender, EventArgs e)
        {
            var formAddHours = new AddHoursForm();
            formAddHours.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var formPrint = new PrintForm();
            formPrint.ShowDialog();
        }
    }
}