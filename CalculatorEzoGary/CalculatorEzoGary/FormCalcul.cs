using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace CalculatorEzoGary
{
    public partial class FormCalcul : Form
    {
        public FormCalcul()
        {
            InitializeComponent();
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            EvalCalculation evalCalcul = new EvalCalculation();
            NCalc.Expression exp = new NCalc.Expression(evalCalcul.RebuildForm(txtInputCalcul.Text).ToString());
            
            rttResultsDisplay.Text = exp.Evaluate().ToString();
        }
    }
}
