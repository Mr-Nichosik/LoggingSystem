# Logging System

Итак, быстренько распишу, что тут да как. Простейшая система логирования, которая принимает текст и папку, куда записывать логи. Имеет методы Trace, Debug, Info, Warning, Error. Fatal.
Используй их как душе угодно, они отличаются только названием и текстом в логе :)

Перед началом работы добавь в свой проект ссылку на элемент 'LoggingSystem'. Затем в зависимости ссылку на проект 'LoggingSystem'.

Для работы с системой логирования в классе, рекомендую создать:
using LoggingSystem;
private readonly LogSystem LS = new LogSystem("logs");,
где logs - это папка в директории исполняемого файла, куда будут записываться логи. При необходимости допускается static LoggingSystem.

Есть несколько методов: Trace, Debug, Info, Warning, Error, Fatal.
Они отличаются тем, что записывают в текст соответствующие пометки. Например, метод Error - ты его ставишь в том месте, где может вылезти потенциальная ошибка.
А пишется нужный текст так: LS.Error("В методе N  класс X возникла ошибка в таком-то месте").

Далее в нужных местах просто добавляешь LS.Error/Info/Debug и прочее. Впринципе, всё.		27.05.2023
