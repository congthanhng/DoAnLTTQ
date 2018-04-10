using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ucHome : UserControl
    {
        // static value to access and create control
        private static ucHome _instance;
        public static ucHome Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucHome();                    
                }
                return _instance;
            }
        }


        public ucHome()
        {
            InitializeComponent();
        }
    }
}
