using System;
using System.IO;
using System.Reflection;

namespace LoggingSystem
{
    public class LogSystem : ILogger
    {
        /*
         * Для работы с системой логирования в классе, рекомендую создать private LoggingSystem.LogSystem LS = new LoggingSystem.LogSystem($"{Application.StartupPath}\\logs");
         * При необходимости допускается Static Logging_System.
        */

        // Папка, в которую будут закидываться логи
        public string userFolderName { get; private set; }

        // Она обязательна для указания при создании экземпляра класса
        public LogSystem(string userFolderName)
        {
            this.userFolderName = userFolderName;
        }

        // Методы вызываются через экземпляр класса и записывают разного уровня информацию в логи.
        // Передаём текст, который нужно записать в файл
        public void Trace(string text)
        {
            // Создаём в текущей директории, которую вы указываете, папку userFolderName
            Directory.CreateDirectory($"{userFolderName}");
            // Создаём/перезаписываем файл в userFolderName с названием типа "ДеньМесяцГод.log".
            // В текст записываем уровень логирования (здесь это Trace), дату и ваш текст.
            File.AppendAllText($"{userFolderName}\\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.log", $"TRACE: {DateTime.Now}: {text}\n");
        }

        // Далее всё по аналогии
        public void Debug(string text)
        {
            Directory.CreateDirectory($"{userFolderName}");
            File.AppendAllText($"{userFolderName}\\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.log", $"DEBUG: {DateTime.Now}: {text}\n");
        }

        public void Info(string text)
        {
            Directory.CreateDirectory($"{userFolderName}");
            File.AppendAllText($"{userFolderName}\\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.log", $"INFO: {DateTime.Now}: {text}\n");
        }

        public void Warning(string text)
        {
            Directory.CreateDirectory($"{userFolderName}");
            File.AppendAllText($"{userFolderName}\\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.log", $"WARNING: {DateTime.Now}: {text}\n");
        }

        public void Error(string text)
        {
            Directory.CreateDirectory($"{userFolderName}");
            File.AppendAllText($"{userFolderName}\\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.log", $"ERROR: {DateTime.Now}: {text}\n");
        }

        public void Fatal(string text)
        {
            Directory.CreateDirectory($"{userFolderName}");
            File.AppendAllText($"{userFolderName}\\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.log", $"FATAL: {DateTime.Now}: {text}\n");
        }

        #region Информация о сборке
        public string GetAssemblyName()
        {
            string assembly = Assembly.GetExecutingAssembly().GetName().Name.ToString();
            return assembly;
        }

        public string GetAssemblyVersion()
        {
            string assembly = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            assembly = assembly.Remove(assembly.Length - 2);
            return assembly;
        }

        public string GetAssemblyCompany()
        {
            object[] assemblyCustomAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
            return ((AssemblyCompanyAttribute)assemblyCustomAttributes[0]).Company.ToString();
        }
        #endregion
    }
}
