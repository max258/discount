using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using Discounts;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace View
{
    public partial class MainForm : Form
    {
        private DataTable _discountDataTable = new DataTable(); // Таблица под скидки
        private DataTable _goodDataTable = new DataTable(); // Таблица под товары

        private List<IDiscount> _discountList = new List<IDiscount>(); // Список скидок
        private List<Good> _goodList = new List<Good>(); // Список товаров

        private CreateDiscountForm _createDiscountForm = new CreateDiscountForm();


        public MainForm()
        {
            InitializeComponent();
            CreateDataTable();
            discountControl.ReadOnly = true;
        }

        #region Структура таблиц
        /// <summary>
        /// Создание таблиц
        /// </summary>
        private void CreateDataTable()
        {
            // Таблица скидок
            discountsDataGridView.DataSource = _discountDataTable;

            // Идентификатор скидки
            var column = new DataColumn("ID")
            {
                Caption = "ID",
                DataType = typeof(int),
                ReadOnly = true
            };
            _discountDataTable.Columns.Add(column);


            // Тип скидки
            column = new DataColumn("Type")
            {
                Caption = "Type",
                DataType = typeof(string),
                ReadOnly = true
            };
            _discountDataTable.Columns.Add(column);

            // Краткое описание скидки
            column = new DataColumn("Description")
            {
                Caption = "DiscountDescription",
                DataType = typeof(string),
                ReadOnly = true
            };
            _discountDataTable.Columns.Add(column);

            // Изменение ширины столбцов
            DataGridViewColumn gridColumn = discountsDataGridView.Columns[0];
            gridColumn.Width = 30;
            gridColumn = discountsDataGridView.Columns[1];
            gridColumn.Width = 60;
            gridColumn = discountsDataGridView.Columns[2];
            gridColumn.Width = 110;

            // Таблица товаров
            goodsDataGridView.DataSource = _goodDataTable;

            // Идентификатор товара
            column = new DataColumn("ID")
            {
                Caption = "ID",
                DataType = typeof(int),
                ReadOnly = true
            };
            _goodDataTable.Columns.Add(column);

            // Имя товара
            column = new DataColumn("Name")
            {
                Caption = "Name",
                DataType = typeof(string),
                ReadOnly = true
            };
            _goodDataTable.Columns.Add(column);

            // Стоимость товара
            column = new DataColumn("Cost")
            {
                Caption = "Cost",
                DataType = typeof(double),
                ReadOnly = true
            };
            _goodDataTable.Columns.Add(column);

            // Категория товара
            column = new DataColumn("Category")
            {
                Caption = "Category",
                DataType = typeof(GoodCategory),
                ReadOnly = true
            };
            _goodDataTable.Columns.Add(column);

            // Изменение ширины столбцов
            gridColumn = goodsDataGridView.Columns[0];
            gridColumn.Width = 30;
            gridColumn = goodsDataGridView.Columns[1];
            gridColumn.Width = 100;
            gridColumn = goodsDataGridView.Columns[2];
            gridColumn.Width = 60;
            gridColumn = goodsDataGridView.Columns[3];
            gridColumn.Width = 60;

        }
        #endregion
        #region Заполнение таблиц
        /// <summary>
        /// Заполнение таблицы скидок
        /// </summary>
        private void FillDiscountsTable()
        {
            _discountList = DeleteUsed(_discountList);  // Удаление примененных скидок
            _discountDataTable.Rows.Clear();            // Очистка таблицы
            foreach (var discount in _discountList)     // Заполнение таблицы новыми скидками
            {
                    discount.Id = _discountList.IndexOf(discount);
                    var type = (discount is PercentDiscount) ? "Percent" : "Certificate";
                    _discountDataTable.Rows.Add(discount.Id, type, discount.Description);
            }
        }

        // Заполнение таблицы товаров
        private void FillGoodsTable()
        {
            _goodDataTable.Rows.Clear();
            foreach (var good in _goodList)
            {
                good.Id = _goodList.IndexOf(good);
                _goodDataTable.Rows.Add(good.Id, good.Name, String.Format("{0:0.00}", good.Cost), good.Category);
            }
        }
        #endregion

        /// <summary>
        /// Удаление использованных сертификатов
        /// </summary>
        private List<IDiscount> DeleteUsed(List<IDiscount> list)
        {
            List<IDiscount> newList = new List<IDiscount>();
            foreach (var discount in list)
            {
                if (!(discount is CertificateDiscount && ((CertificateDiscount)discount).IsApplied))
                {
                    newList.Add(discount);
                }
            }
            return newList;
        }

        /// <summary>
        /// Применение скидок к товарам
        /// </summary>
        private void applyButton_Click(object sender, EventArgs e)
        {
            if (discountsDataGridView.CurrentRow != null && goodsDataGridView.CurrentRow != null)
            {
                double sumWithDiscount = 0;
                foreach (var good in _goodList)
                {
                    foreach (var discount in _discountList)
                    {
                        good.Cost = good.Cost - discount.GetDiscount(good);
                    }
                    sumWithDiscount += good.Cost;
                }
                sumCostWithDiscountTextBox.Text = String.Format("{0:0.00}", sumWithDiscount);
                //_goodList.Clear();
                FillGoodsTable();
                FillDiscountsTable();
                sumCostTextBox.Text = null;
            }
        }

        /// <summary>
        /// Создание новой скидки
        /// </summary>
        private void CreateRowButton_Click(object sender, EventArgs e)
        {
            // Вызов формы создания
            _createDiscountForm.ShowDialog();
            // Добавление скидки, хранящейся в экземпляре формы создания
            if (_createDiscountForm.Discount != null)
            {
                _discountList.Add(_createDiscountForm.Discount);
            }
            FillDiscountsTable();
            _createDiscountForm.Discount = null;
            discountsDataGridView.Update();
        }

        /// <summary>
        /// Изменение скидки
        /// </summary>
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (discountsDataGridView.CurrentRow != null)
            {
                _createDiscountForm.Discount = _discountList[Convert.ToInt32(discountsDataGridView.CurrentRow.Cells[0].Value)];
                _createDiscountForm.ShowDialog();
                _discountList[Convert.ToInt32(discountsDataGridView.CurrentRow.Cells[0].Value)] = _createDiscountForm.Discount;
                FillDiscountsTable();
                _createDiscountForm.Discount = null;
            }
        }

        /// <summary>
        /// Отображение всех характеристик скидки
        /// </summary>
        private void discountsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (discountsDataGridView.CurrentRow != null)
            {
                discountControl.Discount = _discountList[Convert.ToInt32(discountsDataGridView.CurrentRow.Cells[0].Value)];
            }
        }

        /// <summary>
        /// Удаление скидки
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (discountsDataGridView.CurrentRow != null)
            {
                var result = MessageBox.Show("Are you sure you want to remove discount?", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (_discountList.Count == 1)
                    {
                        _discountList.Clear();
                    }
                    else
                    {
                        _discountList.RemoveAt(Convert.ToInt32(discountsDataGridView.CurrentRow.Cells[0].Value));
                    }
                    FillDiscountsTable();
                }
            }            
        }

        // Суммарная стоимость товаров
        private void goodsDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var sum = _goodList.Sum(good => good.Cost);
            sumCostTextBox.Text = sum.ToString();
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_goodList.Count != 0 || _discountList.Count != 0)
            {
                var result = MessageBox.Show("Are you sure you want to exit? All unsaved changes will be lost!",
                "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Создание новой базы
        /// </summary>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_goodList.Count != 0 || _discountList.Count != 0)
            {
                var result = MessageBox.Show("Are you sure you want to create new Database? All unsaved changes will be lost!",
                    "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _goodList.Clear();
                    _discountList.Clear();
                    FillDiscountsTable();
                    FillGoodsTable();
                    this.Text = "Discount System";
                }
            }
        }

        /// <summary>
        /// Создание случайного товара
        /// </summary>
        private void randomGoodButton_Click(object sender, EventArgs e)
        {
            sumCostWithDiscountTextBox.Text = null;
            _goodList.Add(new RandomGood().Good);
            FillGoodsTable();
        }

        /// <summary>
        /// Создание случайной скидки
        /// </summary>
        private void randomDiscountButton_Click(object sender, EventArgs e)
        {
            _discountList.Add(new RandomDiscount().Discount);
            FillDiscountsTable();
        }

        #region Сериализация и десериализация
        // Сериализация
        /// <summary>
        /// Сохранить список скидок
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter =
                    "Discounts lists files (*.ddb)|*.ddb|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filename = saveFileDialog.FileName;
                var serializer = new JsonSerializer()
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    TypeNameHandling = TypeNameHandling.Auto,
                    Formatting = Formatting.Indented
                };
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(writer, _discountList);
                    }
                }
                MessageBox.Show("List of discounts has been saved.");
            }
        }

        // Десериализация
        /// <summary>
        /// Открыть сохраненный список скидок
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _discountList.Clear();

            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter =
                "Discounts lists files (*.ddb)|*.ddb|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filename = openFileDialog.FileName;
                var deserializer = new JsonSerializer()
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    TypeNameHandling = TypeNameHandling.Auto,
                    Formatting = Formatting.Indented
                };
                using (StreamReader sr = new StreamReader(filename))
                {
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        _discountList = deserializer.Deserialize<List<IDiscount>>(reader);
                    }
                    this.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName) + " - Discount System";
                }
            }
            FillDiscountsTable();
        }
        #endregion
    }
}