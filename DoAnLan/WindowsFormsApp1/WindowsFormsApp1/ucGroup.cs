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
    public partial class ucGroup : UserControl
    {
        // static value to access and create control
        private static ucGroup _instance;
        public static ucGroup Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucGroup();
                }
                return _instance;
            }
        }
        public ucGroup()
        {
            InitializeComponent();
        }
    }
}
