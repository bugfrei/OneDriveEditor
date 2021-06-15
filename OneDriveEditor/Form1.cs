using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneDriveEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Focus();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            if (txtFilename.Text == "export.rtf")
            {
                txtFilename.Text = "export.txt";
            }
            else
            {
                txtFilename.Text = "export.rtf";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                System.IO.File.WriteAllText("O:\\" + txtFilename.Text, rtbText.Rtf);
                txtFilename.BackColor = Color.LightGreen;
            }
            catch (Exception ex)
            {
                txtFilename.BackColor = Color.Red;
            }
        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {
            txtFilename.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SwitchStyle(FontStyle.Bold);
        }

        private void SwitchStyle(FontStyle style)
        {
            FontStyle fs = rtbText.SelectionFont.Style;

            fs = fs ^ style;

            Font f = new Font(rtbText.SelectionFont, fs);
            rtbText.SelectionFont = f;
            rtbText.Focus();
        }

        private void SetFont(string font, int size)
        {
            Font f = new Font(font, size);
            rtbText.SelectionFont = f;
            rtbText.Focus();
        }

        private void SetColor(Color color)
        {
            rtbText.SelectionColor = color;
            rtbText.Focus();
        }

        private void SetBColor(Color color)
        {
            rtbText.SelectionBackColor = color;
            rtbText.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SwitchStyle(FontStyle.Italic);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SwitchStyle(FontStyle.Underline);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SwitchStyle(FontStyle.Strikeout);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = rtbText.SelectionFont;
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                rtbText.SelectionFont = fontDialog1.Font;
            }
            rtbText.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetFont("Calibri", 11);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetFont("Courier New", 11);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Color c = rtbText.SelectionColor;
            colorDialog1.Color = c;
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                SetColor(colorDialog1.Color);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetColor(Color.Black);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SetColor(Color.Red);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Color c = rtbText.SelectionColor;
            colorDialog1.Color = c;
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                SetBColor(colorDialog1.Color);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SetBColor(Color.White);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SetBColor(Color.Yellow);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Focus();
            timer1.Enabled = false;
        }
    }
}
