using EntityLayer.Concrete;
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
    public partial class DebtItemControl : UserControl
    {
        public int DebtId { get; private set; }

        public event EventHandler<int> OnDeleteClick;
        public event EventHandler<int> OnEditClick;

        public DebtItemControl()
        {
            InitializeComponent();
        }

        public void SetData(Debt debt)
        {
            //user control textlerini veritabanından alıp dolduruyoruz
            DebtId = debt.DebtId;
            lblId.Text = $"{debt.DebtId}-";
            lblInfo.Text = $"Kime: {debt.DebtName}";
            lblAmount.Text = $"Miktar: {debt.DebtAmount}";
            string onlyDate = debt.DebtCreatedDate.ToString("dd.MM.yyyy");
            lblDate.Text = onlyDate;
            lblDescription.Text = $"Açıklama: {debt.DebtDescription}";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OnEditClick?.Invoke(this, DebtId);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnDeleteClick?.Invoke(this, DebtId);
        }
    }

}
