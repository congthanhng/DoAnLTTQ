using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    
    public partial class MainMessenger : Form
    {
        public static int PNLMAINRIGHT_WIDTH = 260;
        public static int PNLMAINTOP_HEIGHT = 49;
        public static int PNLMAINLEFT_WIDTH = 260;
        public static int PNLSEARCH_HEIGHT = 49;

        //Declare current state menu item


        public static UserControl ucInstance;
        public MainMessenger()
        {
            InitializeComponent();
            // set panel
            pnlSearch.Height = 0;
            pnlMainRight.Width = 0;            
            AddUserControl(pnlMainTop, ucMenuHeader.Instance);

        }

        //Add control function
        public static void AddUserControl(Panel panel, UserControl control)
        {                          
                if (!panel.Controls.Contains(control))
                {                    
                    panel.Controls.Add(control);
                    control.Dock = DockStyle.Fill;
                    control.BringToFront();
                }
                else
                {
                    control.BringToFront();
                }          
           
        }
        // Adjust panel main window
        public static void AdjustPanelMain(int top = 49, int right = 260, int left = 260, int search = 49)
        {
            pnlMainTop.Height = top;
            pnlMainLeft.Width = left;
            pnlMainRight.Width = right;
            pnlSearch.Height = search;
        }

        // Handle Header Bar
        private void MainClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainClose_MouseHover(object sender, EventArgs e)
        {
            MainClose.BackColor = Color.Red;
            MainClose.ForeColor = Color.White;
        }

        private void MainClose_MouseLeave(object sender, EventArgs e)
        {            
            MainClose.BackColor = Color.FromArgb(255, 125, 0);
        }

        //Hide or Show pnlMain
       //Handle with MenuItem

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucMenuHeader.lbHeaderName.Text = "HOME";
            AddUserControl(pnlMainTop, ucMenuHeader.Instance);
            AddUserControl(pnlMainMiddle, ucHome.Instance);
            AddUserControl(pnlMainLeftContent, ucNullContent.Instance);

            AdjustPanelMain(PNLMAINTOP_HEIGHT, 0, 0, 0);
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            ucMenuHeader.lbHeaderName.Text = "CONTACT";
            AddUserControl(pnlMainTop, ucMenuHeader.Instance);
            
            AddUserControl(pnlMainLeftContent, ucContact.Instance);
            AddUserControl(pnlMainMiddle, ucNullContent.Instance);

            AdjustPanelMain(PNLMAINTOP_HEIGHT,0);

        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            ucMenuHeader.lbHeaderName.Text = "GROUP";
            AddUserControl(pnlMainTop, ucMenuHeader.Instance);
            
            AddUserControl(pnlMainLeftContent, ucGroup.Instance);
            AddUserControl(pnlMainMiddle, ucNullContent.Instance);
            AdjustPanelMain(PNLMAINTOP_HEIGHT,0);
            
        }
    }
}
