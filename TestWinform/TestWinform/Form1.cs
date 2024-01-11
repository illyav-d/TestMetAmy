namespace TestWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Amy amyTwee = new Amy();
        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = amyTwee.ToString();
        }
    }
}
