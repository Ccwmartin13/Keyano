using System;
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
using System.Windows.Media;

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
                var A = new MediaPlayer();
                A.Open(new Uri("C:\\Users\\cmart\\Desktop\\Playground\\Keyano\\Keyano\\Keyano\\Keyano Sounds\\piano_A.wav"));
                //A.Open(new Uri(@"C:\Users\Kody\Documents\Keyano\Keyano\Keyano\Keyano Sounds\piano_A.wav"));
                A.Play();
            }
            if (keyEventArgs.KeyCode == Keys.G && keyEventArgs.KeyCode == Keys.Shift)
            {
                var GSharp = new MediaPlayer();
                GSharp.Open(new Uri("C:\\Users\\cmart\\Desktop\\Playground\\Keyano\\Keyano\\Keyano\\Keyano Sounds\\piano_G_sharp.wav"));
                //G.Open(new Uri(@"C:\Users\Kody\Documents\Keyano\Keyano\Keyano\Keyano Sounds\piano_G_sharp.wav"));
                GSharp.Play();
            }
            if (keyEventArgs.KeyCode == Keys.G && keyEventArgs.KeyCode != Keys.Shift)
            {
                var G = new MediaPlayer();
                G.Open(new Uri("C:\\Users\\cmart\\Desktop\\Playground\\Keyano\\Keyano\\Keyano\\Keyano Sounds\\piano_G.wav"));
                //G.Open(new Uri(@"C:\Users\Kody\Documents\Keyano\Keyano\Keyano\Keyano Sounds\piano_G.wav"));
                G.Play();
            }
        }
    }
}
