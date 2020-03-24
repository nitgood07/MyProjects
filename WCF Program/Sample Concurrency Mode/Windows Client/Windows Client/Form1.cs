using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Client
{
    public partial class Form1 : Form
    {
        SimpleService.SimpleServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new SimpleService.SimpleServiceClient();
        }

        private void btnGetEvenNumber_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnGetOddNumber_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }

        private void btnClearResults_Click(object sender, EventArgs e)
        {
            ListBoxEvenNumbers.DataSource = null;
            ListBoxOddNumbers.DataSource = null;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ListBoxEvenNumbers.DataSource = (int[])e.Result;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = client.GetEvenNumbers();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = client.GetOddNumbers();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ListBoxOddNumbers.DataSource = (int[])e.Result;
        }
    }
}
