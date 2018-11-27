using DogInsuranceLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DogInsuranceForm
{
    public partial class DogInsuranceQuoteForm : Form
    {
        public DogInsuranceQuoteForm()
        {
            InitializeComponent();
        }

        private void Recalculate()
        {
            int currentAge, expectedLife, pctCovered, deductible, majorClaims;
            if (Int32.TryParse(txtCurrentAge.Text, out currentAge) &&
                Int32.TryParse(txtExpectedLife.Text, out expectedLife) &&
                Int32.TryParse(ddlPercentCovered.SelectedItem?.ToString(), out pctCovered) &&
                Int32.TryParse(ddlDeductible.SelectedItem?.ToString(), out deductible) &&
                Int32.TryParse(ddlMajorClaims.SelectedItem?.ToString(), out majorClaims))
            {
                var quote = InsuranceValue.GetInsuranceValue(currentAge, expectedLife, pctCovered, deductible, majorClaims);
                txtQuote.Text = quote.BasicInfo();
            } else
            {
                txtQuote.Text = "Not enough information to generate a quote.";
            }
        }

        private void TextBoxValueChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void DropDownListValueChanged(object sender, EventArgs e)
        {
            Recalculate();
        }
    }
}
