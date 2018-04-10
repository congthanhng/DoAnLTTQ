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
    public partial class ucMessageHeader : UserControl
    {
        // static value to access and create control
        private static ucMessageHeader _instance;
        public static ucMessageHeader Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucMessageHeader();
                }
                return _instance;
            }
        }
        public ucMessageHeader()
        {
            InitializeComponent();
        }
    }
}
