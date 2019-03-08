using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculationGuideProject
{
    public partial class QuadraticFunctionAndHerDemonstration : Form
    {
        private CharChecker _charChecker;
        private Graphics g;
        public QuadraticFunctionAndHerDemonstration()
        {
            InitializeComponent();
            _charChecker = new CharChecker(this);
            Checked._checkedTextBoxQFA = true;
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Size = new Size(902, 470);
         }

        private void QuadraticFunctionAndHerDemonstration_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.Parent = null;
        }

        private void ButtonOneBtn_Click(object sender, EventArgs e)
        {
            var _qFunSS = TextBoxQFATxb.SelectionStart;

            if (Checked._checkedTextBoxQFA == true)
            {
                TextBoxQFATxb.Focus();
                TextBoxQFATxb.Text = TextBoxQFATxb.Text.Insert(_qFunSS, "1");
                _qFunSS++;
              
                TextBoxQFATxb.SelectionStart = _qFunSS;
                _charChecker.IsCommaCheckerQFAMethod();
                _charChecker.IsMinusCheckerQFAMethod();
 
            }
            var _qFunSSB = TextBoxQFBTxb.SelectionStart;
            if (Checked._checkedTextBoxQFB == true)
            {
                TextBoxQFBTxb.Focus();
                TextBoxQFBTxb.Text = TextBoxQFBTxb.Text.Insert(_qFunSSB, "1");
                _qFunSSB++;
               
                TextBoxQFBTxb.SelectionStart = _qFunSSB;
                _charChecker.IsCommaCheckerQFBMethod();
                _charChecker.IsMinusCheckerQFBMethod();
                
            }
            var _qFunSSC = TextBoxQFCTxb.SelectionStart;
            if (Checked._checkedTextBoxQFC == true)
            {
                TextBoxQFCTxb.Focus();
                TextBoxQFCTxb.Text = TextBoxQFCTxb.Text.Insert(_qFunSSC, "1");
                _qFunSSC++;
                TextBoxQFCTxb.SelectionStart = _qFunSSC;
                _charChecker.IsCommaCheckerQFCMethod();
                _charChecker.IsMinusCheckerQFCMethod();
            }
        }

        private void TextBoxQFATxb_MouseDown(object sender, MouseEventArgs e)
        {
            Checked._checkedTextBoxQFA = true;
            Checked._checkedTextBoxQFB = false;
            Checked._checkedTextBoxQFC = false;
            _charChecker.IsCommaCheckerQFAMethod();
            _charChecker.IsMinusCheckerQFAMethod();
        }

        private void TextBoxQFBTxb_MouseDown(object sender, MouseEventArgs e)
        {
            Checked._checkedTextBoxQFA = false;
            Checked._checkedTextBoxQFB = true;
            Checked._checkedTextBoxQFC = false;
            _charChecker.IsCommaCheckerQFBMethod();
            _charChecker.IsMinusCheckerQFBMethod();
        }

        private void TextBoxQFCTxb_MouseDown(object sender, MouseEventArgs e)
        {
            Checked._checkedTextBoxQFA = false;
            Checked._checkedTextBoxQFB = false;
            Checked._checkedTextBoxQFC = true;
            _charChecker.IsCommaCheckerQFCMethod();
            _charChecker.IsMinusCheckerQFCMethod();
        }

        private void ButtonTwoBtn_Click(object sender, EventArgs e)
        {
            var _qFunSS = TextBoxQFATxb.SelectionStart;

            if (Checked._checkedTextBoxQFA == true)
            {
                TextBoxQFATxb.Focus();
                TextBoxQFATxb.Text = TextBoxQFATxb.Text.Insert(_qFunSS, "2");
                _qFunSS++;
               
                TextBoxQFATxb.SelectionStart = _qFunSS;
                _charChecker.IsCommaCheckerQFAMethod();
                _charChecker.IsMinusCheckerQFAMethod();
 
            }
            var _qFunSSB = TextBoxQFBTxb.SelectionStart;
            if (Checked._checkedTextBoxQFB == true)
            {
                TextBoxQFBTxb.Focus();
                TextBoxQFBTxb.Text = TextBoxQFBTxb.Text.Insert(_qFunSSB, "2");
                _qFunSSB++;
               
                TextBoxQFBTxb.SelectionStart = _qFunSSB;
                _charChecker.IsCommaCheckerQFBMethod();
                _charChecker.IsMinusCheckerQFBMethod();
                
            }
            var _qFunSSC = TextBoxQFCTxb.SelectionStart;
            if (Checked._checkedTextBoxQFC == true)
            {
                TextBoxQFCTxb.Focus();
                TextBoxQFCTxb.Text = TextBoxQFCTxb.Text.Insert(_qFunSSC, "2");
                _qFunSSC++;
                TextBoxQFCTxb.SelectionStart = _qFunSSC;
                _charChecker.IsCommaCheckerQFCMethod();
                _charChecker.IsMinusCheckerQFCMethod();
            }
        }

        private void ButtonThreeBtn_Click(object sender, EventArgs e)
        {
            var _qFunSS = TextBoxQFATxb.SelectionStart;

            if (Checked._checkedTextBoxQFA == true)
            {
                TextBoxQFATxb.Focus();
                TextBoxQFATxb.Text = TextBoxQFATxb.Text.Insert(_qFunSS, "3");
                _qFunSS++;
                
                TextBoxQFATxb.SelectionStart = _qFunSS;
                _charChecker.IsCommaCheckerQFAMethod();
                _charChecker.IsMinusCheckerQFAMethod();
 
            }
            var _qFunSSB = TextBoxQFBTxb.SelectionStart;
            if (Checked._checkedTextBoxQFB == true)
            {
                TextBoxQFBTxb.Focus();
                TextBoxQFBTxb.Text = TextBoxQFBTxb.Text.Insert(_qFunSSB, "3");
                _qFunSSB++;
                
                TextBoxQFBTxb.SelectionStart = _qFunSSB;
                _charChecker.IsCommaCheckerQFBMethod();
                _charChecker.IsMinusCheckerQFBMethod();
               
            }
            var _qFunSSC = TextBoxQFCTxb.SelectionStart;
            if (Checked._checkedTextBoxQFC == true)
            {
                TextBoxQFCTxb.Focus();
                TextBoxQFCTxb.Text = TextBoxQFCTxb.Text.Insert(_qFunSSC, "3");
                _qFunSSC++;
                TextBoxQFCTxb.SelectionStart = _qFunSSC;
                _charChecker.IsCommaCheckerQFCMethod();
                _charChecker.IsMinusCheckerQFCMethod();
            }
        }

        private void ButtonFourBtn_Click(object sender, EventArgs e)
        {
            var _qFunSS = TextBoxQFATxb.SelectionStart;
 
            if (Checked._checkedTextBoxQFA == true)
            {
                TextBoxQFATxb.Focus();
                TextBoxQFATxb.Text = TextBoxQFATxb.Text.Insert(_qFunSS, "4");
                _qFunSS++;
               
                TextBoxQFATxb.SelectionStart = _qFunSS;
                _charChecker.IsCommaCheckerQFAMethod();
                _charChecker.IsMinusCheckerQFAMethod();
 
            }
            var _qFunSSB = TextBoxQFBTxb.SelectionStart;
            if (Checked._checkedTextBoxQFB == true)
            {
                TextBoxQFBTxb.Focus();
                TextBoxQFBTxb.Text = TextBoxQFBTxb.Text.Insert(_qFunSSB, "4");
                _qFunSSB++;
              
                TextBoxQFBTxb.SelectionStart = _qFunSSB;
                _charChecker.IsCommaCheckerQFBMethod();
                _charChecker.IsMinusCheckerQFBMethod();
                
            }
            var _qFunSSC = TextBoxQFCTxb.SelectionStart;
            if (Checked._checkedTextBoxQFC == true)
            {
                TextBoxQFCTxb.Focus();
                TextBoxQFCTxb.Text = TextBoxQFCTxb.Text.Insert(_qFunSSC, "4");
                _qFunSSC++;
                TextBoxQFCTxb.SelectionStart = _qFunSSC;
                _charChecker.IsCommaCheckerQFCMethod();
                _charChecker.IsMinusCheckerQFCMethod();
            }
        }

        private void ButtonFiveBtn_Click(object sender, EventArgs e)
        {
            var _qFunSS = TextBoxQFATxb.SelectionStart;
 
            if (Checked._checkedTextBoxQFA == true)
            {
                TextBoxQFATxb.Focus();
                TextBoxQFATxb.Text = TextBoxQFATxb.Text.Insert(_qFunSS, "5");
                _qFunSS++;
                
                TextBoxQFATxb.SelectionStart = _qFunSS;
                _charChecker.IsCommaCheckerQFAMethod();
                _charChecker.IsMinusCheckerQFAMethod();
 
            }
            var _qFunSSB = TextBoxQFBTxb.SelectionStart;
            if (Checked._checkedTextBoxQFB == true)
            {
                TextBoxQFBTxb.Focus();
                TextBoxQFBTxb.Text = TextBoxQFBTxb.Text.Insert(_qFunSSB, "5");
                _qFunSSB++;
                
                TextBoxQFBTxb.SelectionStart = _qFunSSB;
                _charChecker.IsCommaCheckerQFBMethod();
                _charChecker.IsMinusCheckerQFBMethod();
                
            }
            var _qFunSSC = TextBoxQFCTxb.SelectionStart;
            if (Checked._checkedTextBoxQFC == true)
            {
                TextBoxQFCTxb.Focus();
                TextBoxQFCTxb.Text = TextBoxQFCTxb.Text.Insert(_qFunSSC, "5");
                _qFunSSC++;
                TextBoxQFCTxb.SelectionStart = _qFunSSC;
                _charChecker.IsCommaCheckerQFCMethod();
                _charChecker.IsMinusCheckerQFCMethod();
            }
        }

        private void ButtonSixBtn_Click(object sender, EventArgs e)
        {
            var _qFunSS = TextBoxQFATxb.SelectionStart;

             if (Checked._checkedTextBoxQFA == true)
            {
                TextBoxQFATxb.Focus();
                TextBoxQFATxb.Text = TextBoxQFATxb.Text.Insert(_qFunSS, "6");
                _qFunSS++;
                
                TextBoxQFATxb.SelectionStart = _qFunSS;
                _charChecker.IsCommaCheckerQFAMethod();
                _charChecker.IsMinusCheckerQFAMethod();

            }
            var _qFunSSB = TextBoxQFBTxb.SelectionStart;
            if (Checked._checkedTextBoxQFB == true)
            {
                TextBoxQFBTxb.Focus();
                TextBoxQFBTxb.Text = TextBoxQFBTxb.Text.Insert(_qFunSSB, "6");
                _qFunSSB++;
                
                TextBoxQFBTxb.SelectionStart = _qFunSSB;
                _charChecker.IsCommaCheckerQFBMethod();
                _charChecker.IsMinusCheckerQFBMethod();
                
            }
            var _qFunSSC = TextBoxQFCTxb.SelectionStart;
            if (Checked._checkedTextBoxQFC == true)
            {
                TextBoxQFCTxb.Focus();
                TextBoxQFCTxb.Text = TextBoxQFCTxb.Text.Insert(_qFunSSC, "6");
                _qFunSSC++;
                TextBoxQFCTxb.SelectionStart = _qFunSSC;
                _charChecker.IsCommaCheckerQFCMethod();
                _charChecker.IsMinusCheckerQFCMethod();
            }
        }

        private void ButtonSevenBtn_Click(object sender, EventArgs e)
        {
            var _qFunSS = TextBoxQFATxb.SelectionStart;

            
            if (Checked._checkedTextBoxQFA == true)
            {
                TextBoxQFATxb.Focus();
                TextBoxQFATxb.Text = TextBoxQFATxb.Text.Insert(_qFunSS, "7");
                _qFunSS++;
                
                TextBoxQFATxb.SelectionStart = _qFunSS;
                _charChecker.IsCommaCheckerQFAMethod();
                _charChecker.IsMinusCheckerQFAMethod();
 
            }
            var _qFunSSB = TextBoxQFBTxb.SelectionStart;
            if (Checked._checkedTextBoxQFB == true)
            {
                TextBoxQFBTxb.Focus();
                TextBoxQFBTxb.Text = TextBoxQFBTxb.Text.Insert(_qFunSSB, "7");
                _qFunSSB++;
               
                TextBoxQFBTxb.SelectionStart = _qFunSSB;
                _charChecker.IsCommaCheckerQFBMethod();
                _charChecker.IsMinusCheckerQFBMethod();
                
            }
            var _qFunSSC = TextBoxQFCTxb.SelectionStart;
            if (Checked._checkedTextBoxQFC == true)
            {
                TextBoxQFCTxb.Focus();
                TextBoxQFCTxb.Text = TextBoxQFCTxb.Text.Insert(_qFunSSC, "7");
                _qFunSSC++;
                TextBoxQFCTxb.SelectionStart = _qFunSSC;
                _charChecker.IsCommaCheckerQFCMethod();
                _charChecker.IsMinusCheckerQFCMethod();
            }
        }

        private void ButtonEightBtn_Click(object sender, EventArgs e)
        {
            var _qFunSS = TextBoxQFATxb.SelectionStart;
 
            if (Checked._checkedTextBoxQFA == true)
            {
                TextBoxQFATxb.Focus();
                TextBoxQFATxb.Text = TextBoxQFATxb.Text.Insert(_qFunSS, "8");
                _qFunSS++;
                
                TextBoxQFATxb.SelectionStart = _qFunSS;
                _charChecker.IsCommaCheckerQFAMethod();
                _charChecker.IsMinusCheckerQFAMethod();

            }
            var _qFunSSB = TextBoxQFBTxb.SelectionStart;
            if (Checked._checkedTextBoxQFB == true)
            {
                TextBoxQFBTxb.Focus();
                TextBoxQFBTxb.Text = TextBoxQFBTxb.Text.Insert(_qFunSSB, "8");
                _qFunSSB++;
                
                TextBoxQFBTxb.SelectionStart = _qFunSSB;
                _charChecker.IsCommaCheckerQFBMethod();
                _charChecker.IsMinusCheckerQFBMethod();
                
            }
            var _qFunSSC = TextBoxQFCTxb.SelectionStart;
            if (Checked._checkedTextBoxQFC == true)
            {
                TextBoxQFCTxb.Focus();
                TextBoxQFCTxb.Text = TextBoxQFCTxb.Text.Insert(_qFunSSC, "8");
                _qFunSSC++;
                TextBoxQFCTxb.SelectionStart = _qFunSSC;
                _charChecker.IsCommaCheckerQFCMethod();
                _charChecker.IsMinusCheckerQFCMethod();
            }
        }

        private void ButtonNineBtn_Click(object sender, EventArgs e)
        {
            var _qFunSS = TextBoxQFATxb.SelectionStart;

            
            if (Checked._checkedTextBoxQFA == true)
            {
                TextBoxQFATxb.Focus();
                TextBoxQFATxb.Text = TextBoxQFATxb.Text.Insert(_qFunSS, "9");
                _qFunSS++;
                
                TextBoxQFATxb.SelectionStart = _qFunSS;
                _charChecker.IsCommaCheckerQFAMethod();
                _charChecker.IsMinusCheckerQFAMethod();

            }
            var _qFunSSB = TextBoxQFBTxb.SelectionStart;
            if (Checked._checkedTextBoxQFB == true)
            {
                TextBoxQFBTxb.Focus();
                TextBoxQFBTxb.Text = TextBoxQFBTxb.Text.Insert(_qFunSSB, "9");
                _qFunSSB++;
                
                TextBoxQFBTxb.SelectionStart = _qFunSSB;
                _charChecker.IsCommaCheckerQFBMethod();
                _charChecker.IsMinusCheckerQFBMethod();
                
            }
            var _qFunSSC = TextBoxQFCTxb.SelectionStart;
            if (Checked._checkedTextBoxQFC == true)
            {
                TextBoxQFCTxb.Focus();
                TextBoxQFCTxb.Text = TextBoxQFCTxb.Text.Insert(_qFunSSC, "9");
                _qFunSSC++;
                TextBoxQFCTxb.SelectionStart = _qFunSSC;
                _charChecker.IsCommaCheckerQFCMethod();
                _charChecker.IsMinusCheckerQFCMethod();
            }
        }

        private void ButtonZeroBtn_Click(object sender, EventArgs e)
        {
            var _qFunSS = TextBoxQFATxb.SelectionStart;
     
            if (Checked._checkedTextBoxQFA == true)
            {
                TextBoxQFATxb.Focus();
                TextBoxQFATxb.Text = TextBoxQFATxb.Text.Insert(_qFunSS, "0");
                _qFunSS++;
                
                TextBoxQFATxb.SelectionStart = _qFunSS;
                _charChecker.IsCommaCheckerQFAMethod();
                _charChecker.IsMinusCheckerQFAMethod();
 
            }
            var _qFunSSB = TextBoxQFBTxb.SelectionStart;
            if (Checked._checkedTextBoxQFB == true)
            {
                TextBoxQFBTxb.Focus();
                TextBoxQFBTxb.Text = TextBoxQFBTxb.Text.Insert(_qFunSSB, "0");
                _qFunSSB++;
                
                TextBoxQFBTxb.SelectionStart = _qFunSSB;
                _charChecker.IsCommaCheckerQFBMethod();
                _charChecker.IsMinusCheckerQFBMethod();
                
            }
            var _qFunSSC = TextBoxQFCTxb.SelectionStart;
            if (Checked._checkedTextBoxQFC == true)
            {
                TextBoxQFCTxb.Focus();
                TextBoxQFCTxb.Text = TextBoxQFCTxb.Text.Insert(_qFunSSC, "0");
                _qFunSSC++;
                TextBoxQFCTxb.SelectionStart = _qFunSSC;
                _charChecker.IsCommaCheckerQFCMethod();
                _charChecker.IsMinusCheckerQFCMethod();
            }
        }

        private void ButtonCommaQFunBtn_Click(object sender, EventArgs e)
        {
            var _qFunSS = TextBoxQFATxb.SelectionStart;
            if (Checked._checkedTextBoxQFA == true)
            {
                TextBoxQFATxb.Focus();
                TextBoxQFATxb.Text = TextBoxQFATxb.Text.Insert(_qFunSS, ",");
                _qFunSS++;
                
                TextBoxQFATxb.SelectionStart = _qFunSS;
                _charChecker.IsCommaCheckerQFAMethod();
                _charChecker.IsMinusCheckerQFAMethod();
 
            }
            var _qFunSSB = TextBoxQFBTxb.SelectionStart;
            if (Checked._checkedTextBoxQFB == true)
            {
                TextBoxQFBTxb.Focus();
                TextBoxQFBTxb.Text = TextBoxQFBTxb.Text.Insert(_qFunSSB, ",");
                _qFunSSB++;
                
                TextBoxQFBTxb.SelectionStart = _qFunSSB;
                _charChecker.IsCommaCheckerQFBMethod();
                _charChecker.IsMinusCheckerQFBMethod();
                
            }
            var _qFunSSC = TextBoxQFCTxb.SelectionStart;
            if (Checked._checkedTextBoxQFC == true)
            {
                TextBoxQFCTxb.Focus();
                TextBoxQFCTxb.Text = TextBoxQFCTxb.Text.Insert(_qFunSSC, ",");
                _qFunSSC++;
                TextBoxQFCTxb.SelectionStart = _qFunSSC;
                _charChecker.IsCommaCheckerQFCMethod();
                _charChecker.IsMinusCheckerQFCMethod();
            }
        }

        private void ButtonMinusQFunBtn_Click(object sender, EventArgs e)
        {
            var _qFunSS = TextBoxQFATxb.SelectionStart;
 
            if (Checked._checkedTextBoxQFA == true)
            {
                TextBoxQFATxb.Focus();
                TextBoxQFATxb.Text = TextBoxQFATxb.Text.Insert(_qFunSS, "-");
                _qFunSS++;
                
                TextBoxQFATxb.SelectionStart = _qFunSS;
                _charChecker.IsCommaCheckerQFAMethod();
                _charChecker.IsMinusCheckerQFAMethod();
            }
            var _qFunSSB = TextBoxQFBTxb.SelectionStart;
            if (Checked._checkedTextBoxQFB == true)
            {
                TextBoxQFBTxb.Focus();
                TextBoxQFBTxb.Text = TextBoxQFBTxb.Text.Insert(_qFunSSB, "-");
                _qFunSSB++;
                
                TextBoxQFBTxb.SelectionStart = _qFunSSB;
                _charChecker.IsCommaCheckerQFBMethod();
                _charChecker.IsMinusCheckerQFBMethod();
                
            }
            var _qFunSSC = TextBoxQFCTxb.SelectionStart;
            if (Checked._checkedTextBoxQFC == true)
            {
                TextBoxQFCTxb.Focus();
                TextBoxQFCTxb.Text = TextBoxQFCTxb.Text.Insert(_qFunSSC, "-");
                _qFunSSC++;
                TextBoxQFCTxb.SelectionStart = _qFunSSC;
                _charChecker.IsCommaCheckerQFCMethod();
                _charChecker.IsMinusCheckerQFCMethod();
            }

        }

        private void ButtonResultQFBtn_Click(object sender, EventArgs e)
        {
            double _wspolAQF = Convert.ToDouble(TextBoxQFATxb.Text);
            double _wspolBQF = Convert.ToDouble(TextBoxQFBTxb.Text);
            double _wspolCQF = Convert.ToDouble(TextBoxQFCTxb.Text);
            for (int i = -30; i < 30; i++)
            {
                ResultsValue._qFunResultValue = _wspolAQF * Math.Pow(i,2) + _wspolBQF * i + _wspolCQF;
                WykresFQChart.Series["Series1"].Points.AddXY(i,ResultsValue._qFunResultValue);
            }
            ResultsValue._delta = Math.Pow(_wspolBQF, 2) - 4 * _wspolAQF * _wspolCQF;
            LabelDeltaLbl.Text = Convert.ToString(ResultsValue._delta);
            if (ResultsValue._delta > 0)
            {
                ResultsValue._x1QF = (-_wspolBQF - Math.Sqrt(ResultsValue._delta)) / 2 * _wspolAQF;
                ResultsValue._x2QF = (-_wspolBQF + Math.Sqrt(ResultsValue._delta)) / 2 * _wspolAQF;

                LabelX1ValueQFLbl.Text = Convert.ToString(Math.Round(ResultsValue._x1QF));
                LabelX2ValueQFLbl.Text = Convert.ToString(Math.Round(ResultsValue._x2QF));
            }
            else if (ResultsValue._delta == 0)
            {
                ResultsValue._x1QF = Math.Round((-_wspolBQF) / 2 * _wspolAQF);
                LabelX1ValueQFLbl.Text = Convert.ToString(ResultsValue._x1QF);
                LabelX2ValueQFLbl.Text = Convert.ToString(ResultsValue._x1QF);
            }
            else if (ResultsValue._delta < 0)
            {
                LabelX1ValueQFLbl.Text = "Brak";
                LabelX2ValueQFLbl.Text = "Brak";

            }
            ResultsValue._xw = (-_wspolBQF) / 2 * _wspolAQF;
        }

        private void ButtonStartDQFBtn_Click(object sender, EventArgs e)
        {
            ButtonStartDQFBtn.Enabled = false;
            ButtonDrawingQFBtn.Enabled = true;
            int overScale = 10;
            int _x = 1;
            int _y = 1;
            int i = 0;
            int j = 0;
            
            int _startPoint = 0;

            int _xsclale = _startPoint + 150;
            int _yscale = _startPoint + 150;
            
            Pen _pen = new Pen(Color.White);
            Point _p1v = new Point(150, 0);
            Point _p2v = new Point(150, 300);
            Point _p1h = new Point(0, 150);
            Point _p2h = new Point(300,150);
            g = PictureBoxQFDemonstration.CreateGraphics();
            g.DrawLine(_pen, _p1v, _p2v);
            g.DrawLine(_pen, _p1h, _p2h);
            for (i +=_xsclale + _x * overScale; i <= 300; i = i + 10)
            {
                Point _xsc = new Point(i, _yscale);
                Point _xsc2 = new Point(i, _yscale - 5);
                g.DrawLine(_pen, _xsc, _xsc2);
            }
            for (i+=_xsclale - _x*overScale;i>=0;i=i-10)
            {
                Point _xsc = new Point(i, _yscale);
                Point _xsc2 = new Point(i, _yscale - 5);
                g.DrawLine(_pen, _xsc, _xsc2);

            }
            for (i += _yscale - _y * overScale; i >= 0; i = i - 10)
            {
                Point _ysc = new Point(_xsclale, i);
                Point _ysc2 = new Point(_xsclale + 5, i);
                g.DrawLine(_pen, _ysc, _ysc2);
            }
            for (i += _yscale + _y * overScale; i <= 300; i = i + 10)
            {
                Point _ysc = new Point(_xsclale, i);
                Point _ysc2 = new Point(_xsclale + 5, i);
                g.DrawLine(_pen, _ysc, _ysc2);
            }
            Font _x_mark = new Font("Arial", 14);
            g.DrawString("x", _x_mark, Brushes.Red, new Point(280, 120));
            Font _y_mark = new Font("Arial", 14);
            g.DrawString("y", _y_mark, Brushes.Red, new Point(160, 5));
            
            g.Dispose();
        }

        private void ButtonDrawingQFBtn_Click(object sender, EventArgs e)
        {
            int _qx_naosi;
            float _qy_naosi;
            ButtonDrawingQFBtn.Enabled = false;
            ButtonResetDrawQFBtn.Enabled = true;

            Pen _penCurve = new Pen(Color.Red, 2);
            Pen _penNameFunction = new Pen(Color.Red, 3);
            g = PictureBoxQFDemonstration.CreateGraphics();
            AmountElements._quadratic_x_mes = -140.0F;
            while (AmountElements._quadratic_x_mes < 140.0F)
            {
                AmountElements._quadratic_y_mes = -((0.02F*(AmountElements._quadratic_x_mes * AmountElements._quadratic_x_mes)));
                _qx_naosi = (int)AmountElements._quadratic_x_mes + 150;
                _qy_naosi = AmountElements._quadratic_y_mes + 150.0F;

                PointF pq1 = new PointF((float)_qx_naosi, _qy_naosi);
                AmountElements._quadratic_x_mes = AmountElements._quadratic_x_mes + 5;
                AmountElements._quadratic_y_mes = -(0.02F*AmountElements._quadratic_x_mes * AmountElements._quadratic_x_mes);

                _qx_naosi = _qx_naosi +5;
                _qy_naosi = AmountElements._quadratic_y_mes + 150.0F;

                PointF pq2 = new PointF((float)_qx_naosi, _qy_naosi);
                if (AmountElements._quadratic_x_mes == 140.0F) break;
                g.DrawLine(_penCurve, pq1, pq2);

            }
            Font _y_str_left = new Font("Arial", 14);
            g.DrawString("Y=", _y_str_left, Brushes.Red, new Point(2, 170));
            Font _zmiennax_q_symbol = new Font("Arial", 14);
            g.DrawString("x", _zmiennax_q_symbol, Brushes.Red, new Point(30, 170));
            Font _wykladnik_potegowy = new Font("Arial", 12);
            g.DrawString("2", _wykladnik_potegowy, Brushes.Red, new Point(40, 160));
            g.Dispose();
        }

        private void ButtonResetDrawQFBtn_Click(object sender, EventArgs e)
        {
            g = PictureBoxQFDemonstration.CreateGraphics();
            g.Clear(Color.YellowGreen);
            g.Dispose();
            ButtonStartDQFBtn.Enabled = true;
            ButtonResetDrawQFBtn.Enabled = false;
        }

        private void ButtonResetQFBtn_Click(object sender, EventArgs e)
        {
            WykresFQChart.Series["Series1"].Points.Clear();
            TextBoxQFATxb.Text = "";
            TextBoxQFBTxb.Text = "";
            TextBoxQFCTxb.Text = "";
            LabelX1ValueQFLbl.Text = "";
            LabelX2ValueQFLbl.Text = "";
            LabelDeltaLbl.Text = "";
            this.ButtonCommaQFunBtn.Text = ",";
            this.ButtonMinusQFunBtn.Text = "-";

        }
    }
}
