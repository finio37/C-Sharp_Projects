using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationGuideProject
{
    public class CalculationInTextBox
    {
        private AbsoluteValueCalculationForm _asbValueCF;
        private List<Char> _strList = new List<Char>();
        private String _strFromTextBox;
        private String _str;
        char[] _charsTab = new char[5];
        int[] _numbersTab = new int[10];
        int[] _resultsTab = new int[10];
        
        int _result=0;
        public CalculationInTextBox(AbsoluteValueCalculationForm _asbValueCF)
        {
            this._asbValueCF = _asbValueCF;
            _strList.Add('1');
        }
        public int AbsDoing(int _v)
        {
            if (_v >= 0)
            {
                return _v;
            }
            else if (_v < 0)
            {
                _v = -_v;
            }
            return _v;
        }
        public int DoingMathOperationInString(String str)
        {
            var _valueToAbsSS =  _asbValueCF.ValueToAbsTxb.SelectionStart;
            string[] num = Regex.Split(str, @"\-|\+|\*|\/").Where(s => !String.IsNullOrEmpty(s)).ToArray();
            string[] op = Regex.Split(str, @"\d{1,3}").Where(s => !String.IsNullOrEmpty(s)).ToArray();
            int numCtr = 0;
            int lastVal = 0;
            String lastOp = "";
            foreach (String m in num)
            {
                numCtr++;
                if (numCtr == 1)
                {
                    lastVal = int.Parse(m);
                }
                else
                {
                    if (!String.IsNullOrEmpty(lastOp))
                    {
                        switch (lastOp)
                        {
                            case "+":
                                lastVal = lastVal + int.Parse(m);

                                break;
                            case "-":
                                lastVal = lastVal - int.Parse(m);

                                break;
                            case "*":
                                lastVal = lastVal * int.Parse(m);

                                break;
                            case "/":
                                lastVal = lastVal / int.Parse(m);

                                break;
                        }
                    }
                }
                int opCtr = 0;
                foreach (String o in op)
                {
                    opCtr++;
                    if (opCtr == numCtr)
                    {
                        lastOp = o;
                        break;
                    }
                }
            }
            return lastVal;
        }
    }
}
