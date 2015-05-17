using FortuneLib;
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
using FortuneLib.Enums;

namespace FortuneParser
{
    public partial class MainForm : Form
    {
        private List<FortuneItem> _fortuneList = new List<FortuneItem>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "Cookie files (*.*)|*.*",
                Title = "Select cookie file",
                Multiselect = true
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in dlg.FileNames)
                {
                    using (var sr = new StreamReader(item))
                    {
                        var cookieCount = 0;
                        var cookieText = String.Empty;
                        string line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            cookieText += line + Environment.NewLine;

                            if (line.CompareTo("%") == 0)
                            {
                                var cookie = Fortune.ParseFortune(item, cookieText, offCheckBox.Checked);
                                _fortuneList.Add(cookie);
                                cookieCount++;
                                cookieText = String.Empty;
                            }
                        }

                        outputTextBox.Text += "Read " + cookieCount + " from " + item + Environment.NewLine;
                    }
                }
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            FortuneLib.Utils.SerializeList(_fortuneList, "fortunes.bin");
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            _fortuneList = FortuneLib.Utils.DeserializeList<List<FortuneItem>>("fortunes.bin");
        }
    }
}
