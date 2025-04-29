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
    public partial class WageItemControl : UserControl
    {
        public int WageId { get; private set; }

        public event EventHandler<int> OnDeleteClick;
        public event EventHandler<int> OnEditClick;

        public WageItemControl()
        {
            InitializeComponent();
        }

        public void SetData(Wage wage)
        {
            WageId = wage.WageId;
            lblId.Text = $"{wage.WageId}-";
            lblInfo.Text = $"{wage.WageName}";
            lblAmount.Text = $"Miktar: {wage.WageAmount}";
            string onlyDate = wage.WageCreatedDate.ToString("dd.MM.yyyy");
            lblDate.Text = onlyDate;
            lblDescription.Text = $"Açıklama: {wage.WageDescription}";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            OnEditClick?.Invoke(this, WageId);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnDeleteClick?.Invoke(this, WageId);
        }
    }
}
