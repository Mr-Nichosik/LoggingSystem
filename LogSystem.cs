
namespace LoggingSystem
{
    public class LogSystem
    {
        /*
         * Для работы с системой логирования в классе, рекомендую создать private Logging_System.System LS = new Logging_System.System("logs");
         * При необходимости допускается Static Logging_System.
        */

        // Папка, в которую будут закидываться логи
        public string userFolder = "";

        // Она обязательна для указания при создании экземпляра класса
        public LogSystem(string userFolderName)
        {
            userFolder = userFolderName;
        }

        // Методы вызываются через экземпляр класса и записывают разного уровня информацию в логи.
        // Передаём текст, который нужно записать в файл
        public void Trace(string text)
        {
            // Создаём в текущей директории, где лежит программа, папку userFolder
            Directory.CreateDirectory($"{Environment.CurrentDirectory}\\{userFolder}");
            // Создаём/перезаписываем файл в userFolder с названием типа "ДеньМесяцГод.log".
            // В текст записываем уровень логирования (здесь это Trace), дату и ваш текст.
            File.AppendAllText($"{Environment.CurrentDirectory}\\{userFolder}\\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.log", $"TRACE: {DateTime.Now}: {text}\n");
        }

        public void Debug(string text)
        {
            Directory.CreateDirectory($"{Environment.CurrentDirectory}\\{userFolder}");
            File.AppendAllText($"{Environment.CurrentDirectory}\\{userFolder}\\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.log", $"DEBUG: {DateTime.Now}: {text}\n");
        }

        public void Info(string text)
        {
            Directory.CreateDirectory($"{Environment.CurrentDirectory}\\{userFolder}");
            File.AppendAllText($"{Environment.CurrentDirectory}\\{userFolder}\\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.log", $"INFO: {DateTime.Now}: {text}\n");
        }

        public void Warning(string text)
        {
            Directory.CreateDirectory($"{Environment.CurrentDirectory}\\{userFolder}");
            File.AppendAllText($"{Environment.CurrentDirectory}\\{userFolder}\\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.log", $"WARNING: {DateTime.Now}: {text}\n");
        }

        public void Error(string text)
        {
            Directory.CreateDirectory($"{Environment.CurrentDirectory}\\{userFolder}");
            File.AppendAllText($"{Environment.CurrentDirectory}\\{userFolder}\\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.log", $"ERROR: {DateTime.Now}: {text}\n");
        }

        public void Fatal(string text)
        {
            Directory.CreateDirectory($"{Environment.CurrentDirectory}\\{userFolder}");
            File.AppendAllText($"{Environment.CurrentDirectory}\\{userFolder}\\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.log", $"FATAL: {DateTime.Now}: {text}\n");
        }
    }
}
