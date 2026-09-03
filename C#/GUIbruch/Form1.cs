namespace GUIbruch
{
    public partial class Form1 : Form
    {
        string sBruch1 = "";
        string sBruch2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBruch1_TextChanged(object sender, EventArgs e)
        {
            sBruch1 = textBruch1.Text;
        }

        private void textBruch2_TextChanged(object sender, EventArgs e)
        {
            sBruch2 = textBruch2.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sErg = Program.DoBruchMath(sBruch1, sBruch2, "+");
            textAusgabe.Text = "Ergebnis: " + sErg;
        }

        private void btnSubtr_Click(object sender, EventArgs e)
        {
            string sErg = Program.DoBruchMath(sBruch1, sBruch2, "-");
            textAusgabe.Text = "Ergebnis: " + sErg;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            string sErg = Program.DoBruchMath(sBruch1, sBruch2, "/");
            textAusgabe.Text = "Ergebnis: " + sErg;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            string sErg = Program.DoBruchMath(sBruch1, sBruch2, "*");
            textAusgabe.Text = "Ergebnis: " + sErg;
        }

        private void textAusgabe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}