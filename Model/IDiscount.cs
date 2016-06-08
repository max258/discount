namespace Discounts
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

        /// <summary>
        /// Идентификатор скидки в таблице
        /// </summary>
        int Id
        { get; set; }

        /// <summary>
        /// Орисание скидки
        /// </summary>
        string Description { get; set; } 

        /// <summary>
        /// Метод, позволяющий расчитать скидку на товар
        /// </summary>
        /// <param name="good"> Товар для которого рассчитывается скидка </param>
        /// <returns> Возвращает размер скидки для данного товара </returns>
        double GetDiscount(Good good);
    }
}