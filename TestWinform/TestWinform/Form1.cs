namespace TestWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Amy amy = new Amy();
        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = amy.ToString();
        }
    }
}
