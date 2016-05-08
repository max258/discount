using System;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class CreateForm : Form
    {

        private IDiscount _discount;
        public IDiscount Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

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


        public Good Good
        {
            get { return _good; }
            set { _good = value; }
        }

        public CreateForm()
        {
            InitializeComponent();
            // Привязка перечисления в качестве источника для comnobox'ов
            percentDiscountCategoryComboBox.DataSource = Enum.GetValues(typeof (GoodCategory));
            certificateDiscountCategoryComboBox.DataSource = Enum.GetValues(typeof(GoodCategory));
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
                certificateRadioButton.Checked = false;
                percentRadioButton.Checked = true;
                percentDiscountGroupBox.Visible = true;
                certificateDiscountGroupBox.Visible = false;

                var percentDiscount = (PercentDiscount)_discount;

                percentTextBox.Text = Convert.ToString(percentDiscount.Percent);
                percentDiscountCategoryComboBox.Text = (percentDiscount.Category).ToString();
            }
            else if (_discount is CertificateDiscount)
            {
                certificateRadioButton.Checked = true;
                percentRadioButton.Checked = false;
                percentDiscountGroupBox.Visible = false;
                certificateDiscountGroupBox.Visible = true;

                var certificateDiscount = (CertificateDiscount)_discount;

                sumTextBox.Text = Convert.ToString(certificateDiscount.Sum);
                certificateDiscountCategoryComboBox.Text = (certificateDiscount.Category).ToString();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Добавление скидки
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (percentRadioButton.Checked) // Добавление процентной скидки
                {
                    var percent = Convert.ToInt32(percentTextBox.Text);
                    GoodCategory category;
                    Enum.TryParse<GoodCategory>(percentDiscountCategoryComboBox.SelectedValue.ToString(), out category);
                    Discount = new PercentDiscount(_discountCount, percent, category);
                    _discountCount++;
                    Close();
                }
                if (certificateRadioButton.Checked) // Добавление скидки по сертификату
                {
                    var sum = Convert.ToDouble(sumTextBox.Text);
                    GoodCategory category;
                    Enum.TryParse<GoodCategory>(certificateDiscountCategoryComboBox.SelectedValue.ToString(),
                        out category);
                    Discount = new CertificateDiscount(_discountCount, sum, category);
                    _discountCount++;
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


        private void percentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            percentDiscountGroupBox.Visible = true;
            certificateDiscountGroupBox.Visible = false;
        }

        private void certificateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            certificateDiscountGroupBox.Visible = true;
            percentDiscountGroupBox.Visible = false;          
        }

        /// <summary>
        /// Очистка всех полей после закрытия формы
        /// </summary>
        private void CreateRowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            percentRadioButton.Checked = false;
            certificateRadioButton.Checked = false;

            percentDiscountGroupBox.Visible = false;
            certificateDiscountGroupBox.Visible = false;

            percentTextBox.Text = string.Empty;
            sumTextBox.Text = string.Empty;

            percentDiscountGroupBox.Visible = false;
            certificateDiscountGroupBox.Visible = false;
        }

        private void CreateRowForm_Load(object sender, EventArgs e)
        {
            ModifyDiscount();
        }
    }
}