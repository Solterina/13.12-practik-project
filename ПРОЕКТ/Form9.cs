namespace ПРОЕКТ
{
    public partial class Chupter : Form
    {
        public Chupter()
        {
            InitializeComponent();
        }

        private void btnListName_Click(object sender, EventArgs e)
        {
            var listName = new ListNameForm();

            listName.Show();
        }

        private void btnListFunder_Click(object sender, EventArgs e)
        {
            var listFunder = new ListFunder();

            listFunder.Show();
        }

        private void btnListNameForm_Click(object sender, EventArgs e)
        {
            var listCategory = new ListCategory();

            listCategory.Show();
        }

        private void btnListLog_Click(object sender, EventArgs e)
        {
            var listLog = new ListLog();

            listLog.Show();
        }
    }
}
