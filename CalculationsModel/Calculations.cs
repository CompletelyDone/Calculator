using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsModel
{
    public class Calculations
    {
        public string FirstOperand { get; set; } = String.Empty;
        public string SecondOperand { get; set; } = String.Empty;
        public string Operation { get; set; } = String.Empty;
        public string Result { get; private set; } = String.Empty;
        private bool isAtomar;
        public Calculations() { }
        public Calculations(string firstOperand, string secondOperand, string operation)
        {
            CheckOperator(operation);
            CheckOperand(firstOperand);
            if(!isAtomar)CheckOperand(secondOperand);

            FirstOperand = firstOperand;
            SecondOperand = secondOperand;
            Operation = operation;
        }
        protected virtual void Calculate()
        {
            CheckOperator(Operation);
            CheckOperand(FirstOperand);
            if(!isAtomar)CheckOperand(SecondOperand);
            try
            {
                switch(Operation)
            {
                case "+":
                    Result = (Convert.ToDouble(FirstOperand) + Convert.ToDouble(SecondOperand)).ToString();
                    break;
                case "-":
                    Result = (Convert.ToDouble(FirstOperand) - Convert.ToDouble(SecondOperand)).ToString();
                    break;
                case "*":
                    Result = (Convert.ToDouble(FirstOperand) * Convert.ToDouble(SecondOperand)).ToString();
                    break;
                case "/":
                    if(SecondOperand == "0")
                    {
                        Result = "Zero devision error";
                        throw new ArgumentException("Zero devision error");
                    }
                    Result = (Convert.ToDouble(FirstOperand) / Convert.ToDouble(SecondOperand)).ToString();
                    break;
            }
            }
            catch
            {
                Result = "Unknown error";
                throw;
            }
        }
        protected virtual void CheckOperator(string operation)
        {
            switch(operation)
            {
                case "+":
                    Result = (Convert.ToDouble(FirstOperand) + Convert.ToDouble(SecondOperand)).ToString();
                    break;
                case "-":
                    Result = (Convert.ToDouble(FirstOperand) - Convert.ToDouble(SecondOperand)).ToString(); 
                    break;
                case "*":
                    Result = (Convert.ToDouble(FirstOperand) * Convert.ToDouble(SecondOperand)).ToString();
                    break;
                case "/":
                    isAtomar = false;
                    break;
                case "sqrt":
                    isAtomar = true;
                    break;
                default:
                    Result = "Operation error";
                    throw new ArgumentException("Operation error");
            }
        }

        private void CheckOperand(string operand)
        {
            try
            {
                Convert.ToDouble(operand);
            }
            catch
            {
                Result = "Operand error";
                throw;
            }
        }
    }
}
