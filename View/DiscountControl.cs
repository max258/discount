using System;
using System.Windows.Forms;
using Discounts;

namespace View
{
    public partial class DiscountControl : UserControl
    {
        public DiscountControl()
        {
            InitializeComponent();
        }

        public IDiscount Discount
        {
            get
            {
                if (certificateRadioButton.Checked)
                {
                    return certificateDiscountControl.CertificateDiscount;
                }
                if (percentRadioButton.Checked)
                {
                    return percentDiscountControl.PercentDiscount;
                }
                return null;
            }
            set
            {
                if (value is CertificateDiscount)
                {
                    percentRadioButton.Checked = false;
                    certificateRadioButton.Checked = true;
                    percentDiscountControl.Visible = false;
                    certificateDiscountControl.Visible = true;

                    certificateDiscountControl.CertificateDiscount = (CertificateDiscount)value;
                }
                else if (value is PercentDiscount)
                {
                    percentRadioButton.Checked = true;
                    certificateRadioButton.Checked = false;
                    percentDiscountControl.Visible = true;
                    certificateDiscountControl.Visible = false;

                    percentDiscountControl.PercentDiscount = (PercentDiscount)value;
                }
                else if (value == null)
                {
                    percentRadioButton.Checked = false;
                    certificateRadioButton.Checked = false;
                    
                    percentDiscountControl.Visible = false;
                    certificateDiscountControl.Visible = false;
                }
            }
        }

        /// <summary>
        /// Режим "только для чтения"
        /// </summary>
        public bool ReadOnly
        {
            set
            {
                if (value)
                {
                    percentRadioButton.Enabled = !value;
                    certificateRadioButton.Enabled = !value;
                    percentDiscountControl.ReadOnly = value;
                    certificateDiscountControl.ReadOnly = value;
                }
                else
                {
                    percentRadioButton.Enabled = !value;
                    certificateRadioButton.Enabled = !value;
                    percentDiscountControl.ReadOnly = value;
                    certificateDiscountControl.ReadOnly = value;
                }
            }
        }

        /// <summary>
        /// Очистка контролов
        /// </summary>
        public void Clear()
        {
            certificateDiscountControl.Clear();
            percentDiscountControl.Clear();
        }

        private void percentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            percentDiscountControl.Visible = true;
            certificateDiscountControl.Visible = false;
        }

        private void certificateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            percentDiscountControl.Visible = false;
            certificateDiscountControl.Visible = true;
        }
    }
}