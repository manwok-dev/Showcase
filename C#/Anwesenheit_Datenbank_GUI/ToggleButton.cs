using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Anwesenheit
{
    public partial class ToggleButton : Button
    {
        public SQL sql;
        public Attendee attendee;
        public ToggleButton(Attendee a, SQL sql)
        {
            this.sql = sql;
            this.attendee = a;
            this.Name = a.name + "BTN";
            this.Text = a.name;
            if(a.logginTime != null && a.loggoutTime == null)
            {
                BackColor = Color.Green;
            } 
            else
            {
                BackColor = Color.Red;
            }
            InitializeComponent();
        }
        public ToggleButton()
        {
            BackColor = Color.Red;
            InitializeComponent();
        }     

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (BackColor == Color.Green)
            {
                sql.Loggout(attendee);
                BackColor = Color.Red;
            }
            else
            {
                sql.Loggin(attendee);
                BackColor = Color.Green;
            }
        }
    }
}
