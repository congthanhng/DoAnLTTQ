using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    class CustomColorUser
    {
        //Custom color happen to user + chatroom 
        public static void UserColorActive(object sender, EventArgs e)
        {
            if(sender is Panel)
            {
                Panel p = (Panel)sender;
                p.BackColor = Color.FromArgb(40, 43, 48);
            }
        }

        public static void UserColorLeave(object sender, EventArgs e)
        {
            if (sender is Panel)
            {
                Panel p = (Panel)sender;
                p.BackColor = Color.FromArgb(26, 30, 41);
            }
        }
    }
}
