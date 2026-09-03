using Npgsql;
using System.Data;
using System.Windows.Forms.VisualStyles;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Anwesenheit
{
    public partial class Form1 : Form
    {
        SQL sql;
        public Form1()
        {
            sql = new SQL("localhost", "postgres", "password", "FIAE_21_Anwesenheit", "Anwesenheit");
            InitializeComponent();
            InitButtons();
        }

        /// <summary>
        /// Initializes ToggleButtons for each Attendee found
        /// </summary>
        private void InitButtons()
        {
            List<Attendee> tmpList = sql.GetAttendees();
            for (int i = 0; i < tmpList.Count; i++)
            {
                ToggleButton tmpButton = new ToggleButton(tmpList[i], sql);
                flowLayoutPanel.Controls.Add(tmpButton);
            }
        }
    }
}