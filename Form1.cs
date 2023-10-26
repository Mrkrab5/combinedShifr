namespace combinedShifr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            itogEncrypt.Text = ADFGVX.Decoding(entryMassenge.Text, dopYsl.Text);
        }
    }
}