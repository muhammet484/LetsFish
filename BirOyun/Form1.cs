using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsFish
{
    public partial class Form1 : Form
    {
        Timer UpdateTimer;
        BigInteger fish = 0;
        BigInteger fishers = 0;

        const short fisherPrice = 15;

        public bool UseFisherManager { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Set Update
            UpdateTimer = new Timer();
            UpdateTimer.Tick += new EventHandler(updateFunction);
            UpdateTimer.Interval = 1000; // in miliseconds
            #endregion
            updateFishText();
        }

        private void updateFunction(object sender, EventArgs e)
        {
            fish += fishers;
            updateFishText();
        }
        void updateFishText(int add = 0)
        {
            if(UseFisherManager)
                fisherManager();
            fish += add;
            FishNoTextBox.Text = "" + fish;

            if(FishNoTextBox.Text.Length > 13)
            {
                this.Size = new Size(1500, this.Size.Height);
            }
        }
        private void button1_Click(object sender = null, EventArgs e = null)
        {
            if(new Random().Next(2) == 1)
            {
                CongratText.Text = "Yay! You just\ncatch a fish!";
                updateFishText(1);
            }
            else
            {
                CongratText.Text = ":( You couldn't\ncatch a fish..";
            }

        }

        private void HireFisher1_Click(object sender = null, EventArgs e = null)
        {
            if (fishers == 0)
            {
                UpdateTimer.Start();
            }
            if (fish >= fisherPrice)
            {
                fish -= fisherPrice;
                fishers++;
                FisherNoTextBox.Text = "" + fishers;
                updateFishText();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space || e.KeyCode == Keys.A)
            {
                button1_Click();
            }
            if(e.KeyCode == Keys.D)
            {
                HireFisher1_Click();
            }
        }

        //hire fisher manager
        private void button2_Click(object sender, EventArgs e)
        {
            if(fish >= 1500)
            {
                UseFisherManager = true;
                this.Size = new Size(this.Size.Width, 533);
                fish -= 1500;
                FisherManagerMan.Visible = true;
                button2.Visible = false;
                label4.Location = new Point(label4.Location.X, 490);
                fisherManager();
            }
        }

        private void fisherManager()
        {
            if(fish >= 1000 && FisherManagerMan.Checked)
            {
                BigInteger _addedFisher = fish / 15;
                fishers += _addedFisher;
                FisherNoTextBox.Text ="" + fishers;

                if (!UpdateTimer.Enabled)
                {
                    UpdateTimer.Start();
                }
            }
        }

        private void ChatButton_Click(object sender, EventArgs e)
        {
            string _addedFishes = "25";
            for (int i = 0; i < 500; i++)
            {
                _addedFishes += '0';
            }

            fish += BigInteger.Parse(_addedFishes);
            CongratText.Text = "Suddenly it started raining fishes!!";
            updateFishText();
        }
    }
}
