
namespace LoggingSystem
{
    /// <summary>
    /// Интерфейс, реализуемый классом LogSystem. Содержит такие методы, как Trace, Debug, Info, Warning, Error и Fatal.
    /// Метод GetAssemblyVersion() класса LogSystem здесь отсутствует.
    /// </summary>
    public interface ILogger
    {

        /// <summary>
        /// Метод Trace записывает самую мелкую и не самую значительной информации в логи во всех подробностях. Принимает текст, который нужно записать.
        /// </summary>
        /// <param name="text"></param>
        void Trace(string text);

        /// <summary>
        /// Метод Debug записывает менее подробную и более общую информации в логи. Принимает текст, который нужно записать.
        /// </summary>
        /// <param name="text"></param>
        void Debug(string text);

        /// <summary>
        /// Используя метод Info стоит записывать только самую важную и общую информацию в логи. Принимает текст, который нужно записать.
        /// </summary>
        /// <param name="text"></param>
        void Info(string text);

        /// <summary>
        /// Метод Warning стоит использовать там, где в будущем может что-то пойти не так. Принимает текст, который нужно записать.
        /// </summary>
        /// <param name="text"></param>
        void Warning(string text);

        /// <summary>
        /// Записывает сообщение об ошибке. Принимает текст, который нужно записать.
        /// </summary>
        /// <param name="text"></param>
        void Error(string text);

        /// <summary>
        /// По сути означает панику. Записывает сообщение и закрывает программу. Принимает текст, который нужно записать.
        /// </summary>
        /// <param name="text"></param>
        void Fatal(string text);
    }
}
