using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using Model;
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

        private CreateForm _createForm = new CreateForm();

        public MainForm()
        {
            InitializeComponent();
            CreateDataTable();
        }

#region Структура таблиц
        /// <summary>
        /// Создание таблицы
        /// </summary>
        private void CreateDataTable()
        {
            ////////////////////////////////////////////////////////////
            // Таблица скидок
            ////////////////////////////////////////////////////////////
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

            ////////////////////////////////////////////////////////////
            // Таблица товаров
            ////////////////////////////////////////////////////////////
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
        

        /// <summary>
        /// Создание новой строки
        /// </summary>
        private void CreateRowButton_Click(object sender, EventArgs e)
        {
            // Вызов формы создания
            _createForm.ShowDialog();
            // Добавление скидки
            if (_createForm.Discount != null)
            {
                _discountList.Add(_createForm.Discount);
                _createForm.Discount = null;
            }

            FillTheTable();
            discountsDataGridView.Update();
        }

        /// <summary>
        /// Заполнение таблицы скидок
        /// </summary>
        private void FillTheTable()
        {
            _discountDataTable.Rows.Clear();
            foreach (var discount in _discountList)
            {
                var type = (discount is PercentDiscount) ? "Percent" : "Certificate";
                _discountDataTable.Rows.Add(discount.Id, type, discount.FormDescription());
            }
        }

        // Заполнение таблицы товаров
        private void FillGoodsTable()
        {
            _goodDataTable.Rows.Clear();
            foreach (var good in _goodList)
            {

                _goodDataTable.Rows.Add(good.Id, good.Name, String.Format("{0:0.00}", good.Cost), good.Category);
            }
        }

        /// <summary>
        /// Изменение записи
        /// </summary>
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (discountsDataGridView.CurrentRow != null)
            {
                _createForm.Discount = _discountList[Convert.ToInt32(discountsDataGridView.CurrentRow.Cells[0].Value)];
                _createForm.ShowDialog();
                _discountList[Convert.ToInt32(discountsDataGridView.CurrentRow.Cells[0].Value)] = _createForm.Discount;
                foreach (var discount in _discountList)
                {
                    discount.Id = _discountList.IndexOf(discount);
                }
                FillTheTable();
                _createForm.Discount = null;
            }
        }

        /// <summary>
        /// Удаление элемента
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // Удаление скидки
            if (discountsDataGridView.CurrentRow != null)
            {
                
                var result = MessageBox.Show("Are you sure you want to remove discount?", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (_discountList.Count == 1)
                    {
                        _discountList.Clear();
                        _createForm.DiscountCount = 0;
                    }
                    else
                    {
                        _discountList.RemoveAt(Convert.ToInt32(discountsDataGridView.CurrentRow.Cells[0].Value));
                        _createForm.DiscountCount--;
                        foreach (var discount in _discountList)
                        {
                            discount.Id = _discountList.IndexOf(discount);
                        }
                    }
                    FillTheTable();
                }
            }            
        }

        /// <summary>
        /// Применение скидки к товару  
        /// </summary>
        private void applyButton_Click(object sender, EventArgs e)
        {
            if (discountsDataGridView.CurrentRow != null && goodsDataGridView.CurrentRow != null)
            {
                if (_discountList[Convert.ToInt32(discountsDataGridView.CurrentRow.Cells[0].Value)].Category == _goodList[Convert.ToInt32(goodsDataGridView.CurrentRow.Cells[0].Value)].Category) // Сравнение категорий
                {
                    var good = _goodList[Convert.ToInt32(goodsDataGridView.CurrentRow.Cells[0].Value)];
                    var discount = _discountList[Convert.ToInt32(discountsDataGridView.CurrentRow.Cells[0].Value)].GetDiscount(good);
                    _goodList[Convert.ToInt32(goodsDataGridView.CurrentRow.Cells[0].Value)].Cost = good.Cost - discount;
                    FillGoodsTable();
                }
            }
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
                    FillTheTable();
                    FillGoodsTable();
                }
            }
        }

        private void discountsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (discountsDataGridView.CurrentRow != null)
            {
                string str = discountsDataGridView[0, discountsDataGridView.CurrentRow.Index].Value.ToString();
                int id = Convert.ToInt32(discountsDataGridView[0, discountsDataGridView.CurrentRow.Index].Value.ToString());
                discountControl1.Object = _discountList[id];
            }
        }

#region Сериализация и десериализация
        //-----------------------------------------------------------------------------------------
        // Сериализация
        //-----------------------------------------------------------------------------------------

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

        //-----------------------------------------------------------------------------------------
        // Десериализация
        //-----------------------------------------------------------------------------------------

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
                }
            }
            FillTheTable();
        }
#endregion
#region Случайные данные
        // Данные для случайного заполнения строк
        private string[] electronic = { "ASUS X550L", "ZTE Nubia Z7", "IPhone 4S", "Nokia C6-01", "Nokia 3310", "OnePlus One" };
        private string[] food = { "Bread", "Pepsi", "Milk", "Snickers", "Chicken", "Eggs" };
        private string[] cosmetic = { "Red lipstic", "Black lipstic", "Blue hair dye", "Brown hair dye", "Perfume", "Nail polish" };
        private string[] chemistry = { "Mr. Proper", "Soap", "Ariel", "Fairy", "Bref", "Domestos" };
        private string[] clothes = { "Blue shirt", "Red dress", "Black skirt", "Grey jacket", "Jeans", "Black hat" };

        /// <summary>
        /// Создание случайного товара
        /// </summary>
        private void randomGoodButton_Click(object sender, EventArgs e)
        {
            Good randomGood = new Good();
            var random = new Random();
            int category = random.Next(5);
            switch (category)
            {
                case 0:
                    randomGood.Category = GoodCategory.Electronics;
                    randomGood.Name = electronic[random.Next(6)];
                    randomGood.Cost = random.Next(3000, 50000);
                    randomGood.Id = _goodList.Count;
                    break;
                case 1:
                    randomGood.Category = GoodCategory.Food;
                    randomGood.Name = food[random.Next(6)];
                    randomGood.Cost = random.Next(50, 600);
                    randomGood.Id = _goodList.Count;
                    break;
                case 2:
                    randomGood.Category = GoodCategory.Cosmetic;
                    randomGood.Name = cosmetic[random.Next(6)];
                    randomGood.Cost = random.Next(1000, 3000);
                    randomGood.Id = _goodList.Count;
                    break;
                case 3:
                    randomGood.Category = GoodCategory.Chemistry;
                    randomGood.Name = chemistry[random.Next(6)];
                    randomGood.Cost = random.Next(50, 500);
                    randomGood.Id = _goodList.Count;
                    break;
                case 4:
                    randomGood.Category = GoodCategory.Clothes;
                    randomGood.Name = clothes[random.Next(6)];
                    randomGood.Cost = random.Next(2000, 10000);
                    randomGood.Id = _goodList.Count;
                    break;
            }
            _goodList.Add(randomGood);
            FillGoodsTable();
        }

        /// <summary>
        /// Создание случайной скидки
        /// </summary>
        private void randomDiscountButton_Click(object sender, EventArgs e)
        {
            IDiscount randomDiscount = new PercentDiscount();
            var random = new Random();
            GoodCategory category = (GoodCategory)random.Next(1, 5);
            int discountType = random.Next(2);
            switch (discountType)
            {
                case 0:
                    int percent = random.Next(1, 100);
                    randomDiscount = new PercentDiscount(_discountList.Count, percent, category);
                    break;
                case 1:
                    int sum = random.Next(10000);
                    randomDiscount = new CertificateDiscount(_discountList.Count, sum, category);
                    break;
            }
            _discountList.Add(randomDiscount);
            FillTheTable();
        }
#endregion
        
    }
}