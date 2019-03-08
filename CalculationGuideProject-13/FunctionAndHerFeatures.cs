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
    public partial class FunctionAndHerFeatures : Form
    {
        private CharChecker _charChecker;
        private int _licznikZer = 0;
        
        private double _a = 0;
        private double _b = 0;
        Graphics g;
        public FunctionAndHerFeatures()
        {
            InitializeComponent();
            Checked._checkedTextBoxLinFunA = true;
            Checked._checkedTextBoxLinFunB = true;
            _charChecker = new CharChecker(this);
            ZerosCounter._zerosCounter = 0;

            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
           this.Size = new Size(912, 472);
        }

        private void TextBoxLinFunA_MouseDown(object sender, MouseEventArgs e)
        {
            Checked._checkedValueToAbs = false;
            Checked._checkedTextBoxLinFunA = true;
            Checked._checkedTextBoxLinFunB = false;
            _charChecker.IsCommaCheckerFunLinAMethod();
            _charChecker.IsMinusCheckerFunLinAMethod();
         }

        private void TextBoxLinFunB_MouseDown(object sender, MouseEventArgs e)
        {
            Checked._checkedValueToAbs = false;
            Checked._checkedTextBoxLinFunA = false;
            Checked._checkedTextBoxLinFunB = true;
            _charChecker.IsCommaCheckerFunLinBMethod();
            _charChecker.IsMinusCheckerFunLinBMethod();

        }

        private void ButtonOneBtn_Click(object sender, EventArgs e)
        {
            var _linFunSS = TextBoxLinFunA.SelectionStart;
            
            
            if (Checked._checkedTextBoxLinFunA == true)
            {
                TextBoxLinFunA.Focus();
                TextBoxLinFunA.Text = TextBoxLinFunA.Text.Insert(_linFunSS, "1");
                _linFunSS++;
                _a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxLinFunA.SelectionStart = _linFunSS;
                _charChecker.IsCommaCheckerFunLinAMethod();
                _charChecker.IsMinusCheckerFunLinAMethod();
             }
            var _linFunSSB = TextBoxLinFunB.SelectionStart;
            if (Checked._checkedTextBoxLinFunB == true)
            {
                TextBoxLinFunB.Focus();
                TextBoxLinFunB.Text = TextBoxLinFunB.Text.Insert(_linFunSSB, "1");
                _linFunSSB++;
                _b += Convert.ToDouble(TextBoxLinFunB.Text);
                TextBoxLinFunB.SelectionStart = _linFunSSB;
                _charChecker.IsCommaCheckerFunLinBMethod();
                _charChecker.IsMinusCheckerFunLinBMethod();
            }
        }

        private void FunctionAndHerFeatures_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.Parent = null;
        }

        private void ButtonTwoBtn_Click(object sender, EventArgs e)
        {
            var _linFunSS = TextBoxLinFunA.SelectionStart;

          
            if (Checked._checkedTextBoxLinFunA == true)
            {
                TextBoxLinFunA.Focus();
                TextBoxLinFunA.Text = TextBoxLinFunA.Text.Insert(_linFunSS, "2");
                _linFunSS++;
                _a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxLinFunA.SelectionStart = _linFunSS;
                _charChecker.IsCommaCheckerFunLinAMethod();
                _charChecker.IsMinusCheckerFunLinAMethod();
             }
            var _linFunSSB = TextBoxLinFunB.SelectionStart;
            if (Checked._checkedTextBoxLinFunB == true)
            {
                TextBoxLinFunB.Focus();
                TextBoxLinFunB.Text = TextBoxLinFunB.Text.Insert(_linFunSSB, "2");
                _linFunSSB++;
                _b += Convert.ToDouble(TextBoxLinFunB.Text);
                TextBoxLinFunB.SelectionStart = _linFunSSB;
                _charChecker.IsCommaCheckerFunLinBMethod();
                _charChecker.IsMinusCheckerFunLinBMethod();
            }
        }

        private void ButtonThreeBtn_Click(object sender, EventArgs e)
        {
            var _linFunSS = TextBoxLinFunA.SelectionStart;
            if (Checked._checkedTextBoxLinFunA == true)
            {
                TextBoxLinFunA.Focus();
                TextBoxLinFunA.Text = TextBoxLinFunA.Text.Insert(_linFunSS, "3");
                _linFunSS++;
                _a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxLinFunA.SelectionStart = _linFunSS;
                _charChecker.IsCommaCheckerFunLinAMethod();
                _charChecker.IsMinusCheckerFunLinAMethod();
             }
            var _linFunSSB = TextBoxLinFunB.SelectionStart;
            if (Checked._checkedTextBoxLinFunB == true)
            {
                TextBoxLinFunB.Focus();
                TextBoxLinFunB.Text = TextBoxLinFunB.Text.Insert(_linFunSSB, "3");
                _linFunSSB++;
                _b += Convert.ToDouble(TextBoxLinFunB.Text);
                TextBoxLinFunB.SelectionStart = _linFunSSB;
                _charChecker.IsCommaCheckerFunLinBMethod();
                _charChecker.IsMinusCheckerFunLinBMethod();
            }
        }

        private void ButtonFourBtn_Click(object sender, EventArgs e)
        {
            var _linFunSS = TextBoxLinFunA.SelectionStart;
            if (Checked._checkedTextBoxLinFunA == true)
            {
                TextBoxLinFunA.Focus();
                TextBoxLinFunA.Text = TextBoxLinFunA.Text.Insert(_linFunSS, "4");
                _linFunSS++;
                _a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxLinFunA.SelectionStart = _linFunSS;
                _charChecker.IsCommaCheckerFunLinAMethod();
                _charChecker.IsMinusCheckerFunLinAMethod();
            }
            var _linFunSSB = TextBoxLinFunB.SelectionStart;
            if (Checked._checkedTextBoxLinFunB == true)
            {
                TextBoxLinFunB.Focus();
                TextBoxLinFunB.Text = TextBoxLinFunB.Text.Insert(_linFunSSB, "4");
                _linFunSSB++;
                _b += Convert.ToDouble(TextBoxLinFunB.Text);
                TextBoxLinFunB.SelectionStart = _linFunSSB;
                _charChecker.IsCommaCheckerFunLinBMethod();
                _charChecker.IsMinusCheckerFunLinBMethod();
            }
        }

        private void ButtonFiveBtn_Click(object sender, EventArgs e)
        {
            var _linFunSS = TextBoxLinFunA.SelectionStart;

            if (Checked._checkedTextBoxLinFunA == true)
            {
                TextBoxLinFunA.Focus();
                TextBoxLinFunA.Text = TextBoxLinFunA.Text.Insert(_linFunSS, "5");
                _linFunSS++;
                _a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxLinFunA.SelectionStart = _linFunSS;
                _charChecker.IsCommaCheckerFunLinAMethod();
                _charChecker.IsMinusCheckerFunLinAMethod();
             }
            var _linFunSSB = TextBoxLinFunB.SelectionStart;
            if (Checked._checkedTextBoxLinFunB == true)
            {
                TextBoxLinFunB.Focus();
                TextBoxLinFunB.Text = TextBoxLinFunB.Text.Insert(_linFunSSB, "5");
                _linFunSSB++;
                _b += Convert.ToDouble(TextBoxLinFunB.Text);
                TextBoxLinFunB.SelectionStart = _linFunSSB;
                _charChecker.IsCommaCheckerFunLinBMethod();
                _charChecker.IsMinusCheckerFunLinBMethod();
            }
        }

        private void ButtonSixBtn_Click(object sender, EventArgs e)
        {
            var _linFunSS = TextBoxLinFunA.SelectionStart;
            if (Checked._checkedTextBoxLinFunA == true)
            {
                TextBoxLinFunA.Focus();
                TextBoxLinFunA.Text = TextBoxLinFunA.Text.Insert(_linFunSS, "6");
                _linFunSS++;
                _a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxLinFunA.SelectionStart = _linFunSS;
                _charChecker.IsCommaCheckerFunLinAMethod();
                _charChecker.IsMinusCheckerFunLinAMethod();
            }
            var _linFunSSB = TextBoxLinFunB.SelectionStart;
            if (Checked._checkedTextBoxLinFunB == true)
            {
                TextBoxLinFunB.Focus();
                TextBoxLinFunB.Text = TextBoxLinFunB.Text.Insert(_linFunSSB, "6");
                _linFunSSB++;
                _b += Convert.ToDouble(TextBoxLinFunB.Text);
                TextBoxLinFunB.SelectionStart = _linFunSSB;
                _charChecker.IsCommaCheckerFunLinBMethod();
                _charChecker.IsMinusCheckerFunLinBMethod();
            }
        }

        private void ButtonSevenBtn_Click(object sender, EventArgs e)
        {
            var _linFunSS = TextBoxLinFunA.SelectionStart;
            if (Checked._checkedTextBoxLinFunA == true)
            {
                TextBoxLinFunA.Focus();
                TextBoxLinFunA.Text = TextBoxLinFunA.Text.Insert(_linFunSS, "7");
                _linFunSS++;
                _a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxLinFunA.SelectionStart = _linFunSS;
                _charChecker.IsCommaCheckerFunLinAMethod();
                _charChecker.IsMinusCheckerFunLinAMethod();
             }
            var _linFunSSB = TextBoxLinFunB.SelectionStart;
            if (Checked._checkedTextBoxLinFunB == true)
            {
                TextBoxLinFunB.Focus();
                TextBoxLinFunB.Text = TextBoxLinFunB.Text.Insert(_linFunSSB, "7");
                _linFunSSB++;
                _b += Convert.ToDouble(TextBoxLinFunB.Text);
                TextBoxLinFunB.SelectionStart = _linFunSSB;
                _charChecker.IsCommaCheckerFunLinBMethod();
                _charChecker.IsMinusCheckerFunLinBMethod();
            }
        }

        private void ButtonEightBtn_Click(object sender, EventArgs e)
        {
            var _linFunSS = TextBoxLinFunA.SelectionStart;

            
            if (Checked._checkedTextBoxLinFunA == true)
            {
                TextBoxLinFunA.Focus();
                TextBoxLinFunA.Text = TextBoxLinFunA.Text.Insert(_linFunSS, "8");
                _linFunSS++;
                _a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxLinFunA.SelectionStart = _linFunSS;
                _charChecker.IsCommaCheckerFunLinAMethod();
                _charChecker.IsMinusCheckerFunLinAMethod();
             }
            var _linFunSSB = TextBoxLinFunB.SelectionStart;
            if (Checked._checkedTextBoxLinFunB == true)
            {
                TextBoxLinFunB.Focus();
                TextBoxLinFunB.Text = TextBoxLinFunB.Text.Insert(_linFunSSB, "8");
                _linFunSSB++;
                _b += Convert.ToDouble(TextBoxLinFunB.Text);
                TextBoxLinFunB.SelectionStart = _linFunSSB;
                _charChecker.IsCommaCheckerFunLinBMethod();
                _charChecker.IsMinusCheckerFunLinBMethod();
            }
        }

        private void ButtonNineBtn_Click(object sender, EventArgs e)
        {
            var _linFunSS = TextBoxLinFunA.SelectionStart;
            if (Checked._checkedTextBoxLinFunA == true)
            {
                TextBoxLinFunA.Focus();
                TextBoxLinFunA.Text = TextBoxLinFunA.Text.Insert(_linFunSS, "9");
                _linFunSS++;
                _a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxLinFunA.SelectionStart = _linFunSS;
                _charChecker.IsCommaCheckerFunLinAMethod();
                _charChecker.IsMinusCheckerFunLinAMethod();
            }
            var _linFunSSB = TextBoxLinFunB.SelectionStart;
            if (Checked._checkedTextBoxLinFunB == true)
            {
                TextBoxLinFunB.Focus();
                TextBoxLinFunB.Text = TextBoxLinFunB.Text.Insert(_linFunSSB, "9");
                _linFunSSB++;
                _b += Convert.ToDouble(TextBoxLinFunB.Text);
                TextBoxLinFunB.SelectionStart = _linFunSSB;
                _charChecker.IsCommaCheckerFunLinBMethod();
                _charChecker.IsMinusCheckerFunLinBMethod();
            }
        }

        private void ButtonZeroBtn_Click(object sender, EventArgs e)
        {
            var _linFunSS = TextBoxLinFunA.SelectionStart;
             if (Checked._checkedTextBoxLinFunA == true)
            {
                TextBoxLinFunA.Focus();
                TextBoxLinFunA.Text = TextBoxLinFunA.Text.Insert(_linFunSS, "0");
                _linFunSS++;
                _a += Convert.ToDouble(TextBoxLinFunA.Text);
                TextBoxLinFunA.SelectionStart = _linFunSS;
                
                _charChecker.IsCommaCheckerFunLinAMethod();
                _charChecker.IsMinusCheckerFunLinAMethod();
             }
            var _linFunSSB = TextBoxLinFunB.SelectionStart;
            if (Checked._checkedTextBoxLinFunB == true)
            {
                TextBoxLinFunB.Focus();
                TextBoxLinFunB.Text = TextBoxLinFunB.Text.Insert(_linFunSSB, "0");
                _linFunSSB++;
                _b += Convert.ToDouble(TextBoxLinFunB.Text);
                TextBoxLinFunB.SelectionStart = _linFunSSB;
                _charChecker.IsCommaCheckerFunLinBMethod();
                _charChecker.IsMinusCheckerFunLinBMethod();
            }
        }

        private void ButtonCommaLinFunBtn_Click(object sender, EventArgs e)
        {
            var _linFunSS = TextBoxLinFunA.SelectionStart;
            if (Checked._checkedTextBoxLinFunA == true)
            {
                TextBoxLinFunA.Focus();
                TextBoxLinFunA.Text = TextBoxLinFunA.Text.Insert(_linFunSS, ",");
                _linFunSS++;

                TextBoxLinFunA.SelectionStart = _linFunSS;
                _charChecker.IsCommaCheckerFunLinAMethod();
                _charChecker.IsMinusCheckerFunLinAMethod();
             }
            var _linFunSSB = TextBoxLinFunB.SelectionStart;
            if (Checked._checkedTextBoxLinFunB == true)
            {
                TextBoxLinFunB.Focus();
                TextBoxLinFunB.Text = TextBoxLinFunB.Text.Insert(_linFunSSB, ",");
                _linFunSSB++;
                TextBoxLinFunB.SelectionStart = _linFunSSB;
                _charChecker.IsCommaCheckerFunLinBMethod();
                _charChecker.IsMinusCheckerFunLinBMethod();
            }
        }

        private void ButtonMinusLinFunBtn_Click(object sender, EventArgs e)
        {
            var _linFunSS = TextBoxLinFunA.SelectionStart;

            
            if (Checked._checkedTextBoxLinFunA == true)
            {
                TextBoxLinFunA.Focus();
                TextBoxLinFunA.Text = TextBoxLinFunA.Text.Insert(_linFunSS, "-");
                _linFunSS++;
                TextBoxLinFunA.SelectionStart = _linFunSS;
                _charChecker.IsCommaCheckerFunLinAMethod();
                _charChecker.IsMinusCheckerFunLinAMethod();
             }
            var _linFunSSB = TextBoxLinFunB.SelectionStart;
            if (Checked._checkedTextBoxLinFunB == true)
            {
                TextBoxLinFunB.Focus();
                TextBoxLinFunB.Text = TextBoxLinFunB.Text.Insert(_linFunSSB, "-");
                _linFunSSB++;
                TextBoxLinFunB.SelectionStart = _linFunSSB;
                _charChecker.IsCommaCheckerFunLinBMethod();
                _charChecker.IsMinusCheckerFunLinBMethod();
            }
        }

        private void ButtonResultLinFunBtn_Click(object sender, EventArgs e)
        {
            double wspolFunLina = Convert.ToDouble(TextBoxLinFunA.Text);
            double wspolFunLinb = Convert.ToDouble(TextBoxLinFunB.Text);

            for (int i = -20; i < 20; i++)
            {
                ResultsValue._linFunRelultValue = wspolFunLina * i + wspolFunLinb;
                ChartWykresFunLin.Series["Series1"].Points.AddXY(i,ResultsValue._linFunRelultValue);

            }
            double _miejsceZeroweFunLin = -wspolFunLinb / wspolFunLina;
            LabelMiejsceZerowe.Text = Convert.ToString(Math.Round(_miejsceZeroweFunLin,2));
            if (wspolFunLina > 0)
            {
                LabelRosFunLin.Text = "Tak";
                LabelMalFunLin.Text = "Nie";
            }
            else
            {
                LabelRosFunLin.Text = "Nie";
                LabelMalFunLin.Text = "Tak";
            }
        }

        private void ButtonStartDemFunLinBtn_Click(object sender, EventArgs e)
        {
            ButtonStartDemFunLinBtn.Enabled = false;
            Pen _pen = new Pen(Color.LightGray);
            Point _p1 = new Point(150,0);
            Point _p2 = new Point(150, 293);
            Point _p3 = new Point(0, 145);
            Point _p4 = new Point(311, 145);

            Point _st1 = new Point(140,10);
            Point _st2 = new Point(150, 0);

            Point _st3 = new Point(150, 0);
            Point _st4 = new Point(160,10);

            Point _st1_y = new Point(301, 135);
            Point _st2_y = new Point(311, 145);
            Point _st3_y = new Point(301, 155);
            Point _st4_y = new Point(311, 145);
            String _strx = "x";
            String _stry = "y";
            Font _font = new Font("Arial", 16);
            SolidBrush _solidBrush = new SolidBrush(Color.White);
            StringFormat sf = new StringFormat();
            float _x_strx = 165.0F;
            float _y_strx = 5.0F;

            float _x_stry = 290.0F;
            float _y_stry = 110.0F;

            g = PictureBoxDemFunLin.CreateGraphics();
            g.DrawLine(_pen, _p1, _p2);
            g.DrawLine(_pen, _st1, _st2);
            g.DrawLine(_pen, _st3, _st4);

            g.DrawLine(_pen, _p3, _p4);

            g.DrawLine(_pen, _st1_y, _st2_y);
            g.DrawLine(_pen, _st3_y, _st4_y);
            g.DrawString(_strx, _font, _solidBrush, _x_strx, _y_strx);
            g.DrawString(_stry, _font, _solidBrush, _x_stry, _y_stry);
            g.Dispose();
            ButtonDrawLinFunBtn.Enabled = true;
        }

        private void ButtonDrawLinFunBtn_Click(object sender, EventArgs e)
        {
            ButtonDrawLinFunBtn.Enabled = false;
            Pen _penLinearFunction = new Pen(Color.Red);
            Point _p1 = new Point(100,293);
            Point _p2 = new Point(200, 0);
            g = PictureBoxDemFunLin.CreateGraphics();
            g.DrawLine(_penLinearFunction, _p1, _p2);
            g.Dispose();

            ButtonResetDrawingBtn.Enabled = true;
        }

        private void ButtonResetDrawingBtn_Click(object sender, EventArgs e)
        {
            ButtonResetDrawingBtn.Enabled = false;
            g = PictureBoxDemFunLin.CreateGraphics();
            g.Clear(Color.Green);
            
            ButtonStartDemFunLinBtn.Enabled = true;
        }

        private void ButtonResetLFBtn_Click(object sender, EventArgs e)
        {
            ChartWykresFunLin.Series["Series1"].Points.Clear();
            TextBoxLinFunA.Text = "";
            TextBoxLinFunB.Text = "";
            LabelMiejsceZerowe.Text = "";
            LabelRosFunLin.Text = "";
            LabelMalFunLin.Text = "";
            this.ButtonCommaLinFunBtn.Text = ",";
            this.ButtonMinusLinFunBtn.Text = "-";

        }
    }
}
