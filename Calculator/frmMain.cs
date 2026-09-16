using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmMain : Form
    {
        private char[,] buttuns =
        {
            {'%','\u0152','C','\u232b' },
            {'\u215f','\u00b2','\u221A','\u00f7' },
            {'7','8','9','\u00D7' },
            {'4','5','6','-' },
            {'1','2','3','+' },
            {'\u00b1','0',',','=' },
        };
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MakeButtuns();
        }

        private void MakeButtuns()
        {
            int btnWidth = 80, btnHeight= 60;
            int posY = 106;
            for (int i = 0; i < buttuns.GetLength(0); i++) {
                int posX = 0;
                for (int j = 0; j < buttuns.GetLength(1); j++)
                {
                    Button btn = new Button();
                    btn.Width=btnWidth;
                    btn.Height=btnHeight;
                    btn.Top=posY;
                    btn.Left=posX;
                    btn.Font = new Font("segoe UI", 16);
                    btn.Text=buttuns[i,j].ToString();
                    Controls.Add(btn);
                    posX += 80;
                }
                posY += 60;
            }
        }
    }
}
