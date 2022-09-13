using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KyrsRab3SemParseJSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        class j
        {
            public int jf { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string json = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileStream = openFileDialog1.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    json = reader.ReadToEnd().Replace(" ","").Replace("\n", "");
                }

            }

            List<string> list = new List<string>();
            
            for (int i = 0; i < json.Length; i++)
            {
                if (json[i].ToString() == "[" ||
                    json[i].ToString() == "]" ||
                    json[i].ToString() == "{" ||
                    json[i].ToString() == "}")
                {
                    list.Add("");
                    list[list.Count - 1] += json[i].ToString();
                    list.Add("");
                }
                else
                {
                    list[list.Count - 1] += json[i].ToString();
                }
            }


            listBox1.Items.Add(json);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
