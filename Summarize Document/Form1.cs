using OpenTextSummarizer;
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

namespace Summarize_Document
{
    public partial class TLDR : Form
    {
        public TLDR()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fileDialog.FileName;

                var summarizedDocument = OpenTextSummarizer.Summarizer.Summarize(
                new OpenTextSummarizer.FileContentProvider(filePath),
                new SummarizerArguments()
                {
                    Language = "en",
                    MaxSummarySentences = 5
                });

                var result = string.Empty;
                summarizedDocument.Sentences.ForEach(s => result += s);

                resultText.Text = result;


                var fileStream = fileDialog.OpenFile();

                using (StreamReader sr = new StreamReader(fileStream))
                {
                    fileContent = sr.ReadToEnd();
                }

            }

            

            //MessageBox.Show(summarizedDocument.Sentences.ToArray(), "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
