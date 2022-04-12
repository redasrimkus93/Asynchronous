using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asynchronous
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sync_Click(object sender, EventArgs e)
        {
            RunDownloadSync();

        }

        private void RunDownloadSync()
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();
            List<string> webUrls =  PrepareData();
            foreach (var url in webUrls)
            {
                var html = DownloadWebHtml(url);
                AppendWebDataToTextBox(url, html);
            }
            stopwatch.Stop();
            webInfo.Text += $"Elapsed time is {stopwatch.ElapsedMilliseconds}";
        }

        private async Task RunDownloadAsync()
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();
            List<string> webUrls = PrepareData();
            List<Task<string>> downloadTasks = new();
            foreach (var url in webUrls)
            {
                var htmlTask = DownloadWebHtmlAsync(url);
                downloadTasks.Add(htmlTask);
                //AppendWebDataToTextBox(url, htmlTask);
            }

            var websData = await Task.WhenAll(downloadTasks);

            foreach (var item in websData)
            {
                AppendWebDataToTextBox(item, item);
            }



            stopwatch.Stop();
            webInfo.Text += $"Elapsed time is {stopwatch.ElapsedMilliseconds}";
        }

        private void AppendWebDataToTextBox(string webName, string html)
        {
            webInfo.Text += $"Web has html length of {html.Length} {Environment.NewLine}";
        }

        private string DownloadWebHtml(string url)
        {
            WebClient webClient = new WebClient();
            var html = webClient.DownloadString(url);
            return html;
        }

        private async Task<string> DownloadWebHtmlAsync(string url)
        {
            WebClient webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            return html;
        }

        private List<string> PrepareData()
        {
            webInfo.Text = "";
            List<string> webUrls = new();
            webUrls.Add("https://www.microsoft.com/lt-lt");
            webUrls.Add("https://docs.microsoft.com/en-us/learn/");
            webUrls.Add("https://dotnet.microsoft.com/en-us/");
            return webUrls;
        }

        private async void asyncButton_Click(object sender, EventArgs e)
        {
            await RunDownloadAsync();
        }
    }
}
