using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorEzoGary
{
    class EvalCalculation
    {
        public object RebuildForm(string formRcv)
        {
            double[] n = new double[2];
            object returnForm;
            int cnt = 0;

            try
            {
                if (formRcv.Contains("^"))
                {
                    foreach (string num in formRcv.Split('^'))
                    {
                        n[cnt] = double.Parse(num);
                        cnt++;
                    }

                    return returnForm = Math.Pow(n[0], n[1]).ToString();
                }
                else if (formRcv.Contains("sqrt"))
                {
                    string getNum = string.Empty;
                    foreach (char c in formRcv.ToCharArray())
                    {
                        if (char.IsDigit(c))
                            getNum = getNum + c;
                    }

                    return returnForm = Math.Sqrt(double.Parse(getNum)).ToString();
                }
                else
                {
                    return formRcv;
                }
            }
            catch(System.Exception e)
            {
                return formRcv = e.ToString();
            }
        }
    }
}
