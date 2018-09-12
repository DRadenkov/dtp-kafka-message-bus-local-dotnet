using System;
using System.Drawing;
using System.Windows.Forms;
using UEFAMessagebusTester.Kafka;

namespace UEFAMessagebusTester
{
    public partial class MainForm : Form
    {
        private KafkaAvroProducer producer = new KafkaAvroProducer();
        private int sentMessages = 0;

        public MainForm()
        {
            InitializeComponent();
            sentNum.Text = sentMessages.ToString();
        }
        
        private void connectBtn_Click(object sender, EventArgs e)
        {
            producer.init();
            bool isConectionUnsuccessfull = producer.isNullProducer();
            connectStatus.BackColor = isConectionUnsuccessfull ? Color.Red :  Color.Green;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (!producer.isNullProducer()) {
                producer.sendMessage(this);
                incremetSent();
            }
        }

        public void incremetSent() {
            sentMessages++;
            sentNum.Text = sentMessages.ToString();
        }
    }
}
