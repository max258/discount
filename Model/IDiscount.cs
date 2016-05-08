namespace Model
{
    /// <summary>
    /// Интерфейс, описывающий скидку
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// На какую категорию товаров распространяется скидка
        /// </summary>
        GoodCategory Category { get; set; }


        int Id
        { get; set; }

        string Description { get; set; } 

        /// <summary>
        /// Метод, позволяющий расчитать скидку на товар
        /// </summary>
        /// <param name="good"> Товар для которого рассчитывается скидка </param>
        /// <returns> Возвращает размер скидки для данного товара </returns>
        double GetDiscount(Good good);

        string GetDescription();
    }
}