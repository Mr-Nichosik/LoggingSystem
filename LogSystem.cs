
using System;
using System.IO;
using System.Reflection;

namespace LoggingSystem
{
    /// <summary>
    /// Класс LogSystem в пространстве имён LoggingSystem. Имеет интерфейс ILogger, через который можно обращаться к методам логирования класса.
    /// Содержит такие методы, как Trace, Debug, Info, Warning, Error и Fatal.
    /// Для работы с этой системой логирования в классе можно просто создать private LogSystem LS = new LogSystem($"{Application.StartupPath}\\logs")
    /// </summary>
    public class LogSystem : ILogger
    {
        /// <summary>
        /// Версия сборки.
        /// </summary>
        public static string Version
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version!.ToString(3); }
        }

        /// <summary>
        /// Свойство, хранящее в себе папку, в которую будут записываться логи. Указать обязательно
        /// </summary>
        public required string UserFolderName { get; init; }

        /// <summary>
        /// Метод Trace записывает самую мелкую и не самую значительной информации в логи во всех подробностях. Принимает текст, который нужно записать.
        /// </summary>
        /// <param name="text"></param>
        public void Trace(string text)
        {
            // Создаём в текущей директории, которую вы указываете, папку userFolderName
            Directory.CreateDirectory(UserFolderName);
            // Создаём/перезаписываем файл в userFolderName с названием типа "ДеньМесяцГод.log".
            // В текст записываем уровень логирования (здесь это Trace), дату и ваш текст.
            File.AppendAllText($"{UserFolderName}\\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.log", $"TRACE: {DateTime.Now}: {text}\n");
        }

        /// <summary>
        /// Метод Debug записывает менее подробную и более общую информации в логи. Принимает текст, который нужно записать.
        /// </summary>
        /// <param name="text"></param>
        public void Debug(string text)
        {
            Directory.CreateDirectory(UserFolderName);
            File.AppendAllText($"{UserFolderName}\\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.log", $"DEBUG: {DateTime.Now}: {text}\n");
        }

        /// <summary>
        /// Используя метод Info стоит записывать только самую важную и общую информацию в логи. Принимает текст, который нужно записать.
        /// </summary>
        /// <param name="text"></param>
        public void Info(string text)
        {
            Directory.CreateDirectory(UserFolderName);
            File.AppendAllText($"{UserFolderName}\\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.log", $"INFO: {DateTime.Now}: {text}\n");
        }

        /// <summary>
        /// Метод Warning стоит использовать там, где в будущем может что-то пойти не так. Принимает текст, который нужно записать.
        /// </summary>
        /// <param name="text"></param>
        public void Warning(string text)
        {
            Directory.CreateDirectory(UserFolderName);
            File.AppendAllText($"{UserFolderName}\\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.log", $"WARNING: {DateTime.Now}: {text}\n");
        }

        /// <summary>
        /// Записывает сообщение об ошибке. Принимает текст, который нужно записать.
        /// </summary>
        /// <param name="text"></param>
        public void Error(string text)
        {
            Directory.CreateDirectory(UserFolderName);
            File.AppendAllText($"{UserFolderName}\\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.log", $"ERROR: {DateTime.Now}: {text}\n");
        }

        /// <summary>
        /// По сути означает панику. Записывает сообщение и закрывает программу. Принимает текст, который нужно записать.
        /// </summary>
        /// <param name="text"></param>
        public void Fatal(string text)
        {
            Directory.CreateDirectory(UserFolderName);
            File.AppendAllText($"{UserFolderName}\\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.log", $"FATAL: {DateTime.Now}: {text}\n");

            Environment.Exit(0);
        }
    }
}
