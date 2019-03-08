using System;
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
    public partial class ExponentialFunction : Form
    {
        private CharChecker _charChecker;
        private String _valueStringEFA;
        private bool _isComma;
        private Graphics g;
        public ExponentialFunction()
        {
            InitializeComponent();
            _charChecker = new CharChecker(this);

            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Size = new Size(862, 472);
        }

        private void ButtonOneBtn_Click(object sender, EventArgs e)
        {
            var _expFunASS = TextBoxEFA.SelectionStart;
            if (Checked._checkedTextBoxEFA == true)
            {
                TextBoxEFA.Focus();
                TextBoxEFA.Text = TextBoxEFA.Text.Insert(_expFunASS, "1");
                _expFunASS++;
                
                TextBoxEFA.SelectionStart = _expFunASS;
                _charChecker.IsCommaCheckerExpFunAMethod();
                _charChecker.IsMinusCheckerExpFunAMethod();
            }
            var _expFunXSS = TextBoxEFX.SelectionStart;
            if (Checked._checkedTextBoxEFX == true)
            {
                TextBoxEFX.Focus();
                TextBoxEFX.Text = TextBoxEFX.Text.Insert(_expFunXSS, "1");
                _expFunXSS++;
                TextBoxEFX.SelectionStart = _expFunXSS;
                _charChecker.IsCommaCheckerExpFunXMethod();
                _charChecker.IsMinusCheckerExpFunXMethod();
            }
        }

        private void TextBoxEFX_MouseDown(object sender, MouseEventArgs e)
        {
            Checked._checkedTextBoxEFX = true;
            Checked._checkedTextBoxEFA = false;
            _charChecker.IsCommaCheckerExpFunXMethod();
            _charChecker.IsMinusCheckerExpFunXMethod();
        }

        private void TextBoxEFA_MouseDown(object sender, MouseEventArgs e)
        {
            Checked._checkedTextBoxEFX = false;
            Checked._checkedTextBoxEFA = true;
            _charChecker.IsCommaCheckerExpFunAMethod();
            _charChecker.IsMinusCheckerExpFunAMethod();
        }

        private void ExponentialFunction_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.Parent = null;
        }

        private void ButtonTwoBtn_Click(object sender, EventArgs e)
        {
            var _expFunASS = TextBoxEFA.SelectionStart;
            if (Checked._checkedTextBoxEFA == true)
            {
                TextBoxEFA.Focus();
                TextBoxEFA.Text = TextBoxEFA.Text.Insert(_expFunASS, "2");
                _expFunASS++;
               
                TextBoxEFA.SelectionStart = _expFunASS;
                _charChecker.IsCommaCheckerExpFunAMethod();
                _charChecker.IsMinusCheckerExpFunAMethod();
            }
            var _expFunXSS = TextBoxEFX.SelectionStart;
            if (Checked._checkedTextBoxEFX == true)
            {
                TextBoxEFX.Focus();
                TextBoxEFX.Text = TextBoxEFX.Text.Insert(_expFunXSS, "2");
                _expFunXSS++;
                
                TextBoxEFX.SelectionStart = _expFunXSS;
                _charChecker.IsCommaCheckerExpFunXMethod();
                _charChecker.IsMinusCheckerExpFunXMethod();
                
            }
        }

        private void ButtonThreeBtn_Click(object sender, EventArgs e)
        {
            var _expFunASS = TextBoxEFA.SelectionStart;
            
            if (Checked._checkedTextBoxEFA == true)
            {
                TextBoxEFA.Focus();
                TextBoxEFA.Text = TextBoxEFA.Text.Insert(_expFunASS, "3");
                _expFunASS++;
                
                TextBoxEFA.SelectionStart = _expFunASS;
                _charChecker.IsCommaCheckerExpFunAMethod();
                _charChecker.IsMinusCheckerExpFunAMethod();

            }
            var _expFunXSS = TextBoxEFX.SelectionStart;
            if (Checked._checkedTextBoxEFX == true)
            {
                TextBoxEFX.Focus();
                TextBoxEFX.Text = TextBoxEFX.Text.Insert(_expFunXSS, "3");
                _expFunXSS++;
               
                TextBoxEFX.SelectionStart = _expFunXSS;
                _charChecker.IsCommaCheckerExpFunXMethod();
                _charChecker.IsMinusCheckerExpFunXMethod();
               
            }
        }

        private void ButtonFourBtn_Click(object sender, EventArgs e)
        {
            var _expFunASS = TextBoxEFA.SelectionStart;
            if (Checked._checkedTextBoxEFA == true)
            {
                TextBoxEFA.Focus();
                TextBoxEFA.Text = TextBoxEFA.Text.Insert(_expFunASS, "4");
                _expFunASS++;
                
                TextBoxEFA.SelectionStart = _expFunASS;
                _charChecker.IsCommaCheckerExpFunAMethod();
                _charChecker.IsMinusCheckerExpFunAMethod();

            }
            var _expFunXSS = TextBoxEFX.SelectionStart;
            if (Checked._checkedTextBoxEFX == true)
            {
                TextBoxEFX.Focus();
                TextBoxEFX.Text = TextBoxEFX.Text.Insert(_expFunXSS, "4");
                _expFunXSS++;
                
                TextBoxEFX.SelectionStart = _expFunXSS;
                _charChecker.IsCommaCheckerExpFunXMethod();
                _charChecker.IsMinusCheckerExpFunXMethod();
                
            }
        }

        private void ButtonFiveBtn_Click(object sender, EventArgs e)
        {
            var _expFunASS = TextBoxEFA.SelectionStart;
            
            if (Checked._checkedTextBoxEFA == true)
            {
                TextBoxEFA.Focus();
                TextBoxEFA.Text = TextBoxEFA.Text.Insert(_expFunASS, "5");
                _expFunASS++;
                
                TextBoxEFA.SelectionStart = _expFunASS;
                _charChecker.IsCommaCheckerExpFunAMethod();
                _charChecker.IsMinusCheckerExpFunAMethod();
                

            }
            var _expFunXSS = TextBoxEFX.SelectionStart;
            if (Checked._checkedTextBoxEFX == true)
            {
                TextBoxEFX.Focus();
                TextBoxEFX.Text = TextBoxEFX.Text.Insert(_expFunXSS, "5");
                _expFunXSS++;
                
                TextBoxEFX.SelectionStart = _expFunXSS;
                _charChecker.IsCommaCheckerExpFunXMethod();
                _charChecker.IsMinusCheckerExpFunXMethod();
                
            }
        }

        private void ButtonSixBtn_Click(object sender, EventArgs e)
        {
            var _expFunASS = TextBoxEFA.SelectionStart;
            
            if (Checked._checkedTextBoxEFA == true)
            {
                TextBoxEFA.Focus();
                TextBoxEFA.Text = TextBoxEFA.Text.Insert(_expFunASS, "6");
                _expFunASS++;
               
                TextBoxEFA.SelectionStart = _expFunASS;
                _charChecker.IsCommaCheckerExpFunAMethod();
                _charChecker.IsMinusCheckerExpFunAMethod();

            }
            var _expFunXSS = TextBoxEFX.SelectionStart;
            if (Checked._checkedTextBoxEFX == true)
            {
                TextBoxEFX.Focus();
                TextBoxEFX.Text = TextBoxEFX.Text.Insert(_expFunXSS, "6");
                _expFunXSS++;
                
                TextBoxEFX.SelectionStart = _expFunXSS;
                _charChecker.IsCommaCheckerExpFunXMethod();
                _charChecker.IsMinusCheckerExpFunXMethod();
                
            }
        }

        private void ButtonSevenBtn_Click(object sender, EventArgs e)
        {
            var _expFunASS = TextBoxEFA.SelectionStart;
           
            if (Checked._checkedTextBoxEFA == true)
            {
                TextBoxEFA.Focus();
                TextBoxEFA.Text = TextBoxEFA.Text.Insert(_expFunASS, "7");
                _expFunASS++;
                
                TextBoxEFA.SelectionStart = _expFunASS;
                _charChecker.IsCommaCheckerExpFunAMethod();
                _charChecker.IsMinusCheckerExpFunAMethod();

            }
            var _expFunXSS = TextBoxEFX.SelectionStart;
            if (Checked._checkedTextBoxEFX == true)
            {
                TextBoxEFX.Focus();
                TextBoxEFX.Text = TextBoxEFX.Text.Insert(_expFunXSS, "7");
                _expFunXSS++;
                
                TextBoxEFX.SelectionStart = _expFunXSS;
                _charChecker.IsCommaCheckerExpFunXMethod();
                _charChecker.IsMinusCheckerExpFunXMethod();
            }
        }

        private void ButtonEightBtn_Click(object sender, EventArgs e)
        {
            var _expFunASS = TextBoxEFA.SelectionStart;
            
            if (Checked._checkedTextBoxEFA == true)
            {
                TextBoxEFA.Focus();
                TextBoxEFA.Text = TextBoxEFA.Text.Insert(_expFunASS, "8");
                _expFunASS++;
                
                TextBoxEFA.SelectionStart = _expFunASS;
                _charChecker.IsCommaCheckerExpFunAMethod();
                _charChecker.IsMinusCheckerExpFunAMethod();

            }
            var _expFunXSS = TextBoxEFX.SelectionStart;
            if (Checked._checkedTextBoxEFX == true)
            {
                TextBoxEFX.Focus();
                TextBoxEFX.Text = TextBoxEFX.Text.Insert(_expFunXSS, "8");
                _expFunXSS++;
                
                TextBoxEFX.SelectionStart = _expFunXSS;
                _charChecker.IsCommaCheckerExpFunXMethod();
                _charChecker.IsMinusCheckerExpFunXMethod();
                
            }
        }

        private void ButtonNineBtn_Click(object sender, EventArgs e)
        {
            var _expFunASS = TextBoxEFA.SelectionStart;
            
            if (Checked._checkedTextBoxEFA == true)
            {
                TextBoxEFA.Focus();
                TextBoxEFA.Text = TextBoxEFA.Text.Insert(_expFunASS, "9");
                _expFunASS++;
                
                TextBoxEFA.SelectionStart = _expFunASS;
                _charChecker.IsCommaCheckerExpFunAMethod();
                _charChecker.IsMinusCheckerExpFunAMethod();

            }
            var _expFunXSS = TextBoxEFX.SelectionStart;
            if (Checked._checkedTextBoxEFX == true)
            {
                TextBoxEFX.Focus();
                TextBoxEFX.Text = TextBoxEFX.Text.Insert(_expFunXSS, "9");
                _expFunXSS++;
               
                TextBoxEFX.SelectionStart = _expFunXSS;
                _charChecker.IsCommaCheckerExpFunXMethod();
                _charChecker.IsMinusCheckerExpFunXMethod();
                
            }
        }

        private void ButtonZeroBtn_Click(object sender, EventArgs e)
        {
            var _expFunASS = TextBoxEFA.SelectionStart;
            
            if (Checked._checkedTextBoxEFA == true)
            {
                TextBoxEFA.Focus();
                TextBoxEFA.Text = TextBoxEFA.Text.Insert(_expFunASS, "0");
                _expFunASS++;
                
                TextBoxEFA.SelectionStart = _expFunASS;
                _charChecker.IsCommaCheckerExpFunAMethod();
                _charChecker.IsMinusCheckerExpFunAMethod();

            }
            var _expFunXSS = TextBoxEFX.SelectionStart;
            if (Checked._checkedTextBoxEFX == true)
            {
                TextBoxEFX.Focus();
                TextBoxEFX.Text = TextBoxEFX.Text.Insert(_expFunXSS, "0");
                _expFunXSS++;
                
                TextBoxEFX.SelectionStart = _expFunXSS;
                _charChecker.IsCommaCheckerExpFunXMethod();
                _charChecker.IsMinusCheckerExpFunXMethod();
                
            }
        }

        private void ButtonCommaEFBtn_Click(object sender, EventArgs e)
        {
            var _expFunASS = TextBoxEFA.SelectionStart;
            
            if (Checked._checkedTextBoxEFA == true)
            {
                TextBoxEFA.Focus();
                TextBoxEFA.Text = TextBoxEFA.Text.Insert(_expFunASS, ",");
                _expFunASS++;
               
                TextBoxEFA.SelectionStart = _expFunASS;
                _charChecker.IsCommaCheckerExpFunAMethod();
                _charChecker.IsMinusCheckerExpFunAMethod();

            }
            var _expFunXSS = TextBoxEFX.SelectionStart;
            if (Checked._checkedTextBoxEFX == true)
            {
                TextBoxEFX.Focus();
                TextBoxEFX.Text = TextBoxEFX.Text.Insert(_expFunXSS, ",");
                _expFunXSS++;
               
                TextBoxEFX.SelectionStart = _expFunXSS;
                _charChecker.IsCommaCheckerExpFunXMethod();
                _charChecker.IsMinusCheckerExpFunXMethod();
                
            }
        }

        private void ButtonMinusLinFunBtn_Click(object sender, EventArgs e)
        {
            var _expFunASS = TextBoxEFA.SelectionStart;
            
            if (Checked._checkedTextBoxEFA == true)
            {
                TextBoxEFA.Focus();
                TextBoxEFA.Text = TextBoxEFA.Text.Insert(_expFunASS, "-");
                _expFunASS++;
                
                TextBoxEFA.SelectionStart = _expFunASS;
                _charChecker.IsCommaCheckerExpFunAMethod();
                _charChecker.IsMinusCheckerExpFunAMethod();

            }
            var _expFunXSS = TextBoxEFX.SelectionStart;
            if (Checked._checkedTextBoxEFX == true)
            {
                TextBoxEFX.Focus();
                TextBoxEFX.Text = TextBoxEFX.Text.Insert(_expFunXSS, "-");
                _expFunXSS++;
                
                TextBoxEFX.SelectionStart = _expFunXSS;
                _charChecker.IsCommaCheckerExpFunXMethod();
                _charChecker.IsMinusCheckerExpFunXMethod();
                
            }
        }

        private void ButtonResultEFBtn_Click(object sender, EventArgs e)
        {
            String astr = TextBoxEFA.Text;
            double ad = Convert.ToDouble(astr);
            String xstr = TextBoxEFX.Text;
            double xd = Convert.ToDouble(ad);
            if (ad > 1.0)
            {
                LabelErrorEF.Text = "Wynik poprawny";
                for (int i = -20; i < 20; i++)
                {
                    ResultsValue._yEF = Math.Pow(ad, xd);
                    xd += 0.1;
                    WykresEFChart.Series["Series1"].Points.AddXY(xd, ResultsValue._yEF);

                }
            }
            else if (ad > 0.0 && ad < 1.0)
            {
                LabelErrorEF.Text = "Wynik poprawny";
                for (int i = -20; i < 20; i++)
                {
                    ResultsValue._yEF = Math.Pow(ad, xd);
                    xd += 0.1;
                    WykresEFChart.Series["Series1"].Points.AddXY(xd, ResultsValue._yEF);

                }
            }
            else if (ad < 0)
            {
                LabelErrorEF.Text = "a nie może być ujemne!!!";
            }
        }

        private void ButtonResetEFBtn_Click(object sender, EventArgs e)
        {
            WykresEFChart.Series["Series1"].Points.Clear();
            TextBoxEFA.Text = "";
            TextBoxEFX.Text = "";
            ResultsValue._yEF = 0.0;
            LabelErrorEF.Text = "";
        }

        private void ButtonStartDExpFBtn_Click(object sender, EventArgs e)
        {
            ButtonStartDExpFBtn.Enabled = false;
            ButtonDrawingExpFBtn.Enabled = true;

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
            Point _p2h = new Point(300, 150);
            g = PictureBoxDemFunExp.CreateGraphics();
            g.DrawLine(_pen, _p1v, _p2v);
            g.DrawLine(_pen, _p1h, _p2h);
            for (i += _xsclale + _x * overScale; i <= 300; i = i + 10)
            {
                Point _xsc = new Point(i, _yscale);
                Point _xsc2 = new Point(i, _yscale - 5);
                g.DrawLine(_pen, _xsc, _xsc2);

            }
            for (i += _xsclale - _x * overScale; i >= 0; i = i - 10)
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
            Font _xfont = new Font("Arial", 14);
            g.DrawString("X", _xfont, Brushes.White, new Point(280, 130));
            Font _yfont = new Font("Arial", 14);
            g.DrawString("Y", _yfont, Brushes.White, new Point(170, 20));
            Font _zero = new Font("Arial", 14);
            g.DrawString("0", _zero, Brushes.White, new Point(160, 120));
            g.Dispose();

        }

        private void ButtonDrawingExpFBtn_Click(object sender, EventArgs e)
        {
            float x_na_osi;
            float y_na_osi;
            float przepelnienie_x;
            float przeskalowanie = 20000000.0F;
            Pen _penCurve = new Pen(Color.Red, 1);
            g = PictureBoxDemFunExp.CreateGraphics();
            ButtonDrawingExpFBtn.Enabled = false;
            AmountElements._exponental_x_mes = -6.0F;
            while (AmountElements._exponental_x_mes < 6.0F)
            {
                AmountElements._exponental_y_mes =-(float)(5*Math.Pow(2,(double) AmountElements._exponental_x_mes));
                x_na_osi = AmountElements._exponental_x_mes+150.0F;
                y_na_osi = AmountElements._exponental_y_mes + 150.0F;

                PointF _pc1 = new PointF(x_na_osi, y_na_osi);
                AmountElements._exponental_x_mes = AmountElements._exponental_x_mes + 0.02F;
                AmountElements._exponental_y_mes = -(float)(5*Math.Pow(2, (double) AmountElements._exponental_x_mes));

                x_na_osi = x_na_osi + 0.02F;
                y_na_osi = (float)AmountElements._exponental_y_mes + 150.0F;
                PointF _pc2 = new PointF(x_na_osi, y_na_osi);
                
                przepelnienie_x = (float)AmountElements._exponental_x_mes;
                if (przepelnienie_x == 6.0F) break;
                g.DrawLine(_penCurve, _pc1, _pc2);
                
            }
        }
    }
}
