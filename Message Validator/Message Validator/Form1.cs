using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Message_Validator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool stringInFile = ContainsString("words.txt",textBox1.Text);
            if (stringInFile == true && textBox1.TextLength == 6)
            {
                MessageBox.Show("This word is valid");
            }
            else
            {
                MessageBox.Show("this word is invalid Please Try again");
            }
            

        }
        public bool ContainsString(string file,string searchText)
        {
            using (var reader = new StreamReader(file))
            {
                

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (String.Compare(line,searchText,true) == 0)
                    {

                        return true;
                    }
                }
                return false;
            }
        }
    }

}
