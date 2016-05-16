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
    public partial class CertificateDiscountControl : UserControl
    {
        public CertificateDiscountControl()
        {
            InitializeComponent();
            certificateDiscountCategoryComboBox.DataSource = Enum.GetValues(typeof(GoodCategory));
        }

        public CertificateDiscount CertificateDiscount
        {
            set
            {
                sumTextBox.Text = value.Sum.ToString();
                certificateDiscountCategoryComboBox.Text = value.Category.ToString();
            }
            get
            {
                var certificateDiscount = new CertificateDiscount();
                certificateDiscount.Sum = Convert.ToInt32(sumTextBox.Text);
                GoodCategory category;
                Enum.TryParse<GoodCategory>(certificateDiscountCategoryComboBox.SelectedValue.ToString(), out category);
                certificateDiscount.Category = category;
                return certificateDiscount;
            }
        }
    }
}