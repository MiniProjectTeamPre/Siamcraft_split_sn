using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siamcraft_split_sn {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if (textBox1.Text.Count() != 13) return;
            if (checkBox2.Checked) {
                textBox2.Text = "000" + textBox1.Text.Substring(7, 6);
                label1.Text = textBox1.Text;
                textBox1.Text = "";
                if (checkBox1.Checked) Clipboard.SetText(textBox2.Text);
                textBox1.Focus();
            } else {
                button1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            textBox2.Text = "000" + textBox1.Text.Substring(7, 6);
            label1.Text = textBox1.Text;
            textBox1.Text = "";
            if(checkBox1.Checked) Clipboard.SetText(textBox2.Text);
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e) {
            textBox1.Focus();
        }
    }
}
