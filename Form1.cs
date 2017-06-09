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
            _timer.Interval = 50;
            _timer.Enabled = true;
            _timer.Tick += new System.EventHandler(TimerTickEvent);

            _blockEmptyColor = new Color[2];

            _blocksFilled = new bool[40];

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

            if (_tetrisPiecePossition < 35)
            {
                if(BlockLabels[_tetrisPiecePossition].BackColor==_blockEmptyColor[1])
                {
                    _tetrisPiecePossition = 2;

                }
            }


            if(_tetrisPiecePossition==2)
            {
                int amount = 0;
                foreach(Label block in BlockLabels)
                {
                    if(block.BackColor==_blockEmptyColor[1])
                    {
                        _blocksFilled[amount] = true;

                    }
                    amount++;
                }
            }
            if (_tetrisPiecePossition>40)
            {
                _tetrisPiecePossition = 2;
            }

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
            if(BlockLabels[35].BackColor ==_blockEmptyColor[1]&&
               BlockLabels[36].BackColor == _blockEmptyColor[1] &&
               BlockLabels[37].BackColor == _blockEmptyColor[1] &&
               BlockLabels[38].BackColor == _blockEmptyColor[1] &&
               BlockLabels[39].BackColor == _blockEmptyColor[1] )
            {
                //Linia wolnego pola
                BlockLabels[35].BackColor = _blockEmptyColor[0];
                BlockLabels[36].BackColor = _blockEmptyColor[0];
                BlockLabels[37].BackColor = _blockEmptyColor[0];
                BlockLabels[38].BackColor = _blockEmptyColor[0];
                BlockLabels[39].BackColor = _blockEmptyColor[0];

                int amountBlocks = 0;

                _blocksFilled = new bool[40];

                foreach(Label block in BlockLabels)
                {
                    if(block.BackColor==_blockEmptyColor[1])
                    {
                        _blocksFilled[amountBlocks + 5] = true;
                    }
                    amountBlocks++;
                }


                foreach(Label block in BlockLabels)
                {
                    block.BackColor = _blockEmptyColor[0];
                }

                int amountBlue = 0;
                foreach (bool blockFilled in _blocksFilled)
                {
                if(blockFilled == true)
                    {
                        BlockLabels[amountBlue].BackColor = _blockEmptyColor[1];
                    }
                    amountBlue++;
                }
                if (_tetrisPiecePossition < 40)
                {
                    if(BlockLabels[_tetrisPiecePossition].BackColor==_blockEmptyColor[0])
                    {
                        BlockLabels[_tetrisPiecePossition].BackColor = _blockEmptyColor[1];
                        if (_tetrisPiecePossition > 5)
                        {
                            BlockLabels[_tetrisPiecePossition - 5].BackColor = _blockEmptyColor[0];
                        }
                    }
                }
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                if(_tetrisPiecePossition<39 &_blocksFilled[_tetrisPiecePossition]==false)
                {
                    if (_tetrisPiecePossition != 0 &&
                        _tetrisPiecePossition != 5 &&
                        _tetrisPiecePossition != 10 &&
                        _tetrisPiecePossition != 15 &&
                        _tetrisPiecePossition != 20 &&
                        _tetrisPiecePossition != 25 &&
                        _tetrisPiecePossition != 30 &&
                        _tetrisPiecePossition != 35 &&
                        BlockLabels[_tetrisPiecePossition - 1].BackColor != _blockEmptyColor[1])
                    {
                        _tetrisPiecePossition--;
                        BlockLabels[_tetrisPiecePossition].BackColor = _blockEmptyColor[1];
                        BlockLabels[_tetrisPiecePossition + 1].BackColor = _blockEmptyColor[0];
                        return true;
                    }
                        
                }
            }
            if (keyData == Keys.Right)
            {
                if (_tetrisPiecePossition < 39 & _blocksFilled[_tetrisPiecePossition] == false)
                {
                    if (_tetrisPiecePossition != 0 &&
                        _tetrisPiecePossition != 4 &&
                        _tetrisPiecePossition != 9 &&
                        _tetrisPiecePossition != 14 &&
                        _tetrisPiecePossition != 19 &&
                        _tetrisPiecePossition != 24 &&
                        _tetrisPiecePossition != 29 &&
                        _tetrisPiecePossition != 34 &&
                        BlockLabels[_tetrisPiecePossition + 1].BackColor != _blockEmptyColor[1])
                    {
                        _tetrisPiecePossition++;
                        BlockLabels[_tetrisPiecePossition].BackColor = _blockEmptyColor[1];
                        BlockLabels[_tetrisPiecePossition - 1].BackColor = _blockEmptyColor[0];
                        return true;
                    }

                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
