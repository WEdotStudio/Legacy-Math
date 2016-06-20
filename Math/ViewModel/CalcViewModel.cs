using Math.AppCore;
using Math.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.ViewModel
{
    class CalcViewModel:ViewModelBase
    {
         private string operationResult;

        public string OperationResult
        {
            get { return operationResult; }
            set
            { this.SetProperty(ref this.operationResult, value); }
        }

        private string inputInformation;

        public string InputInformation
        {
            get { return inputInformation; }
            set
            { this.SetProperty(ref this.inputInformation, value); }
        }

        private string operationLabel;

        public string OperationLabel
        {
            get { return operationLabel; }
            set
            { this.SetProperty(ref this.operationLabel, value); }
        }

        private double number;

        public double Number
        {
            get { return number; }
            set
            { this.SetProperty(ref this.number, value); }
        }

        public DelegateCommand KeyCommand { get; set; }
        public DelegateCommand CalculationCommand { get; set; }
        public DelegateCommand ResultCommand { get; set; }
        public DelegateCommand DeleteCommand { get; set; }
        public DelegateCommand BackSpaceCommand { get; set; }

        public CalcViewModel()
        {
            Number=0;
            OperationLabel =" ";
            OperationResult="0";
            KeyCommand = new DelegateCommand(key);
            CalculationCommand = new DelegateCommand(Calculation);
            ResultCommand = new DelegateCommand(Result);
            DeleteCommand = new DelegateCommand(Delete);
            BackSpaceCommand = new DelegateCommand(Backspace);
        }

        private void key(Object paramater)//Number Keys
        {
            string s = paramater as string;
            if (OperationLabel == "=" || OperationResult == "0")
            {
                OperationResult = s;
                InputInformation = s;
                OperationLabel = " ";
            }
            else
            {
                OperationResult = OperationResult + s;
                InputInformation = InputInformation + s;
            }
        }
        private void Backspace(Object paramater)//Backspace
        {
            string s = paramater as string;
            if (InputInformation ==""|| OperationResult == "")
            {
                OperationResult = "0";
                InputInformation = "";
                OperationLabel = " ";
                Number = 0; 
            }
            else
            {
                OperationResult = OperationResult.Substring(0, OperationResult.Length - 1);
                InputInformation = InputInformation.Substring(0, InputInformation.Length - 1);
            }
        }

        private void Calculation(Object paramater)//Calc. Process
        {
            string s = paramater as string;
            if (OperationLabel != "=")
            {
                OperationNum(OperationLabel);
            }
            InputInformation = Number.ToString() + s;
            OperationResult = " ";
            OperationLabel = s;

        }

        private void Result()
        {

            OperationNum(OperationLabel);
            OperationResult = Number.ToString();
            InputInformation=" ";
            OperationLabel ="=";

        }
        private void Delete()//清空结果
        {
            OperationResult="0";
            InputInformation="";
            OperationLabel = " ";
            Number= 0; 

        }

        private void OperationNum(string s)
        {
            CalcOperation oper;
            oper = OperationFactory.CreateOperate(s);
            oper.NumberA = Number;
            oper.NumberB =  double.Parse(OperationResult);
            Number = oper.GetResult();

        }
    }
    
}
