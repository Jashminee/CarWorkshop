﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia
{
    // okno dodawania nowego typu obiektu oraz nowego typu activity
    public partial class NewTypeAdding : Form
    {
        public NewTypeAdding()
        {
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}