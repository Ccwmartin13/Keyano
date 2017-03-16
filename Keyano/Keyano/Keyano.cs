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

        //A NOTES
            /*Missing mid A flat here
               ...
           */

            //mid A
            if (keyEventArgs.KeyCode == Keys.A && keyEventArgs.Modifiers != Keys.Shift)
            {
                var A = new MediaPlayer();
                //A.Open(new Uri("C:\\Users\\cmart\\Desktop\\Playground\\Keyano\\Keyano\\Keyano\\Keyano Sounds\\piano_middle_A.wav"));
                A.Open(new Uri(@"C:\Users\Kody\Documents\Keyano\Keyano\Keyano\Keyano Sounds\piano_middle_A.wav"));
                A.Play();
            }

            //Mid A#
            if (keyEventArgs.KeyCode == Keys.A && keyEventArgs.Modifiers == Keys.Shift)
            {
                var ASharp = new MediaPlayer();
                //A.Open(new Uri("C:\\Users\\cmart\\Desktop\\Playground\\Keyano\\Keyano\\Keyano\\Keyano Sounds\\piano_middle_A_sharp.wav"));
                ASharp.Open(new Uri(@"C:\Users\Kody\Documents\Keyano\Keyano\Keyano\Keyano Sounds\piano_middle_A_sharp.wav"));
                ASharp.Play();
            }

        //B NOTES
            if (keyEventArgs.KeyCode == Keys.B)
            {
                var B = new MediaPlayer();
                //B.Open(new Uri("C:\\Users\\cmart\\Desktop\\Playground\\Keyano\\Keyano\\Keyano\\Keyano Sounds\\piano_B.wav"));
                B.Open(new Uri(@"C:\Users\Kody\Documents\Keyano\Keyano\Keyano\Keyano Sounds\piano_B.wav"));
                B.Play();

               //stopNoteSound(B);
            }

        //C NOTES
            /*Missing low C flat here
               ...
           */

            //Low C
            if (keyEventArgs.KeyCode == Keys.C && keyEventArgs.Modifiers != Keys.Shift)
            {
                var C = new MediaPlayer();
                //C.Open(new Uri("C:\\Users\\cmart\\Desktop\\Playground\\Keyano\\Keyano\\Keyano\\Keyano Sounds\\piano_middle_C.wav"));
                C.Open(new Uri(@"C:\Users\Kody\Documents\Keyano\Keyano\Keyano\Keyano Sounds\piano_middle_C.wav"));
                C.Play();
            }

            //Low C#
            if (keyEventArgs.KeyCode == Keys.C && keyEventArgs.Modifiers == Keys.Shift)
            {
                var CSharp = new MediaPlayer();
                //CSharp.Open(new Uri("C:\\Users\\cmart\\Desktop\\Playground\\Keyano\\Keyano\\Keyano\\Keyano Sounds\\piano_C_sharp.wav"));
                CSharp.Open(new Uri(@"C:\Users\Kody\Documents\Keyano\Keyano\Keyano\Keyano Sounds\piano_C_sharp.wav"));
                CSharp.Play();
            }
            
        //D NOTES
            /*Missing low D flat here
               ...
           */

            //Low D 
            if (keyEventArgs.KeyCode == Keys.D && keyEventArgs.Modifiers != Keys.Shift)
            {
                var D = new MediaPlayer();
                //D.Open(new Uri("C:\\Users\\cmart\\Desktop\\Playground\\Keyano\\Keyano\\Keyano\\Keyano Sounds\\piano_D.wav"));
                D.Open(new Uri(@"C:\Users\Kody\Documents\Keyano\Keyano\Keyano\Keyano Sounds\piano_D.wav"));
                D.Play();
            }

            //Low DSharp
            if (keyEventArgs.KeyCode == Keys.D && keyEventArgs.Modifiers == Keys.Shift)
            {
                var DSharp = new MediaPlayer();
                //DSharp.Open(new Uri("C:\\Users\\cmart\\Desktop\\Playground\\Keyano\\Keyano\\Keyano\\Keyano Sounds\\piano_D_sharp.wav"));
                DSharp.Open(new Uri(@"C:\Users\Kody\Documents\Keyano\Keyano\Keyano\Keyano Sounds\piano_D_sharp.wav"));
                DSharp.Play();
            }

        //E NOTES

            /*Missing low E flat here
               ...
           */

            //Low E
            if (keyEventArgs.KeyCode == Keys.E && keyEventArgs.Modifiers != Keys.Shift)
            {
                var E = new MediaPlayer();
                //E.Open(new Uri("C:\\Users\\cmart\\Desktop\\Playground\\Keyano\\Keyano\\Keyano\\Keyano Sounds\\piano_E.wav"));
                E.Open(new Uri(@"C:\Users\Kody\Documents\Keyano\Keyano\Keyano\Keyano Sounds\piano_E.wav"));
                E.Play();
            }

            /*Missing low ESharp here
               ...
           */

        //F NOTES
            /*Missing low F flat here
               ...
           */

            //Low F
            if (keyEventArgs.KeyCode == Keys.F && keyEventArgs.Modifiers != Keys.Shift)
            {
                var F = new MediaPlayer();
                //F.Open(new Uri("C:\\Users\\cmart\\Desktop\\Playground\\Keyano\\Keyano\\Keyano\\Keyano Sounds\\piano_F.wav"));
                F.Open(new Uri(@"C:\Users\Kody\Documents\Keyano\Keyano\Keyano\Keyano Sounds\piano_F.wav"));
                F.Play();
            }

            //Low F#
            if (keyEventArgs.KeyCode == Keys.F && keyEventArgs.Modifiers == Keys.Shift)
            {
                var FSharp = new MediaPlayer();
                //FSharp.Open(new Uri("C:\\Users\\cmart\\Desktop\\Playground\\Keyano\\Keyano\\Keyano\\Keyano Sounds\\piano_F_sharp.wav"));
                FSharp.Open(new Uri(@"C:\Users\Kody\Documents\Keyano\Keyano\Keyano\Keyano Sounds\piano_F_sharp.wav"));
                FSharp.Play();
            }

        //G NOTES
            /*Missing mid G flat here
               ...
           */

            //Mid G
            if (keyEventArgs.KeyCode == Keys.G && keyEventArgs.Modifiers != Keys.Shift)
            {
                var MidG = new MediaPlayer();
                //MidG.Open(new Uri("C:\\Users\\cmart\\Desktop\\Playground\\Keyano\\Keyano\\Keyano\\Keyano Sounds\\piano_middle_G.wav"));
                MidG.Open(new Uri(@"C:\Users\Kody\Documents\Keyano\Keyano\Keyano\Keyano Sounds\piano_middle_G.wav"));
                MidG.Play();
            }

            //Mid G#
            if (keyEventArgs.KeyCode == Keys.G && keyEventArgs.Modifiers == Keys.Shift)
            {
                var GSharp = new MediaPlayer();
                //GSharp.Open(new Uri("C:\\Users\\cmart\\Desktop\\Playground\\Keyano\\Keyano\\Keyano\\Keyano Sounds\\piano_G_sharp.wav"));
                GSharp.Open(new Uri(@"C:\Users\Kody\Documents\Keyano\Keyano\Keyano\Keyano Sounds\piano_middle_G_sharp.wav"));
                GSharp.Play();
            }
        }

        private void stopNoteSound(MediaPlayer aNote)
        {
            aNote.Stop();
        }

    }
}
