using Newtonsoft.Json;

namespace ScheduleAPI.Models.Getter
{
    /// <summary>
    /// Класс форматтера, нужный для преобразования json в другое форматирование.
    /// </summary>
    public static class SerializeFormatter
    {
        #region Область: Неформатированное представление.

        /// <summary>
        /// Метод для получения неформатированного строкового представления объекта.
        /// </summary>
        /// <param name="schedule">Расписание на день для получения представления.</param>
        /// <returns>Неформатированное строковое представление объекта.</returns>
        public static String ConvertToUnformattedJsonForm(DaySchedule schedule)
        {
            return JsonConvert.SerializeObject(schedule, Formatting.None);
        }

        /// <summary>
        /// Метод для получения неформатированного строкового представления объекта.
        /// </summary>
        /// <param name="schedule">Расписание на неделю для получения представления.</param>
        /// <returns>Неформатированное строковое представление объекта.</returns>
        public static String ConvertToUnformattedJsonForm(WeekSchedule schedule)
        {
            return JsonConvert.SerializeObject(schedule, Formatting.None);
        }
        #endregion

        #region Область: Форматированное представление.

        /// <summary>
        /// Метод для получения форматированного строкового представления объекта.
        /// </summary>
        /// <param name="schedule">Расписание на день для получения представления.</param>
        /// <returns>Форматированное строковое представление объекта.</returns>
        public static String ConvertToFormattedJsonForm(DaySchedule schedule)
        {
            return JsonConvert.SerializeObject(schedule, Formatting.Indented);
        }

        /// <summary>
        /// Метод для получения форматированного строкового представления объекта.
        /// </summary>
        /// <param name="schedule">Расписание на неделю для получения представления.</param>
        /// <returns>Форматированное строковое представление объекта.</returns>
        public static String ConvertToFormattedJsonForm(WeekSchedule schedule)
        {
            return JsonConvert.SerializeObject(schedule, Formatting.Indented);
        }
        #endregion
    }
}
