using System;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class PercentDiscountControl : UserControl
    {
        public PercentDiscountControl()
        {
            InitializeComponent();
            percentDiscountCategoryComboBox.DataSource = Enum.GetValues(typeof(GoodCategory));
        }

        public PercentDiscount PercentDiscount
        {
            set
            {
                percentTextBox.Text = value.Percent.ToString();
                percentDiscountCategoryComboBox.Text = value.Category.ToString();
            }
            get
            {
                var percentDiscount = new PercentDiscount();
                percentDiscount.Percent = Convert.ToInt32(percentTextBox.Text);
                GoodCategory category;
                Enum.TryParse<GoodCategory>(percentDiscountCategoryComboBox.SelectedValue.ToString(), out category);
                percentDiscount.Category = category;
                return percentDiscount;
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
                    percentTextBox.ReadOnly = value;
                    percentDiscountCategoryComboBox.Enabled = !value;
                }
                else
                {
                    percentTextBox.ReadOnly = value;
                    percentDiscountCategoryComboBox.Enabled = !value;
                }
            }
        }

        /// <summary>
        /// Очистка контролов
        /// </summary>
        public void Clear()
        {
            percentTextBox.Text = null;
            percentDiscountCategoryComboBox.Text = null;
        }
    }
}