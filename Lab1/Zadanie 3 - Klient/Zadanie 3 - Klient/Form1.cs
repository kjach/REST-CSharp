﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_3___Klient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var klient = new NaszSerwis.Service1Client();
            var zadania = klient.zwrocZadania();
            foreach (var zadanie in zadania)
            {
                label1.Text += zadanie + "\n";
            }
        }
    }
}
