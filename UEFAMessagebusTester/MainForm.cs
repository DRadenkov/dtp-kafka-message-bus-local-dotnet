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
        private int notSentMessages = 0;

        public MainForm()
        {
            InitializeComponent();
            sentNum.Text = sentMessages.ToString();
            notSentNum.Text = notSentMessages.ToString();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            producer.init();
            bool isConectionUnsuccessfull = producer.isNullProducer();
            connectStatus.BackColor = isConectionUnsuccessfull ? Color.Red : Color.Green;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (!producer.isNullProducer())
            {

                if (producer.sendMessage())
                {
                    incremetSent();
                }
                else
                {
                    incremetNotSent();
                }

            }
            else
            {
                incremetNotSent();
            }
        }

        public void incremetSent()
        {
            sentMessages++;
            sentNum.Text = sentMessages.ToString();
        }

        public void incremetNotSent()
        {
            notSentMessages++;
            notSentNum.Text = notSentMessages.ToString();
        }
    }
}
