﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchWork
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Genders().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TypeOfApplicants().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MilitaryRegistrations().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
    }
}
