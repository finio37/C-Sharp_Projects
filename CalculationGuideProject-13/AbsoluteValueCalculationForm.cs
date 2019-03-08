using System;
using System.Text.RegularExpressions;
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
    public partial class AbsoluteValueCalculationForm : Form
    {
        List<char> _schar = new List<char>();
        private CharChecker _charChecker;
        private CalculationInTextBox _addingInString;
        Graphics g;
        public AbsoluteValueCalculationForm()
        {
            InitializeComponent();
            Checked._checkedValueToAbs = true;
            _charChecker = new CharChecker(this);
            _addingInString = new CalculationInTextBox(this);
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Size = new Size(887, 526);
        }
        private void ButtonOneBtn_Click(object sender, EventArgs e)
        {
            var _valueToAbsSS = ValueToAbsTxb.SelectionStart;
            if (Checked._checkedValueToAbs == true)
            {
                ValueToAbsTxb.Focus();
                ValueToAbsTxb.Text = ValueToAbsTxb.Text.Insert(_valueToAbsSS,"1");
                _valueToAbsSS++;
                ValueToAbsTxb.SelectionStart = _valueToAbsSS;
            }
        }
        private void ButtonTwoBtn_Click(object sender, EventArgs e)
        {
            var _valueToAbsSS = ValueToAbsTxb.SelectionStart;
            if (Checked._checkedValueToAbs == true)
            {
                ValueToAbsTxb.Focus();
                ValueToAbsTxb.Text = ValueToAbsTxb.Text.Insert(_valueToAbsSS, "2");
                _valueToAbsSS++;
                ValueToAbsTxb.SelectionStart = _valueToAbsSS;
            }
        }

        private void ButtonThreeBtn_Click(object sender, EventArgs e)
        {
            var _valueToAbsSS = ValueToAbsTxb.SelectionStart;
            if (Checked._checkedValueToAbs == true)
            {
                ValueToAbsTxb.Focus();
                ValueToAbsTxb.Text = ValueToAbsTxb.Text.Insert(_valueToAbsSS, "3");
                _valueToAbsSS++;
                ValueToAbsTxb.SelectionStart = _valueToAbsSS;
            }
        }

        private void ButtonFourBtn_Click(object sender, EventArgs e)
        {
            var _valueToAbsSS = ValueToAbsTxb.SelectionStart;
            if (Checked._checkedValueToAbs == true)
            {
                ValueToAbsTxb.Focus();
                ValueToAbsTxb.Text = ValueToAbsTxb.Text.Insert(_valueToAbsSS, "4");
                _valueToAbsSS++;
                ValueToAbsTxb.SelectionStart = _valueToAbsSS;
            }
        }

        private void ButtonFiveBtn_Click(object sender, EventArgs e)
        {
            var _valueToAbsSS = ValueToAbsTxb.SelectionStart;
            if (Checked._checkedValueToAbs == true)
            {
                ValueToAbsTxb.Focus();
                ValueToAbsTxb.Text = ValueToAbsTxb.Text.Insert(_valueToAbsSS, "5");
                _valueToAbsSS++;
                ValueToAbsTxb.SelectionStart = _valueToAbsSS;
            }
        }

        private void ButtonSixBtn_Click(object sender, EventArgs e)
        {
            var _valueToAbsSS = ValueToAbsTxb.SelectionStart;
            if (Checked._checkedValueToAbs == true)
            {
                ValueToAbsTxb.Focus();
                ValueToAbsTxb.Text = ValueToAbsTxb.Text.Insert(_valueToAbsSS, "6");
                _valueToAbsSS++;
                ValueToAbsTxb.SelectionStart = _valueToAbsSS;
            }
        }

        private void ButtonSevenBtn_Click(object sender, EventArgs e)
        {
            var _valueToAbsSS = ValueToAbsTxb.SelectionStart;
            if (Checked._checkedValueToAbs == true)
            {
                ValueToAbsTxb.Focus();
                ValueToAbsTxb.Text = ValueToAbsTxb.Text.Insert(_valueToAbsSS, "7");
                _valueToAbsSS++;
                ValueToAbsTxb.SelectionStart = _valueToAbsSS;
            }
        }

        private void ButtonEightBtn_Click(object sender, EventArgs e)
        {
            var _valueToAbsSS = ValueToAbsTxb.SelectionStart;
            if (Checked._checkedValueToAbs == true)
            {
                ValueToAbsTxb.Focus();
                ValueToAbsTxb.Text = ValueToAbsTxb.Text.Insert(_valueToAbsSS, "8");
                _valueToAbsSS++;
                ValueToAbsTxb.SelectionStart = _valueToAbsSS;
            }
        }

        private void ButtonNineBtn_Click(object sender, EventArgs e)
        {
            var _valueToAbsSS = ValueToAbsTxb.SelectionStart;
            if (Checked._checkedValueToAbs == true)
            {
                ValueToAbsTxb.Focus();
                ValueToAbsTxb.Text = ValueToAbsTxb.Text.Insert(_valueToAbsSS, "9");
                _valueToAbsSS++;
                ValueToAbsTxb.SelectionStart = _valueToAbsSS;
            }
        }

        private void ButtonZeroBtn_Click(object sender, EventArgs e)
        {
            var _valueToAbsSS = ValueToAbsTxb.SelectionStart;
            if (Checked._checkedValueToAbs == true)
            {
                ValueToAbsTxb.Focus();
                ValueToAbsTxb.Text = ValueToAbsTxb.Text.Insert(_valueToAbsSS, "0");
                _valueToAbsSS++;
                ValueToAbsTxb.SelectionStart = _valueToAbsSS;
            }
        }

        private void ButtonCommaBtn_Click(object sender, EventArgs e)
        {
            var _valueToAbsSS = ValueToAbsTxb.SelectionStart;
            if (Checked._checkedValueToAbs == true)
            {
                ValueToAbsTxb.Focus();
                ValueToAbsTxb.Text = ValueToAbsTxb.Text.Insert(_valueToAbsSS, ",");
                _valueToAbsSS++;
                ValueToAbsTxb.SelectionStart = _valueToAbsSS;
            }
        }

        private void ValueToAbsTxb_MouseDown(object sender, MouseEventArgs e)
        {
            Checked._checkedValueToAbs = true;
            Checked._checkedTextBoxLinFunA = false;
            Checked._checkedTextBoxLinFunB = false;
        }

        private void ButtonMinusBtn_Click(object sender, EventArgs e)
        {
            var _valueToAbsSS = ValueToAbsTxb.SelectionStart;
            if (Checked._checkedValueToAbs == true)
            {
                ValueToAbsTxb.Focus();
                ValueToAbsTxb.Text = ValueToAbsTxb.Text.Insert(_valueToAbsSS, "-");
                _valueToAbsSS++;
                ValueToAbsTxb.SelectionStart = _valueToAbsSS;
            }
        }

        private void ButtonPlusBtn_Click(object sender, EventArgs e)
        {
            var _valueToAbsSS = ValueToAbsTxb.SelectionStart;
           
            if (Checked._checkedValueToAbs == true)
            {
                ValueToAbsTxb.Focus();
                ValueToAbsTxb.Text = ValueToAbsTxb.Text.Insert(_valueToAbsSS, "+");
                _valueToAbsSS++;
                ValueToAbsTxb.SelectionStart = _valueToAbsSS;
             }
        }

        private void ButtonResoultBtn_Click(object sender, EventArgs e)
        {

            String str = ValueToAbsTxb.Text;
           
            int _resultAbs = 0;
            int _resultGeneral = 0;
            _resultGeneral= _addingInString.DoingMathOperationInString(str);
            _resultAbs = _addingInString.AbsDoing(_resultGeneral);

            LabelResoultLbl.Text = _resultAbs.ToString();
                
        }

        private void AbsoluteValueCalculationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.Parent = null;
        }

        private void ButtonMultBtn_Click(object sender, EventArgs e)
        {
            var _valueToAbsSS = ValueToAbsTxb.SelectionStart;
            if (Checked._checkedValueToAbs == true)
            {
                ValueToAbsTxb.Focus();
                ValueToAbsTxb.Text = ValueToAbsTxb.Text.Insert(_valueToAbsSS, "*");
                _valueToAbsSS++;
                ValueToAbsTxb.SelectionStart = _valueToAbsSS;
            }
        }

        private void ButtonDivBtn_Click(object sender, EventArgs e)
        {
            var _valueToAbsSS = ValueToAbsTxb.SelectionStart;
            if (Checked._checkedValueToAbs == true)
            {
                ValueToAbsTxb.Focus();
                ValueToAbsTxb.Text = ValueToAbsTxb.Text.Insert(_valueToAbsSS, "/");
                _valueToAbsSS++;
                ValueToAbsTxb.SelectionStart = _valueToAbsSS;
            }
        }

        private void ButtonResetBtn_Click(object sender, EventArgs e)
        {
            ValueToAbsTxb.Text = "";
            LabelResoultLbl.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            String zero_str = "0";
            Font _font = new Font("Arial", 16);
            SolidBrush _solidBrush = new SolidBrush(Color.White);
            float _x = 260.0F;
            float _y = 180.0F;
            StringFormat sf = new StringFormat();
            Pen _pen = new Pen(Color.Red,4);
            Point _point1 = new Point(10,160);
            Point _point2 = new Point(550, 160);
            Point _arrow1 = new Point(520,140);
            Point _arrow2 = new Point(550, 160);
            Point _arrow3 = new Point(520, 180);
            Point _arrow4 = new Point(550, 160);
            Point _zero1 = new Point(270, 150);
            Point _zero2 = new Point(270, 170);
            g = PictureBox.CreateGraphics();
            g.DrawLine(_pen,_point1,_point2);
            g.DrawLine(_pen, _arrow1, _arrow2);
            g.DrawLine(_pen, _arrow3, _arrow4);
            g.DrawLine(_pen, _zero1, _zero2);
            g.DrawString(zero_str,_font,_solidBrush,_x,_y);
            g.Dispose();
            ButtonDrawMinus6.Enabled = true;
        }

        private void ButtonDrawMinus6_Click(object sender, EventArgs e)
        {
            Pen _pen = new Pen(Color.Blue, 4);
            Point _p1 = new Point(10, 120);
            Point _p2 = new Point(270, 120);

            Point _p1_vert = new Point(10, 110);
            Point _p2_vert = new Point(10, 130);

            Point _p3_vert = new Point(270, 110);
            Point _p4_vert = new Point(270, 130);

            String zero_str = "-6";
            Font _font = new Font("Arial", 16);
            SolidBrush _solidBrush = new SolidBrush(Color.White);
            float _x = 130.0F;
            float _y = 60.0F;
            StringFormat sf = new StringFormat();

            g = PictureBox.CreateGraphics();
            g.DrawLine(_pen, _p1, _p2);
            g.DrawLine(_pen, _p1_vert, _p2_vert);
            g.DrawLine(_pen, _p3_vert, _p4_vert);
            g.DrawString(zero_str, _font, _solidBrush, _x, _y);
            g.Dispose();
            ButtonDrawMinus6.Enabled = false;
            ButtonAbsBtn.Enabled = true;

        }

        private void ButtonAbsBtn_Click(object sender, EventArgs e)
        {
            Pen _pen = new Pen(Color.White, 4);
            Point _p1 = new Point(270,100);
            Point _p2 = new Point(550, 100);
            String _descriptionAbs = "Absolute value = 6";
            Font _font = new Font("Arial", 16);
            SolidBrush _solidBrush = new SolidBrush(Color.White);
            float _x = 300.0F;
            float _y = 60.0F;
            StringFormat sf = new StringFormat();
            Point _vp1 = new Point(270,90);
            Point _vp2 = new Point(270, 110);

            Point _vp3 = new Point(550, 90);
            Point _vp4 = new Point(550, 110);

            g = PictureBox.CreateGraphics();
            g.DrawLine(_pen, _p1, _p2);
            g.DrawLine(_pen, _vp1, _vp2);
            g.DrawLine(_pen, _vp3, _vp4);
            g.DrawString(_descriptionAbs, _font, _solidBrush, _x, _y);
            g.Dispose();

            ButtonAbsBtn.Enabled = false;
            ButtonResetPAbesBtn.Enabled = true;

        }

        private void ButtonResetPAbesBtn_Click(object sender, EventArgs e)
        {
            g = PictureBox.CreateGraphics();
            g.Clear(Color.Green);
            ButtonResetPAbesBtn.Enabled = false;
            button1.Enabled = true;
        }
    }
}
