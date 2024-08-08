namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b, c;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textnum1.Text);
            b = Convert.ToInt32(textnum2.Text);
            c = a + b;
            textresult.Text = Convert.ToString(c);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textnum1.Text);
            b = Convert.ToInt32(textnum2.Text);
            c = a - b;
            textresult.Text = Convert.ToString(c);
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textnum1.Text);
            b = Convert.ToInt32(textnum2.Text);
            c = a * b;
            textresult.Text = Convert.ToString(c);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textnum1.Text);
            b = Convert.ToInt32(textnum2.Text);
            c = a / b;
            textresult.Text = Convert.ToString(c);
        }
    }
}