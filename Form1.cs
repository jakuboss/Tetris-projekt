using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetirs
{
    public partial class Form1 : Form
    {

        private Color[] _blockEmptyColor;

        private Timer _timer;

        private int _tetrisPiecePossition;
        private bool[] _blocksFilled;


        public Form1()
        {
            InitializeComponent();

            _timer = new Timer();
            _timer.Interval = 200;
            _timer.Enabled = true;
            _timer.Tick += new System.EventHandler(TimerTickEvent);

            _blockEmptyColor = new Color[2];
            _tetrisPiecePossition = -3;

            _blockEmptyColor[0] = Color.Orange;

            _blockEmptyColor[1] = Color.Green;

            foreach (Label label in BlockLabels)
            {
                label.BackColor = _blockEmptyColor[0];

            }

            _timer.Start();
        }



        private void TimerTickEvent(object sender, EventArgs e)
        {
            _tetrisPiecePossition += 5;

            if (_tetrisPiecePossition < 40)
            {
                if (BlockLabels[_tetrisPiecePossition].BackColor == _blockEmptyColor[0])
                {
                    BlockLabels[_tetrisPiecePossition].BackColor = _blockEmptyColor[1];
                    if(_tetrisPiecePossition>5)
                    {
                        BlockLabels[_tetrisPiecePossition - 5].BackColor = _blockEmptyColor[0];

                    }
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
