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
    public partial class MeasurableFunction : Form
    {
        private CharChecker _charChecker;
        private Graphics g;
        private int[] xmeasurtab = new int[20];
        private float[] ymeasurtab = new float[20];
        private int x_na_osi;
        private float y_na_osi;
        
        public MeasurableFunction()
        {
            InitializeComponent();
            _charChecker = new CharChecker(this);

            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Size = new Size(879, 488);
        }

        private void ButtonOneBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;
  
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "1");
                _MFSS++;
               
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
             }
        }

        private void TextBoxMF_MouseDown(object sender, MouseEventArgs e)
        {
            Checked._checkedTextBoxMFA = true;
            _charChecker.IsCommaChecherMFMethod();
            _charChecker.IsMinusCheckedMFMethod();
        }

        private void ButtonTwoBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "2");
                _MFSS++;
                
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
 
            }
        }

        private void ButtonThreeBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "3");
                _MFSS++;
                
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
 
            }
        }

        private void ButtonFourBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "4");
                _MFSS++;
                
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
 
            }
        }

        private void ButtonFiveBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "5");
                _MFSS++;
                
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();

            }
        }

        private void ButtonSixBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "6");
                _MFSS++;
                
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
 
            }
        }

        private void ButtonSevenBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

           
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "7");
                _MFSS++;
                
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
             }
        }

        private void ButtonEightBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

           
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "8");
                _MFSS++;
               
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
                
            }
        }

        private void ButtonNineBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "9");
                _MFSS++;
                
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
             }
        }

        private void ButtonZeroBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "0");
                _MFSS++;
                
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
             }
        }

        private void ButtonCommaMFBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

            
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, ",");
                _MFSS++;
                
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
             }
        }

        private void ButtonMinusMFBtn_Click(object sender, EventArgs e)
        {
            var _MFSS = TextBoxMF.SelectionStart;

           
            if (Checked._checkedTextBoxMFA == true)
            {
                TextBoxMF.Focus();
                TextBoxMF.Text = TextBoxMF.Text.Insert(_MFSS, "-");
                _MFSS++;
               
                TextBoxMF.SelectionStart = _MFSS;
                _charChecker.IsCommaChecherMFMethod();
                _charChecker.IsMinusCheckedMFMethod();
             }
        }

        private void MeasurableFunction_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.Parent = null;
        }

        private void ButtonResultMFBtn_Click(object sender, EventArgs e)
        {
            String MFStr = TextBoxMF.Text;
            
            double MFdouble = Convert.ToDouble(MFStr);
            
            for (int i = -20; i < 0; i++)
            {
                
                ResultsValue._yMF = MFdouble / i;
                WykresMFChart.Series["Series1"].Points.AddXY(i,ResultsValue._yMF);
            }
            for (int i = 1; i < 20; i++)
            {
                ResultsValue._yMF = MFdouble / i;
                WykresMFChart.Series["Series1"].Points.AddXY(i, ResultsValue._yMF);
            }
        }

        private void ButtonDrawingQFBtn_Click(object sender, EventArgs e)
        {
            Pen _penCurve = new Pen(Color.Red,2);
            Pen _penNameFunction = new Pen(Color.Red, 3);
            g = PictureBoxMFDemonstration.CreateGraphics();
            ButtonDrawingMFBtn.Enabled = false;
            int step = 1;
            
            AmountElements._measure_x_mes = -140.0F;
            while (AmountElements._measure_x_mes<0.0F)
           
            {
                AmountElements._measure_y_mes = -1300 / AmountElements._measure_x_mes;
                
                x_na_osi = (int)AmountElements._measure_x_mes + 150;
                y_na_osi = AmountElements._measure_y_mes + 151.0F;
                
                PointF _pc1 = new PointF((float)x_na_osi,y_na_osi);
                
                AmountElements._measure_x_mes = AmountElements._measure_x_mes+10;
                
                AmountElements._measure_y_mes = -1300 / AmountElements._measure_x_mes;
                x_na_osi = x_na_osi + 10;
                
                y_na_osi = AmountElements._measure_y_mes + 151.0F;
                PointF _pc2 = new PointF((float)x_na_osi,y_na_osi);
                if (AmountElements._measure_x_mes == 0) break;
                g.DrawLine(_penCurve, _pc1, _pc2);
             }
            AmountElements._measure_x_mes = 1.0F;
            while (AmountElements._measure_x_mes < 140.0F)
            {
                AmountElements._measure_y_mes = -1300 / AmountElements._measure_x_mes;
                x_na_osi = (int)AmountElements._measure_x_mes + 150;
                y_na_osi = AmountElements._measure_y_mes + 151.0F;

                PointF _pc1 = new PointF((float)x_na_osi, y_na_osi);
                AmountElements._measure_x_mes = AmountElements._measure_x_mes + 10;

                AmountElements._measure_y_mes = -1300 / AmountElements._measure_x_mes;
                x_na_osi = x_na_osi + 10;
                
                y_na_osi = AmountElements._measure_y_mes + 151.0F;
                PointF _pc2 = new PointF((float)x_na_osi, y_na_osi);
                if (AmountElements._measure_x_mes == 140.0F) break;
                g.DrawLine(_penCurve, _pc1, _pc2);
            }
            Font _leftSide = new Font("Arial", 14);
            g.DrawString("y=", _leftSide, Brushes.Red, new Point(2, 50));
            Font _upName = new Font("Arial", 14);
            g.DrawString("3", _upName, Brushes.Red, new Point(40, 30));

            Font _lineDivide = new Font("Arial", 14);
            g.DrawString("___", _lineDivide, Brushes.Red, new Point(30, 40));

            Font _downName = new Font("Arial", 14);
            g.DrawString("x", _downName, Brushes.Red, new Point(40, 60));
           
            ButtonResetDrawMFBtn.Enabled = true;
            g.Dispose();
        }

        private void ButtonResetDrawMFBtn_Click(object sender, EventArgs e)
        {
            ButtonResetDrawMFBtn.Enabled = false;
            g = PictureBoxMFDemonstration.CreateGraphics();
            g.Clear(Color.YellowGreen);
            ButtonResetDrawMFBtn.Enabled = false;
            ButtonStartDMFBtn.Enabled = true;
            
        }

        private void ButtonStartDMFBtn_Click(object sender, EventArgs e)
        {
            ButtonStartDMFBtn.Enabled = false;
            ButtonDrawingMFBtn.Enabled = true;
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
            g = PictureBoxMFDemonstration.CreateGraphics();
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

        private void ButtonResetQFBtn_Click(object sender, EventArgs e)
        {
            WykresMFChart.Series["Series1"].Points.Clear();
            TextBoxMF.Text = "";
            this.ButtonCommaMFBtn.Text = ",";
            this.ButtonMinusMFBtn.Text = "-";
        }
    }
}
