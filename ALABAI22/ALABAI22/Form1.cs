using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ALABAI22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadComboBoxItems();
        }

        private void LoadComboBoxItems()
        {
            comboBox1.Items.Add("кот");
            comboBox1.Items.Add("ежик");
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedItem = comboBox1.SelectedItem.ToString();

                switch (selectedItem)
                {
                    case "кот":
                        pictureBox1.Image = Image.FromFile(@"\\192.168.3.250\Veda\3 курс\ИСП 33-9, ИСП 34-11\МДК 03.02\меньшатов шаранов\КОТ.jpg");
                        break;
                    case "ежик":
                        pictureBox1.Image = Image.FromFile(@"\\192.168.3.250\Veda\3 курс\ИСП 33-9, ИСП 34-11\МДК 03.02\меньшатов шаранов\ежик.jpg");
                        break;
                    default:
                        pictureBox1.Image = null;
                        break;
                }
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}