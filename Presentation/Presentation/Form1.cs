using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        int startIndex = 0;
        bool pasteImage = false;
        public Form1()
        {
            InitializeComponent();
        }
        public string Either()
        {
            string result = "";
            int index = startIndex;
            if (pasteImage)
            {
                richTextBox1.Text = "";
                Image img = Image.FromFile("olen.jpg");
                Clipboard.Clear();
                Clipboard.SetImage(img);
                richTextBox1.Paste();
                Clipboard.Clear();
                Image img2 = Image.FromFile("olen.jfif");
                Clipboard.Clear();
                Clipboard.SetImage(img2);
                richTextBox1.Paste();
                Clipboard.Clear();
                return "";
            }
            for (int i = 0; i < 100; i++)
            {
                char current = Info.Text[index];
                while (char.IsLetter(current))
                {
                    result += current;
                    index++;
                    if (index + 1 != Info.Text.Length)
                    {
                        current = Info.Text[index];
                    }
                    else break;
                }
                while (!(char.IsLetter(current)))
                {
                    result += current;
                    if (index + 1 != Info.Text.Length)
                    {
                        index++;
                        current = Info.Text[index];
                    }
                    else
                    {
                        pasteImage = true;
                        break;
                    }
                }
            }
            startIndex = index;
            return result;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SizeSwitch_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void ToTray_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!pasteImage)
                richTextBox1.Text = Either();
            else Either();
        }

        private void settext_Click(object sender, EventArgs e)
        {
            Info.Text = richTextBox2.Text;
            startIndex = 0;
        }
    }
}
