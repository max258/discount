using System;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class CreateForm : Form
    {

        private IDiscount _discount;
        private Good _good;

        private int _discountCount = 0;

        public int DiscountCount
        {
            get { return _discountCount; }
            set { _discountCount = value; }
        }

        private int _goodCount = 0;

        public int GoodCount
        {
            get { return _goodCount; }
            set { _goodCount = value; }
        }

        public IDiscount Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        public Good Good
        {
            get { return _good; }
            set { _good = value; }
        }

        public CreateForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Изменение скидки
        /// </summary>
        void ModifyDiscount()
        {
            if (_discount == null)
            {
                return;
            }

            if (_discount is PercentDiscount)
            {

            }
            else if (_discount is CertificateDiscount)
            {

                var certificateDiscount = (CertificateDiscount)_discount;

            }
        }

        /// <summary>
        /// Очистка всех полей после закрытия формы
        /// </summary>
        private void CreateRowForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void CreateRowForm_Load(object sender, EventArgs e)
        {
            ModifyDiscount();
        }

        private void okButton_Click_1(object sender, EventArgs e)
        {
            if (discountControl1.Object != null)
            {
                Discount = discountControl1.Object;

                discountControl1.Object = null;
                Close();
            }
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}