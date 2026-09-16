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
        static private Color OPERATION_BG = Color.LightGray;
        static private Color NUMBER_BG = Color.WhiteSmoke;
        static private Color EQUAL_BG = Color.DeepSkyBlue;
        public struct ButtonStr
        {
            public char content;
            public Color BgColor;
            public ButtonStr(char content, Color BgColor)
            {
                this.content = content;
                this.BgColor = BgColor;
            }
            public override string ToString()
            {
                return content.ToString();
            }
        }

        private ButtonStr[,] buttuns =
        {
            {new ButtonStr('%', OPERATION_BG),new ButtonStr('\u0152', OPERATION_BG),new ButtonStr('C', OPERATION_BG),new ButtonStr('\u232b', OPERATION_BG) },
            {new ButtonStr('\u215f', OPERATION_BG),      new ButtonStr('\u00b2', OPERATION_BG),new ButtonStr('\u221A', OPERATION_BG),new ButtonStr('\u00f7', OPERATION_BG) },
            {new ButtonStr('7', NUMBER_BG),new ButtonStr('8', NUMBER_BG),new ButtonStr('9', NUMBER_BG),new ButtonStr('\u00D7', OPERATION_BG) },
            {new ButtonStr('4', NUMBER_BG),new ButtonStr('5', NUMBER_BG),new ButtonStr('6', NUMBER_BG),new ButtonStr('-', OPERATION_BG) },
            {new ButtonStr('1', NUMBER_BG),new ButtonStr('2', NUMBER_BG),new ButtonStr('3', NUMBER_BG),   new ButtonStr('+', OPERATION_BG)     },
            {new ButtonStr('\u00b1', NUMBER_BG),new ButtonStr('0', NUMBER_BG),new ButtonStr(',', NUMBER_BG),new ButtonStr('=', EQUAL_BG) },
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
            int posY = 174;
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
                    btn.BackColor = buttuns[i, j].BgColor;
                    Controls.Add(btn);
                    posX += 80;
                }
                posY += 60;
            }
        }
    }
}
