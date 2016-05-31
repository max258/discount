using System;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class CreateForm : Form
    {
       public CreateForm()
        {
            InitializeComponent();
        }

        IDiscount ModifyDiscount()
        {
            discountControl1.Object = Discount;
            return discountControl1.Object;
        }

        private void CreateRowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            discountControl1.Object = null;
            discountControl1.Clear();
        }

        private void CreateRowForm_Load(object sender, EventArgs e)
        {
            ModifyDiscount(); 
        }

        /// <summary>
        /// Добавление скидки
        /// </summary>

        private void okButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (discountControl1.Object != null)
                {
                    Discount = discountControl1.Object;

                    discountControl1.Object = null;
                    discountControl1.Clear();
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
        /// Выход из формы без добавления
        /// </summary>

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            discountControl1.Object = null;
            discountControl1.Clear();
            Close();
        }
        #region Свойства
        private IDiscount _discount;
        public IDiscount Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        private int _discountCount = 0;

        public int DiscountCount
        {
            get { return _discountCount; }
            set { _discountCount = value; }
        }

        private int _goodCount = 0;

        #endregion
    }
}