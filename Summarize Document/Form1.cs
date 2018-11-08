using Newtonsoft.Json;
using OpenTextSummarizer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summarize_Document
{
   public partial class TLDR : Form
    {
        private articleName an;
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

        private string summarizeString(string fullContent)
        {
            var summarizedDocument = OpenTextSummarizer.Summarizer.Summarize(
                new OpenTextSummarizer.DirectTextContentProvider(fullContent),
                new SummarizerArguments()
                {
                    Language = "en",
                    MaxSummarySentences = 10
                });

            var result = string.Empty;
            summarizedDocument.Sentences.ForEach(s => result += s);

           
            return result;
        }

        private void getWikipedia(string article)
        {
            WebClient client = new WebClient();
            var final = string.Empty;

            //replace spaces with %20
            article = article.Replace(" ", "%20");

            using (Stream stream = client.OpenRead($"http://en.wikipedia.org/w/api.php?format=json&action=query&prop=extracts&explaintext=1&titles={article}"))
            using (StreamReader reader = new StreamReader(stream))
            {
                JsonSerializer ser = new JsonSerializer();
                Result result = ser.Deserialize<Result>(new JsonTextReader(reader));

                foreach (Page page in result.query.pages.Values)
                {
                    Console.WriteLine(page.extract);
                    final += page.extract;
                }
            }
            
            final = final.Remove(final.LastIndexOf("== See also =="));
            OLength.Text = Convert.ToString(final.Length);
            string condensed = summarizeString(final);
            resultText.Text = condensed;
            ALength.Text = Convert.ToString(condensed.Length);

           
        }

        private void wikipedia_Click(object sender, EventArgs e)
        {
            an = new articleName();
            an.Show();
            an.FormClosed += An_FormClosed;
        }

        private void An_FormClosed(object sender, FormClosedEventArgs e)
        {
            resultText.Text = an.articlename;
            getWikipedia(an.articlename);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }



    public class Result
    {
        public Query query { get; set; }
    }

    public class Query
    {
        public Dictionary<string, Page> pages { get; set; }
    }

    public class Page
    {
        public string extract { get; set; }
    }
}
