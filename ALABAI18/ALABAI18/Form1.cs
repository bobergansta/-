namespace ALABAI18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imagePath = @"\\192.168.3.250\Veda\3 ����\��� 33-9, ��� 34-11\��� 03.02\��������� �������\����.jpg";

            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }
    }
}
