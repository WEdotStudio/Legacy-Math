using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.AppCore
{
    public class CalcOperation
    {
        private double numberA = 0;

        public double NumberA
        {
            get { return numberA; }
            set { numberA = value; }
        }

        private double numberB = 0;

        public double NumberB
        {
            get { return numberB; }
            set { numberB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
    public class OperationAdd : CalcOperation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }
    public class OperationSub : CalcOperation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }
    public class OperationDiv :CalcOperation
    {
        public override double GetResult()
        {
            var loader = new Windows.ApplicationModel.Resources.ResourceLoader();
            double result = 0;
            if (NumberB == 0)
            {
                throw new Exception(loader.GetString("DevideErr"));
            }
            result = NumberA / NumberB;
            return result;
        }
    }
    class OperationMul : CalcOperation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }
    class OperationExp : CalcOperation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * System.Math.Pow(10, Convert.ToInt32(NumberB));
            return result;
        }
    }
    class OperationSur : CalcOperation
    {
        public override double GetResult()
        {
            double result = 0;
            result = System.Math.Pow(NumberA, Convert.ToInt32(NumberB));
            return result;
        }
    }
     public class OperationNull : CalcOperation
    {
        public override double GetResult()
        {
            return NumberB;
        }
    }
     public class OperationFactory
     {
         public static CalcOperation CreateOperate(string operate)
         {
             CalcOperation oper = null;
             switch (operate)
             {
                 case " ":
                     oper = new OperationNull();
                     break;
                 case "+":
                     oper = new OperationAdd();
                     break;
                 case "-":
                     oper = new OperationSub();
                     break;
                 case "*":
                     oper = new OperationMul();
                     break;
                 case "/":
                     oper = new OperationDiv();
                     break;
                 case "^":
                     oper = new OperationSur();
                     break;
                 case "E":
                     oper = new OperationExp();
                     break;
             }
             return oper;
         }
     }

}
