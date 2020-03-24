using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace DuplexMEPClient
{
    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class Form1 : Form, ServiceReference1.IDuplexMessagePatternServiceCallback
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ProgressMethod(int percentageCompleted)
        {
            txtPercentage.Text = percentageCompleted.ToString() + " % completed.";
        }

        private void btnInvoke_Click(object sender, EventArgs e)
        {
            //Create new Form1 object instance to pass to call back method below.
            InstanceContext instanceContext = new InstanceContext(this);

            ServiceReference1.DuplexMessagePatternServiceClient client = new ServiceReference1.DuplexMessagePatternServiceClient(instanceContext);
            client.ProcessReport();

        }
    }
}
