using System.IO;
namespace G60_ToDo_Liste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkedLBToDos.Items.Add(txtBxInput.Text);
            txtBxInput.Text = "";
        }

        private void checkedLBToDos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            int index = checkedLBToDos.SelectedIndex;
            checkedLBToDos.Items.RemoveAt(index);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
