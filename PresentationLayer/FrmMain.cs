using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmMain : Form
    {
        private readonly IDebtService _debtService;
        private readonly IWageService _wageService;

        public FrmMain()
        {
            _debtService = new DebtManager(new EfDebtDal());
            _wageService = new WageManager(new EfWageDal());
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadDebts();
            LoadWages();
        }

        //DEBT SECTION
        private void LoadDebts()
        {
            flpDebts.Controls.Clear();

            var debts = _debtService.TGetAll();

            foreach ( var debt in debts )
            {
                var item = new DebtItemControl();
                item.SetData(debt);
                item.OnDeleteClick += Debt_OnDeleteClick;
                item.OnEditClick += Debt_OnEditClick;

                flpDebts.Controls.Add(item);
            }

        }

        private void Debt_OnDeleteClick(object sender, int debtId)
        {
            var debt = _debtService.TGetById(debtId);

            if (debt != null)
            {
                _debtService.TDelete(debt);

                MessageBox.Show("Kayıt başarıyla silindi!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDebts();
            }
        }

        private void Debt_OnEditClick(object sender, int debtId)
        {
            var debt = _debtService.TGetById(debtId);

            if (debt != null)
            {
                //veritabanındaki veriyle bir form oluşturuyoruz 
                FrmNewDebt frmNewItem = new FrmNewDebt
                {
                    DebtName = debt.DebtName,
                    DebtAmount = debt.DebtAmount,
                    DebtDescription = debt.DebtDescription,
                    DebtCreatedDate = debt.DebtCreatedDate,
                };
                
                //veritabanındaki veriyi formdaki yeni veriyle güncelliyoruz
                if (frmNewItem.ShowDialog() == DialogResult.OK)
                {
                    debt.DebtName = frmNewItem.DebtName;
                    debt.DebtAmount = frmNewItem.DebtAmount;
                    debt.DebtDescription = frmNewItem.DebtDescription;
                    debt.DebtCreatedDate = frmNewItem.DebtCreatedDate;

                    _debtService.TUpdate(debt);

                    MessageBox.Show("Kayıt başarıyla güncellendi!", "Düzenleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDebts();
                }
            }
        }

        private void btnDebtAdd_Click(object sender, EventArgs e)
        {
            FrmNewDebt frmNewDebt = new FrmNewDebt();

            if (frmNewDebt.ShowDialog() == DialogResult.OK)
            {
                Debt newDebt = new Debt
                {
                    DebtName = frmNewDebt.DebtName,
                    DebtAmount = frmNewDebt.DebtAmount,
                    DebtDescription = frmNewDebt.DebtDescription,
                    DebtCreatedDate = frmNewDebt.DebtCreatedDate
                };

                _debtService.TInsert(newDebt);
                LoadDebts();
            }
        }



        //WAGE SECTION
        private void LoadWages()
        {
            flpWages.Controls.Clear();
            
            var wages = _wageService.TGetAll();

            foreach ( var wage in wages )
            {
                var item = new WageItemControl();
                item.SetData(wage);
                item.OnDeleteClick += Wage_OnDeleteClick;
                item.OnEditClick += Wage_OnEditClick;

                flpWages.Controls.Add(item);
            }

        }

        private void btnAddWage_Click(object sender, EventArgs e)
        {
            FrmNewWage frmNewWage = new FrmNewWage();

            if (frmNewWage.ShowDialog() == DialogResult.OK )
            {
                Wage newWage = new Wage
                {
                    WageName = frmNewWage.WageName,
                    WageAmount = frmNewWage.WageAmount,
                    WageDescription = frmNewWage.WageDescription,
                    WageCreatedDate = frmNewWage.WageCreatedDate,
                };

                _wageService.TInsert(newWage);
                LoadWages();
            }
        }

        private void Wage_OnDeleteClick(object sender, int WageId)
        {
            var wage = _wageService.TGetById(WageId);

            if (wage != null)
            {
                _wageService.TDelete(wage);

                MessageBox.Show("Kayıt başarıyla silindi!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadWages();
            }
        }

        private void Wage_OnEditClick(object sender, int WageId)
        {
            var wage = _wageService.TGetById(WageId);

            if (wage != null)
            {
                FrmNewWage frmNewWage = new FrmNewWage
                {
                    WageName = wage.WageName,
                    WageAmount = wage.WageAmount,
                    WageDescription = wage.WageDescription,
                    WageCreatedDate = wage.WageCreatedDate,
                };

                if (frmNewWage.ShowDialog() == DialogResult.OK)
                {
                    wage.WageName = frmNewWage.WageName;
                    wage.WageAmount = frmNewWage.WageAmount;
                    wage.WageDescription = frmNewWage.WageDescription;
                    wage.WageCreatedDate = frmNewWage.WageCreatedDate;

                    _wageService.TUpdate(wage);

                    MessageBox.Show("Kayıt başarıyla güncellendi!", "Düzenleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadWages();
                }
            }
        }

    }
}