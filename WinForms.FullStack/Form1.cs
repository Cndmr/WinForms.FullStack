namespace WinForms.FullStack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void TiklaBana(object sender, EventArgs e)
        {
            MessageBox.Show("Tikladýn");
            button1.ForeColor=Color.Red;
        }

    }
}