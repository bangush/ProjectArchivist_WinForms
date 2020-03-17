﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ProjectArchivist
{
    public partial class GeneralMessageForm : Form
    {
        public GeneralMessageForm(string text)
        {
            InitializeComponent();
            Label_Status.Text = text;
            SoundPlayer sound = new SoundPlayer("sounds\\gabrielaraujo_powerup-success.wav");
            sound.Play();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
