using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PornoHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey current = Registry.CurrentUser;
            RegistryKey open = current.OpenSubKey("Porno");


            try
            {
                Color window = Color.FromName(open.GetValue("window").ToString());
                Color buttonAndText = Color.FromName(open.GetValue("button").ToString());

                tableLayoutPanel1.BackColor = window;

                button1.ForeColor = buttonAndText;
                label1.ForeColor = buttonAndText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Тест на возраст не пройден");
            }
        }
    }
}
