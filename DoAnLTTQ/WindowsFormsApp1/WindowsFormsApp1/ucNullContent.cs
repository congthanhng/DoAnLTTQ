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
    public partial class ucNullContent : UserControl
    {
        // static value to access and create control
        private static ucNullContent _instance;
        public static ucNullContent Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucNullContent();
                }
                return _instance;
            }
        }
        public ucNullContent()
        {
            InitializeComponent();
        }
    }
}
