namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar= '*';
        }
        
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin"&& textBox2.Text=="admin123") {
                Form2 yeni = new Form2();
                MessageBox.Show("Login Succesful");
                yeni.Show();
                this.Hide();
            }
            else if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show("Please enter user infos");
            }
            else
            {
                MessageBox.Show("Login Failed");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}