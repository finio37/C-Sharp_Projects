using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationGuideProject
{
    
    public class CharChecker
    {
        private AbsoluteValueCalculationForm _absValueCF;
        private FunctionAndHerFeatures _funcAndHerFeatures;
        private QuadraticFunctionAndHejDemonstration _qFuncAndDemonstration;
        private MeasurableFunction _measurableFunction;
        private ExponentialFunction _expFun;
        private String CommaSymbol = ",";
        private String MinusSymbol = "-";
        public static String PlusSymbol = "+";


        private String _valueString;
        private String _valueTextBoxLinFunA;
        private String _valueTextBoxLinFunB;

        private String _valueTextBoxQFAStr;
        private String _valueTextBoxQFBStr;
        private String _valueTextBoxQFCStr;
        private String _valueTextBoxMFStr;
        private String _valueTextBoxEFStrA;
        private String _valueTextBoxEFStrX;

        private bool _isCommaInALinFun;
        private bool _isCommaInBLinFun;
        private bool _isCommaInAbs;
        private bool _isCommaInQFA;
        private bool _isCommaInQFB;
        private bool _isCommaInQFC;
        private bool _isCommaInMF;
        private bool _isCommaInEFA;
        private bool _isCommaInEFX;
        private bool _isMinusInMF;
        private bool _isMinus;

        private bool _isMinusFunLinTextBoxA;
        private bool _isMinusFunLinTextBoxB;
        private bool _isZeroFunLinTextBoxA;
        private bool _isMinusQFA;
        private bool _isMinusQFB;
        private bool _isMinusQFC;
        private bool _isMinusEFA;
        private bool _isMinusEFX;

        public CharChecker(AbsoluteValueCalculationForm _absValueCF)
        {
            this._absValueCF = _absValueCF;
            
        }
        public CharChecker(FunctionAndHerFeatures _funcAndHerFeatures)
        {
            this._funcAndHerFeatures = _funcAndHerFeatures;
        }
        public CharChecker(QuadraticFunctionAndHejDemonstration _qFuncAndDemonstration)
        {
            this._qFuncAndDemonstration = _qFuncAndDemonstration;
        }
        public CharChecker(MeasurableFunction _measurableFunction)
        {
            this._measurableFunction = _measurableFunction;
        }
        public CharChecker(ExponentialFunction _expFun)
        {
            this._expFun = _expFun;
        }
        
        public void IsCommaCheckerFunLinAMethod()
        {
            var _valueLinFunASS = _funcAndHerFeatures.TextBoxLinFunA.SelectionStart;
            _valueTextBoxLinFunA = _funcAndHerFeatures.TextBoxLinFunA.Text;
            _isCommaInALinFun = _valueTextBoxLinFunA.Contains(CommaSymbol);
            if (_isCommaInALinFun == true || _funcAndHerFeatures.TextBoxLinFunA.Text == "" || _funcAndHerFeatures.TextBoxLinFunA.Text == null || _funcAndHerFeatures.TextBoxLinFunA.Text == "-")
            {
                _funcAndHerFeatures.ButtonCommaLinFunBtn.Enabled = false;
                _funcAndHerFeatures.ButtonCommaLinFunBtn.Text = "X";
            }
            else if (_isCommaInALinFun == false && _funcAndHerFeatures.TextBoxLinFunA.Text != null && _valueLinFunASS == 0)
            {
                _funcAndHerFeatures.ButtonCommaLinFunBtn.Enabled = false;
                _funcAndHerFeatures.ButtonCommaLinFunBtn.Text = "X";
            }
            else if (_isCommaInALinFun == false && _funcAndHerFeatures.TextBoxLinFunA.Text != null && _valueLinFunASS > 0)
            {
                _funcAndHerFeatures.ButtonCommaLinFunBtn.Enabled = true;
                _funcAndHerFeatures.ButtonCommaLinFunBtn.Text = ",";
            }
        }
        
        public void IsCommaCheckerFunLinBMethod()
        {
            var _valueLinFunBSS = _funcAndHerFeatures.TextBoxLinFunB.SelectionStart;
            _valueTextBoxLinFunB = _funcAndHerFeatures.TextBoxLinFunB.Text;
            _isCommaInBLinFun = _valueTextBoxLinFunB.Contains(CommaSymbol);
            if (_isCommaInBLinFun == true || _funcAndHerFeatures.TextBoxLinFunB.Text == "" || _funcAndHerFeatures.TextBoxLinFunB.Text == null || _funcAndHerFeatures.TextBoxLinFunB.Text == "-")
            {
                _funcAndHerFeatures.ButtonCommaLinFunBtn.Enabled = false;
                _funcAndHerFeatures.ButtonCommaLinFunBtn.Text = "X";
            }
            else if (_isCommaInBLinFun == false && _funcAndHerFeatures.TextBoxLinFunB.Text != null && _valueLinFunBSS == 0)
            {
                _funcAndHerFeatures.ButtonCommaLinFunBtn.Enabled = false;
                _funcAndHerFeatures.ButtonCommaLinFunBtn.Text = "X";
            }
            else if (_isCommaInBLinFun == false && _funcAndHerFeatures.TextBoxLinFunB.Text != null && _valueLinFunBSS > 0)
            {
                _funcAndHerFeatures.ButtonCommaLinFunBtn.Enabled = true;
                _funcAndHerFeatures.ButtonCommaLinFunBtn.Text = ",";
            }
        }
        public void IsCommaCheckerQFAMethod()
        {
            var _valueQFASS = _qFuncAndDemonstration.TextBoxQFATxb.SelectionStart;
            _valueTextBoxQFAStr = _qFuncAndDemonstration.TextBoxQFATxb.Text;
            _isCommaInQFA = _valueTextBoxQFAStr.Contains(CommaSymbol);
            if (_isCommaInQFA == true || _qFuncAndDemonstration.TextBoxQFATxb.Text == "" || _qFuncAndDemonstration.TextBoxQFATxb.Text == null || _qFuncAndDemonstration.TextBoxQFATxb.Text == "-")
            {
                _qFuncAndDemonstration.ButtonCommaQFunBtn.Enabled = false;
                _qFuncAndDemonstration.ButtonCommaQFunBtn.Text = "X";
            }
            else if (_isCommaInQFA == false && _qFuncAndDemonstration.TextBoxQFATxb.Text != null && _valueQFASS == 0)
            {
                _qFuncAndDemonstration.ButtonCommaQFunBtn.Enabled = false;
                _qFuncAndDemonstration.ButtonCommaQFunBtn.Text = "X";
            }
            else if (_isCommaInQFA == false && _qFuncAndDemonstration.TextBoxQFATxb.Text != null && _valueQFASS > 0)
            {
                _qFuncAndDemonstration.ButtonCommaQFunBtn.Enabled = true;
                _qFuncAndDemonstration.ButtonCommaQFunBtn.Text = ",";
            }
        }
        public void IsCommaCheckerQFBMethod()
        {
            var _valueQFBSS = _qFuncAndDemonstration.TextBoxQFBTxb.SelectionStart;
            _valueTextBoxQFBStr = _qFuncAndDemonstration.TextBoxQFBTxb.Text;
            _isCommaInQFB = _valueTextBoxQFBStr.Contains(CommaSymbol);
            if (_isCommaInQFB == true || _qFuncAndDemonstration.TextBoxQFBTxb.Text == "" || _qFuncAndDemonstration.TextBoxQFBTxb.Text == null || _qFuncAndDemonstration.TextBoxQFBTxb.Text == "-")
            {
                _qFuncAndDemonstration.ButtonCommaQFunBtn.Enabled = false;
                _qFuncAndDemonstration.ButtonCommaQFunBtn.Text = "X";
            }
            else if (_isCommaInQFB == false && _qFuncAndDemonstration.TextBoxQFBTxb.Text != null && _valueQFBSS == 0)
            {
                _qFuncAndDemonstration.ButtonCommaQFunBtn.Enabled = false;
                _qFuncAndDemonstration.ButtonCommaQFunBtn.Text = "X";
            }
            else if (_isCommaInQFB == false && _qFuncAndDemonstration.TextBoxQFBTxb.Text != null && _valueQFBSS > 0)
            {
                _qFuncAndDemonstration.ButtonCommaQFunBtn.Enabled = true;
                _qFuncAndDemonstration.ButtonCommaQFunBtn.Text = ",";
            }
        }
        public void IsCommaCheckerQFCMethod()
        {
            var _valueQFCSS = _qFuncAndDemonstration.TextBoxQFCTxb.SelectionStart;
            _valueTextBoxQFCStr = _qFuncAndDemonstration.TextBoxQFCTxb.Text;
            _isCommaInQFC = _valueTextBoxQFCStr.Contains(CommaSymbol);
            if (_isCommaInQFC == true || _qFuncAndDemonstration.TextBoxQFCTxb.Text == "" || _qFuncAndDemonstration.TextBoxQFCTxb.Text == null || _qFuncAndDemonstration.TextBoxQFCTxb.Text == "-")
            {
                _qFuncAndDemonstration.ButtonCommaQFunBtn.Enabled = false;
                _qFuncAndDemonstration.ButtonCommaQFunBtn.Text = "X";
            }
            else if (_isCommaInQFC == false && _qFuncAndDemonstration.TextBoxQFCTxb.Text != null && _valueQFCSS == 0)
            {
                _qFuncAndDemonstration.ButtonCommaQFunBtn.Enabled = false;
                _qFuncAndDemonstration.ButtonCommaQFunBtn.Text = "X";
            }
            else if (_isCommaInQFC == false && _qFuncAndDemonstration.TextBoxQFCTxb.Text != null && _valueQFCSS > 0)
            {
                _qFuncAndDemonstration.ButtonCommaQFunBtn.Enabled = true;
                _qFuncAndDemonstration.ButtonCommaQFunBtn.Text = ",";
            }
        }
        public void IsCommaChecherMFMethod()
        {
            var _valueMF = _measurableFunction.TextBoxMF.SelectionStart;
            _valueTextBoxMFStr = _measurableFunction.TextBoxMF.Text;
            _isCommaInMF = _valueTextBoxMFStr.Contains(CommaSymbol);
            if (_isCommaInMF == true || _measurableFunction.TextBoxMF.Text == "" || _measurableFunction.TextBoxMF.Text == null || _measurableFunction.TextBoxMF.Text == "-")
            {
                _measurableFunction.ButtonCommaMFBtn.Enabled = false;
                _measurableFunction.ButtonCommaMFBtn.Text = "X";
            }
            else if (_isCommaInMF == false && _measurableFunction.TextBoxMF.Text != null && _valueMF == 0)
            {
                _measurableFunction.ButtonCommaMFBtn.Enabled = false;
                _measurableFunction.ButtonCommaMFBtn.Text = "X";
            }
            else if (_isCommaInMF == false && _measurableFunction.TextBoxMF.Text != null && _valueMF > 0)
            {
                _measurableFunction.ButtonCommaMFBtn.Enabled = true;
                _measurableFunction.ButtonCommaMFBtn.Text = ",";
            }
        }
        public void IsCommaCheckerExpFunAMethod()
        {
            var _valueExFunASS = _expFun.TextBoxEFA.SelectionStart;
            _valueTextBoxEFStrA = _expFun.TextBoxEFA.Text;
            _isCommaInEFA = _valueTextBoxEFStrA.Contains(CommaSymbol);
            if (_isCommaInEFA == true || _expFun.TextBoxEFA.Text == "" || _expFun.TextBoxEFA.Text == null || _expFun.TextBoxEFA.Text == "-")
            {
                _expFun.ButtonCommaEFBtn.Enabled = false;
                _expFun.ButtonCommaEFBtn.Text = "X";
            }
            else if (_isCommaInEFA == false && _expFun.TextBoxEFA.Text != null && _valueExFunASS == 0)
            {
                _expFun.ButtonCommaEFBtn.Enabled = false;
                _expFun.ButtonCommaEFBtn.Text = "X";
            }
            else if (_isCommaInEFA == false && _expFun.TextBoxEFA.Text != null && _valueExFunASS > 0)
            {
                _expFun.ButtonCommaEFBtn.Enabled = true;
                _expFun.ButtonCommaEFBtn.Text = ",";
            }
        }
        public void IsCommaCheckerExpFunXMethod()
        {
            var _valueExpFunXSS = _expFun.TextBoxEFX.SelectionStart;
            _valueTextBoxEFStrX = _expFun.TextBoxEFX.Text;
            _isCommaInEFX = _valueTextBoxEFStrX.Contains(CommaSymbol);
            if (_isCommaInEFX == true || _expFun.TextBoxEFX.Text == "" || _expFun.TextBoxEFX.Text == null || _expFun.TextBoxEFX.Text == "-")
            {
                _expFun.ButtonCommaEFBtn.Enabled = false;
                _expFun.ButtonCommaEFBtn.Text = "X";
            }
            else if (_isCommaInEFX == false && _expFun.TextBoxEFX.Text != null && _valueExpFunXSS == 0)
            {
                _expFun.ButtonCommaEFBtn.Enabled = false;
                _expFun.ButtonCommaEFBtn.Text = "X";
            }
            else if (_isCommaInEFX == false && _expFun.TextBoxEFX.Text != null && _valueExpFunXSS > 0)
            {
                _expFun.ButtonCommaEFBtn.Enabled = true;
                _expFun.ButtonCommaEFBtn.Text = ",";
            }


        }
        public void IsMinusCheckerFunLinAMethod()
        {
            var _valueLinFunASS = _funcAndHerFeatures.TextBoxLinFunA.SelectionStart;
            _valueTextBoxLinFunA = _funcAndHerFeatures.TextBoxLinFunA.Text;
            _isMinusFunLinTextBoxA = _valueTextBoxLinFunA.Contains(MinusSymbol);
            if (_isMinusFunLinTextBoxA == true)
            {
                _funcAndHerFeatures.ButtonMinusLinFunBtn.Enabled = false;
                _funcAndHerFeatures.ButtonMinusLinFunBtn.Text = "X";
            }
            else if (_isMinusFunLinTextBoxA == false || _funcAndHerFeatures.TextBoxLinFunA.Text != null || _funcAndHerFeatures.TextBoxLinFunA.Text==null)
            {
                _funcAndHerFeatures.ButtonMinusLinFunBtn.Enabled = true;
                _funcAndHerFeatures.ButtonMinusLinFunBtn.Text = "-";
            }
            else if (_isMinusFunLinTextBoxA==true && _valueLinFunASS==0 && _funcAndHerFeatures.TextBoxLinFunA.Text!=null)
            {
                _funcAndHerFeatures.ButtonMinusLinFunBtn.Enabled = false;
                _funcAndHerFeatures.ButtonMinusLinFunBtn.Text = "X";
            }
            
            else if (_isMinusFunLinTextBoxA == false && _valueLinFunASS == 0 && _funcAndHerFeatures.TextBoxLinFunA.Text != null)
            {
                _funcAndHerFeatures.ButtonMinusLinFunBtn.Enabled = true;
                _funcAndHerFeatures.ButtonMinusLinFunBtn.Text = "-";
            }
            
        }
        public void IsMinusCheckerExpFunAMethod()
        {
            var _valueExpFunASS = _expFun.TextBoxEFA.SelectionStart;
            _valueTextBoxEFStrA = _expFun.TextBoxEFA.Text;
            _isMinusEFA = _valueTextBoxEFStrA.Contains(MinusSymbol);
            if( _isMinusEFA == true)
            {
                _expFun.ButtonMinusEFBtn.Enabled = false;
                _expFun.ButtonMinusEFBtn.Text = "X";
            }
            else if (_isMinusEFA == false || _expFun.TextBoxEFA != null || _expFun.TextBoxEFA == null)
            {
                _expFun.ButtonMinusEFBtn.Enabled = true;
                _expFun.ButtonMinusEFBtn.Text = "-";
            }
            else if (_isMinusEFA == true && _valueExpFunASS == 0 && _expFun.TextBoxEFA.Text != null)
            {
                _expFun.ButtonMinusEFBtn.Enabled = false;
                _expFun.ButtonMinusEFBtn.Text = "X";
            }

            else if (_isMinusEFA == false && _valueExpFunASS == 0 && _expFun.TextBoxEFA.Text != null)
            {
                _expFun.ButtonMinusEFBtn.Enabled = true;
                _expFun.ButtonMinusEFBtn.Text = "-";
            }
        }
        public void IsMinusCheckerExpFunXMethod()
        {
            var _valueExpFunXSS = _expFun.TextBoxEFX.SelectionStart;
            _valueTextBoxEFStrX = _expFun.TextBoxEFX.Text;
            _isMinusEFX = _valueTextBoxEFStrX.Contains(MinusSymbol);
            if (_isMinusEFX == true)
            {
                _expFun.ButtonMinusEFBtn.Enabled = false;
                _expFun.ButtonMinusEFBtn.Text = "X";
            }
            else if (_isMinusEFX == false || _expFun.TextBoxEFX != null || _expFun.TextBoxEFX == null)
            {
                _expFun.ButtonMinusEFBtn.Enabled = true;
                _expFun.ButtonMinusEFBtn.Text = "-";
            }
            else if (_isMinusEFX == true && _valueExpFunXSS == 0 && _expFun.TextBoxEFX.Text != null)
            {
                _expFun.ButtonMinusEFBtn.Enabled = false;
                _expFun.ButtonMinusEFBtn.Text = "X";
            }

            else if (_isMinusEFX == false && _valueExpFunXSS == 0 && _expFun.TextBoxEFX.Text != null)
            {
                _expFun.ButtonMinusEFBtn.Enabled = true;
                _expFun.ButtonMinusEFBtn.Text = "-";
            }
        }
        public void IsMinusCheckerFunLinBMethod()
        {
            var _valueLinFunBSS = _funcAndHerFeatures.TextBoxLinFunB.SelectionStart;
            _valueTextBoxLinFunB = _funcAndHerFeatures.TextBoxLinFunB.Text;
            _isMinusFunLinTextBoxB = _valueTextBoxLinFunB.Contains(MinusSymbol);
            if (_isMinusFunLinTextBoxB == true)
            {
                _funcAndHerFeatures.ButtonMinusLinFunBtn.Enabled = false;
                _funcAndHerFeatures.ButtonMinusLinFunBtn.Text = "X";
            }
            else if (_isMinusFunLinTextBoxB == false || _funcAndHerFeatures.TextBoxLinFunB.Text != null)
            {
                _funcAndHerFeatures.ButtonMinusLinFunBtn.Enabled = true;
                _funcAndHerFeatures.ButtonMinusLinFunBtn.Text = "-";
            }
            else if (_valueLinFunBSS > 0 || _funcAndHerFeatures.TextBoxLinFunB.Text != null)
            {
                _funcAndHerFeatures.ButtonMinusLinFunBtn.Enabled = false;
                _funcAndHerFeatures.ButtonMinusLinFunBtn.Text = "X";
            }
            else if (_isMinusFunLinTextBoxB == false && _valueLinFunBSS == 0 && _funcAndHerFeatures.TextBoxLinFunB.Text != null)
            {
                _funcAndHerFeatures.ButtonMinusLinFunBtn.Enabled = true;
                _funcAndHerFeatures.ButtonMinusLinFunBtn.Text = "-";
            }
        }
        public void IsMinusCheckerQFAMethod()
        {
            var _valueQFASS = _qFuncAndDemonstration.TextBoxQFATxb.SelectionStart;
            _valueTextBoxQFAStr = _qFuncAndDemonstration.TextBoxQFATxb.Text;
            _isMinusQFA = _valueTextBoxQFAStr.Contains(MinusSymbol);
            if (_isMinusQFA == true)
            {
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Enabled = false;
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Text = "X";
            }
            else if (_isMinusQFA == false || _qFuncAndDemonstration.TextBoxQFATxb.Text != null)
            {
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Enabled = true;
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Text = "-";
            }
            else if (_valueQFASS > 0 || _qFuncAndDemonstration.TextBoxQFATxb.Text != null)
            {
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Enabled = false;
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Text = "X";
            }
            else if (_isMinusQFA == false && _valueQFASS == 0 && _qFuncAndDemonstration.TextBoxQFATxb.Text != null)
            {
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Enabled = true;
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Text = "-";
            }
        }
        public void IsMinusCheckerQFBMethod()
        {
            var _valueQFBSS = _qFuncAndDemonstration.TextBoxQFBTxb.SelectionStart;
            _valueTextBoxQFBStr = _qFuncAndDemonstration.TextBoxQFBTxb.Text;
            _isMinusQFB = _valueTextBoxQFBStr.Contains(MinusSymbol);
            if (_isMinusQFB == true)
            {
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Enabled = false;
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Text = "X";
            }
            else if (_isMinusQFB == false || _qFuncAndDemonstration.TextBoxQFBTxb.Text != null)
            {
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Enabled = true;
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Text = "-";
            }
            else if (_valueQFBSS > 0 || _qFuncAndDemonstration.TextBoxQFBTxb.Text != null)
            {
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Enabled = false;
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Text = "X";
            }
            else if (_isMinusQFB == false && _valueQFBSS == 0 && _qFuncAndDemonstration.TextBoxQFBTxb.Text != null)
            {
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Enabled = true;
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Text = "-";
            }

        }
        public void IsMinusCheckerQFCMethod()
        {
            var _valueQFCSS = _qFuncAndDemonstration.TextBoxQFCTxb.SelectionStart;
            _valueTextBoxQFCStr = _qFuncAndDemonstration.TextBoxQFCTxb.Text;
            _isMinusQFC = _valueTextBoxQFCStr.Contains(MinusSymbol);
            if (_isMinusQFC == true)
            {
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Enabled = false;
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Text = "X";
            }
            else if (_isMinusQFC == false || _qFuncAndDemonstration.TextBoxQFCTxb.Text != null)
            {
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Enabled = true;
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Text = "-";
            }
            else if (_valueQFCSS > 0 || _qFuncAndDemonstration.TextBoxQFCTxb.Text != null)
            {
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Enabled = false;
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Text = "X";
            }
            else if (_isMinusQFC == false && _valueQFCSS == 0 && _qFuncAndDemonstration.TextBoxQFCTxb.Text != null)
            {
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Enabled = true;
                _qFuncAndDemonstration.ButtonMinusQFunBtn.Text = "-";
            }
        }
        public void IsMinusCheckedMFMethod()
        {
            var _valueMFSS = _measurableFunction.TextBoxMF.SelectionStart;
            _valueTextBoxMFStr = _measurableFunction.TextBoxMF.Text;
            _isMinusInMF = _valueTextBoxMFStr.Contains(MinusSymbol);
            if (_isMinusInMF == true)
            {
                _measurableFunction.ButtonMinusMFBtn.Enabled = false;
                _measurableFunction.ButtonMinusMFBtn.Text = "X";
            }
            else if (_isMinusInMF == false || _measurableFunction.TextBoxMF.Text != null || _measurableFunction.TextBoxMF.Text==null)
            {
                _measurableFunction.ButtonMinusMFBtn.Enabled = true;
                _measurableFunction.ButtonMinusMFBtn.Text = "-";
            }
            else if (_isMinusInMF==true && _valueMFSS > 0 && _measurableFunction.TextBoxMF.Text != null)
            {
                _measurableFunction.ButtonMinusMFBtn.Enabled = false;
                _measurableFunction.ButtonMinusMFBtn.Text = "X";
            }
            else if (_isMinusInMF == false && _valueMFSS == 0 && _measurableFunction.TextBoxMF.Text != null)
            {
                _measurableFunction.ButtonMinusMFBtn.Enabled = true;
                _measurableFunction.ButtonMinusMFBtn.Text = "-";
            }
        }
        public void IsZeroCheckerFunLinAMethod()
        {
            var _valueLinFunASS = _funcAndHerFeatures.TextBoxLinFunA.SelectionStart;
            _valueTextBoxLinFunA = _funcAndHerFeatures.TextBoxLinFunA.Text;
            _isZeroFunLinTextBoxA = _valueTextBoxLinFunA.Contains("0");
            _isMinusFunLinTextBoxA = _valueTextBoxLinFunA.Contains("-");
            if (_valueLinFunASS == 0 && _isMinusFunLinTextBoxA == true)
            {
                _funcAndHerFeatures.ButtonZeroBtn.Enabled = false;
            }
            else if (_valueLinFunASS == 1 && ZerosCounter._zerosCounter > 1 && _isMinusFunLinTextBoxA == true)
            {
                _funcAndHerFeatures.ButtonZeroBtn.Enabled = false;
            }
            else
            {
                _funcAndHerFeatures.ButtonZeroBtn.Enabled = true;
            }
        }
        public void IsMinusCheckerMethod()
        {
            var _valueToAbsSS = _absValueCF.ValueToAbsTxb.SelectionStart;
            _valueString = _absValueCF.ValueToAbsTxb.Text;
            _isMinus = _valueString.Contains(MinusSymbol);
            if (_isMinus == true)
            {
                _absValueCF.ButtonMinusBtn.Enabled = false;
            }
            else if (_isMinus == false || _absValueCF.ValueToAbsTxb.Text != null)
            {
                _absValueCF.ButtonMinusBtn.Enabled = true;
            }
            else if (_valueToAbsSS > 0 || _absValueCF.ValueToAbsTxb.Text != null)
            {
                _absValueCF.ButtonMinusBtn.Enabled = false;
            }
            else if (_isMinus == false && _valueToAbsSS == 0 && _absValueCF.ValueToAbsTxb.Text != null)
            {
                _absValueCF.ButtonMinusBtn.Enabled = true;
            }
        }

    }
}
