﻿using System;
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
    public partial class ucMessage : UserControl
    {
        // static value to access and create control
        private static ucMessage _instance;
        public static ucMessage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucMessage();
                }
                return _instance;
            }
        }
        public ucMessage()
        {
            InitializeComponent();
            
        }

       
    }
}
