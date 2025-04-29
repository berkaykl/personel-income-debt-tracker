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
    public partial class FrmNewDebt : Form
    {
        public FrmNewDebt()
        {
            InitializeComponent();
        }
        public string DebtName
        {
            get => txtName.Text;
            set => txtName.Text = value;
        }
        public string DebtAmount
        {
            get => nudAmount.Value.ToString();
            set => nudAmount.Value = decimal.TryParse(value, out var val) ? val : 0;
        }
        public string DebtDescription
        {
            get => txtDescription.Text;
            set => txtDescription.Text = value;
        }
        public DateTime DebtCreatedDate
        {
            get => dtpDate.Value;
            set => dtpDate.Value = value;
        }

        private bool ValidateDebt()
        {
            var validator = new DebtValidator();

            var debt = new Debt
            {
                DebtName = txtName.Text,
                DebtAmount = nudAmount.Value.ToString(),
                DebtDescription = txtDescription.Text,
                DebtCreatedDate = dtpDate.Value
            };

            ValidationResult result = validator.Validate(debt);

            if (!result.IsValid)
            {
                string errors = string.Join("\n", result.Errors.Select(e => "- " + e.ErrorMessage));
                MessageBox.Show(errors, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // geçerli ise değerleri dışarı aktarmak için propertileri ayarla
            this.DebtName = debt.DebtName;
            this.DebtAmount = debt.DebtAmount;
            this.DebtDescription = debt.DebtDescription;
            this.DebtCreatedDate = debt.DebtCreatedDate;

            return true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateDebt())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
