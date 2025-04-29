using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmNewWage : Form
    {
        public FrmNewWage()
        {
            InitializeComponent();
        }

        public string WageName 
        {
            get => txtName.Text; 
            set => txtName.Text = value; 
        }
        public string WageAmount 
        {
            get => nudAmount.Value.ToString();
            set => nudAmount.Value = decimal.TryParse(value, out var val) ? val : 0;
        }
        public string WageDescription 
        {
            get => txtDescription.Text;
            set => txtDescription.Text = value;
        }
        public DateTime WageCreatedDate 
        {
            get => dtpDate.Value;
            set => dtpDate.Value = value;
        }

        private bool ValidateWage()
        {
            var validator = new WageValidator();

            var wage = new Wage
            {
                WageName = txtName.Text,
                WageAmount = nudAmount.Value.ToString(),
                WageDescription = txtDescription.Text,
                WageCreatedDate = dtpDate.Value,
            };

            ValidationResult result = validator.Validate(wage);

            if (!result.IsValid)
            {
                string errors = string.Join("\n", result.Errors.Select(e => "- " + e.ErrorMessage));
                MessageBox.Show(errors, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            this.WageName = wage.WageName;
            this.WageAmount = wage.WageAmount;
            this.WageDescription = wage.WageDescription;
            this.WageCreatedDate = wage.WageCreatedDate;

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateWage())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
