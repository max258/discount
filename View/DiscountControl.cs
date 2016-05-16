using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            }
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