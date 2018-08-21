using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Notatnik
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Lines = File.ReadAllLines(openFileDialog1.FileName);
                Text = "Notatnik - " + Path.GetFileName(openFileDialog1.FileName);
                textBox1.ReadOnly = openFileDialog1.ReadOnlyChecked;
            }
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog1.FileName, textBox1.Lines);
                Text = "Notatnik - " + Path.GetFileName(saveFileDialog1.FileName);
            }
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            fd.Font = textBox1.Font;

            fd.Color = textBox1.BackColor;

            if (fd.ShowDialog() == DialogResult.OK)

            {

                textBox1.Font = fd.Font;

                textBox1.BackColor = fd.Color;

            }
        }

        private void zwijanieWierszyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(zwijanieWierszyToolStripMenuItem.Checked == false)
            {
                zwijanieWierszyToolStripMenuItem.Checked = true;
                textBox1.WordWrap = true;
            }
            else
            {
            
                    zwijanieWierszyToolStripMenuItem.Checked = false;
                    textBox1.WordWrap = false;
            }
        }

    

        private void pasekStanuToolStripMenuItem_Click(object sender, EventArgs e)
        {

           // StatusBar. = "Cols " + textBox1.Text.Length;
        }

        private void oNotatnikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            
            aboutBox.ShowDialog();

        }
    }
    }

