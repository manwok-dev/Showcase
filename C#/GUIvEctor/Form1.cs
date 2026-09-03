using System.Security.Cryptography.X509Certificates;
using ViktorMeth;
namespace GUIvEctor


  
{
    public partial class Form1 : Form
    {
        Viktor vik1;
        Viktor vik2;
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(x1inp.Text);
            int y = int.Parse(y1inp.Text);
            int z = int.Parse(z1inp.Text);
            vik1 = new Viktor(x, y, z);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(x2inp.Text);
            int y = int.Parse(y2inp.Text);
            int z = int.Parse(z2inp.Text);
            vik2 = new Viktor(x, y, z);
        }       

        private void vikAdd_Click(object sender, EventArgs e)
        {
            Viktor erg = vik1.Add(vik2);
            outpt.Text = erg.OutputStr();
        }

        private void vikSubtr_Click(object sender, EventArgs e)
        {
            Viktor erg = vik1.Subtr(vik2);
            outpt.Text = erg.OutputStr();
        }

        private void vikCross_Click(object sender, EventArgs e)
        {
            Viktor erg = vik1.Cross(vik2);
            outpt.Text = erg.OutputStr();
        }

        private void vikSkalar_Click(object sender, EventArgs e)
        {
            outpt.Text = "" + vik1.Skalar(vik2);
        }

        private void vikLeng_Click(object sender, EventArgs e)
        {
            double[] erg = vik1.Leng(vik2);
            outpt.Text =  "" + erg[0] + "   \n" + erg[1];
        }

        private void vikAngel_Click(object sender, EventArgs e)
        {
            outpt.Text = "" + vik1.Angel(vik2);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Z1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
