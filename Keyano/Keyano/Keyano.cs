﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyano
{
    public partial class Keyano : Form
    {
        public Keyano()
        {
            InitializeComponent();
            KeyDown += AKey;
        }

        private void Keyano_Load(object sender, EventArgs e)
        {
            
        }

        private void AKey(object sender, KeyEventArgs keyEventArgs)
        {
            if (keyEventArgs.KeyCode == Keys.A)
            {
                System.Media.SoundPlayer AKey = new System.Media.SoundPlayer();
                string fileName = "C:\\Users\\cmart\\Desktop\\Playground\\Keyano\\Keyano\\Keyano\\Keyano Sounds\\AKey.wav";
                AKey.SoundLocation = fileName;
                AKey.Load();
                AKey.Play();
            }
            if (keyEventArgs.KeyCode == Keys.G && keyEventArgs.Shift)
            {
                System.Media.SoundPlayer AKey = new System.Media.SoundPlayer();
                string fileName = "C:\\Users\\cmart\\Desktop\\Playground\\Keyano\\Keyano\\Keyano\\Keyano Sounds\\GKey.wav";
                AKey.SoundLocation = fileName;
                AKey.Load();
                AKey.Play();
            }
        }
    }
}
