using System;
using System.Windows.Forms;
using Discounts;

namespace View
{
    public partial class CreateDiscountForm : Form
    {
       public CreateDiscountForm()
        {
            InitializeComponent();
        }

        public IDiscount Discount
        { get; set; }

        /// <summary>
        /// Действия, выполняющиеся после закрытия формы
        /// </summary>
        private void CreateRowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            discountControl.Discount = null;
            discountControl.Clear();
        }

        /// <summary>
        /// Добавление скидки
        /// </summary>
        private void okButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (discountControl.Discount != null)
                {
                    Discount = discountControl.Discount;
                    Close();
                }
            }
            catch (FormatException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Выход из формы без добавления скидки
        /// </summary>
        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}