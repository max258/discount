using System;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class DiscountControl : UserControl
    {
        public DiscountControl()
        {
            InitializeComponent();
        }

        public IDiscount Object
        {
            get
            {
                if (certificateRadioButton.Checked)
                {
                    return certificateDiscountControl1.CertificateDiscount;
                }
                if (percentRadioButton.Checked)
                {
                    return percentDiscountControl1.PercentDiscount;
                }
                return null;
            }
            set
            {
                if (value is CertificateDiscount)
                {
                    percentRadioButton.Checked = false;
                    certificateRadioButton.Checked = true;
                    percentDiscountControl1.Visible = false;
                    certificateDiscountControl1.Visible = true;

                    certificateDiscountControl1.CertificateDiscount = (CertificateDiscount)value;
                }
                else if (value is PercentDiscount)
                {
                    percentRadioButton.Checked = true;
                    certificateRadioButton.Checked = false;
                    percentDiscountControl1.Visible = true;
                    certificateDiscountControl1.Visible = false;

                    percentDiscountControl1.PercentDiscount = (PercentDiscount)value;
                }
                else if (value == null)
                {
                    percentRadioButton.Checked = false;
                    certificateRadioButton.Checked = false;
                    
                    percentDiscountControl1.Visible = false;
                    certificateDiscountControl1.Visible = false;
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
                    percentDiscountControl1.ReadOnly = value;
                    certificateDiscountControl1.ReadOnly = value;
                }
                else
                {
                    percentRadioButton.Enabled = !value;
                    certificateRadioButton.Enabled = !value;
                    percentDiscountControl1.ReadOnly = value;
                    certificateDiscountControl1.ReadOnly = value;
                }
            }
        }

        /// <summary>
        /// Очистка контролов
        /// </summary>
        public void Clear()
        {
            certificateDiscountControl1.Clear();
            percentDiscountControl1.Clear();
        }

        private void percentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            percentDiscountControl1.Visible = true;
            certificateDiscountControl1.Visible = false;
        }

        private void certificateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            percentDiscountControl1.Visible = false;
            certificateDiscountControl1.Visible = true;
        }
    }
}