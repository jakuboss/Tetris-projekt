namespace Tetirs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.blockPanel = new System.Windows.Forms.Panel();
            this.blockLabels = new System.Windows.Forms.Label[40];
            this.SuspendLayout();
            // 
            // blockPanel
            // 
            this.blockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blockPanel.Location = new System.Drawing.Point(0, 0);
            this.blockPanel.Name = "blockPanel";
            this.blockPanel.Size = new System.Drawing.Size(400, 500);
            this.blockPanel.TabIndex = 0;

            //Tworzymy etykiety
            int blockNumber = 0;
            int blockPossitionX = 0;
            int blockRow = 0;
            foreach (System.Windows.Forms.Label block in blockLabels)
            {
                blockLabels[blockNumber] = new System.Windows.Forms.Label();

                this.blockLabels[blockNumber].BackColor = System.Drawing.Color.LimeGreen;
                this.blockLabels[blockNumber].Location = new System.Drawing.Point(60 * blockPossitionX, 60 * blockRow);
                this.blockLabels[blockNumber].Name = "blockLabel" + blockNumber.ToString();
                this.blockLabels[blockNumber].Size = new System.Drawing.Size(50, 50);
                this.blockLabels[blockNumber].TabIndex = blockNumber;

                blockNumber++;
                blockPossitionX++;

                if (blockNumber == 5)
                {
                    blockRow++;
                    blockPossitionX = 0;
                }
                if (blockNumber == 10)
                {
                    blockRow++;
                    blockPossitionX = 0;
                }
                if (blockNumber == 15)
                {
                    blockRow++;
                    blockPossitionX = 0;
                }
                if (blockNumber == 20)
                {
                    blockRow++;
                    blockPossitionX = 0;
                }
                if (blockNumber == 25)
                {
                    blockRow++;
                    blockPossitionX = 0;
                }
                if (blockNumber == 30)
                {
                    blockRow++;
                    blockPossitionX = 0;
                }
                if (blockNumber == 35)
                {
                    blockRow++;
                    blockPossitionX = 0;
                }
                if (blockNumber == 40)
                {
                    blockRow++;
                    blockPossitionX = 0;
                }
            }
            blockNumber = 0;
            foreach (System.Windows.Forms.Label block in blockLabels)
            {
                this.blockPanel.Controls.Add(this.blockLabels[blockNumber]);
                blockNumber++;
            }
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.blockPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel blockPanel;

        private System.Windows.Forms.Label[] blockLabels;

        private System.Windows.Forms.Label[] BlockLabels
        {
            get { return blockLabels; }
            set { blockLabels = value; }
        }

    }
}

