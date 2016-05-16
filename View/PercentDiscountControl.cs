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

        public bool ReadOnly
        {
            set
            {
                
            }
        }
    }
}
