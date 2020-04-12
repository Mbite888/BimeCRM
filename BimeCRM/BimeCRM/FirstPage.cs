using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BimeCRM
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileRW file = new FileRW("DB_Address.MEG");
            if (file.ReadFile() != "" & file.Exist())
            {
                AccessDatabase db = new AccessDatabase(file.ReadFile());
                if (db.Exist())
                {
                    MainPage form = new MainPage();
                    form.ShowDialog();
                    this.Close();

                }
            }

        }

        private void browseBt_Click(object sender, EventArgs e)
        {
            OpenFileDialog browser = new OpenFileDialog();
            browser.Filter = "Sqlite files (*.db)|*.db|All files (*.*)|*.*";
            browser.Multiselect = false;
            browser.FilterIndex = 1;
            browser.Title = "Browse Database File";
            if (browser.ShowDialog() == DialogResult.OK)
            {
                AddressTx.Text = browser.FileName;
            }
            
        }

        private void nextBt_Click(object sender, EventArgs e)
        {
            AccessDatabase access = new AccessDatabase(AddressTx.Text);
            if (access.Exist())
            {
                FileRW fileRw =new FileRW("DB_Address.MEG");
                fileRw.WriteOnFile(AddressTx.Text);
                MainPage form = new MainPage();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                WrongAddressLb.Visible = true;
            }
        }

        private void AddressTx_TextChanged(object sender, EventArgs e)
        {
            WrongAddressLb.Visible = false;
        }
    }
}
