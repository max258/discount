using System;
using System.Windows.Forms;
using Discounts;

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
                certificateDiscount.IsApplied = false;
                GoodCategory category;
                if (!Enum.TryParse<GoodCategory>(certificateDiscountCategoryComboBox.SelectedValue.ToString(), out category))
                {
                    certificateDiscount.Category = category;
                    return certificateDiscount;
                }
                else
                {
                    MessageBox.Show("Wrong category!","Error");
                    return null;
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
                    sumTextBox.ReadOnly = value;
                    certificateDiscountCategoryComboBox.Enabled = !value;
                }
                else
                {
                    sumTextBox.ReadOnly = value;
                    certificateDiscountCategoryComboBox.Enabled = !value;
                }
            }   
        }

        /// <summary>
        /// Очистка контролов
        /// </summary>
        public void Clear()
        {
            certificateDiscountCategoryComboBox.Text = (GoodCategory.Electronics).ToString();
            sumTextBox.Text = null;
        }
    }
}