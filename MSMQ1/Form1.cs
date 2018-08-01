using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSMQ1
{
    public partial class Form1 : Form
    {
        MessageQueue sendMq = null;
        MessageQueue receiveMq = null;
        MessageQueue[] QueueList = null;
        string RecieverQueue = "";


        public Form1()
        {
            InitializeComponent();
            QueueList =
                MessageQueue.GetPrivateQueuesByMachine(".");
            foreach(var q in QueueList)
            {
                UserIdsList.Items.Add(q.QueueName.Remove(0,9));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendMq.Send($@"{DateTime.Now} - {UserIdTxt.Text} saied: {MessagetxtBox.Text}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           var msg = receiveMq.Receive(new TimeSpan(0, 0, 3));
            msg.Formatter = new XmlMessageFormatter(new String[] { "System.String,mscorlib" });
           var txt = msg.Body.ToString();
            MessagetxtBox.Text += $@"Received:{txt}";
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (MessageQueue.Exists($@".\Private$\{UserIdTxt.Text}"))
                //mq = new MessageQueue(@"FormatName:DIRECT=OS:.\private$\MyQueue");
                MessageBox.Show("This Id already exists, use another Id");
            else
                sendMq = MessageQueue.Create($@".\Private$\{UserIdTxt.Text}");
        }

        private void RefereshListBtn_Click(object sender, EventArgs e)
        {
            UserIdsList.Items.Clear();
            QueueList =
               MessageQueue.GetPrivateQueuesByMachine(".");
            foreach (var q in QueueList)
            {
                UserIdsList.Items.Add(q.QueueName.Remove(0, 9));
            }
        }

        private void UserIdsList_ItemActivate(object sender, EventArgs e)
        {
            RecieverQueue = UserIdsList.SelectedItems[0].Text;
            receiveMq = new System.Messaging.MessageQueue($@".\Private$\{RecieverQueue}");
            
        }
    }
}
