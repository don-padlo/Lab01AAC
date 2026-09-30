Console.WriteLine($"Компьютер: {Environment.MachineName}");
Console.WriteLine($"Пользователь: {Environment.UserName}");
Console.WriteLine($"Дата и время: {DateTime.Now:dd.MM.yyyy HH:mm}");

Console.WriteLine();
Console.WriteLine($"ОС: {Environment.OSVersion}");
Console.WriteLine($"64-битная ОС: {Environment.Is64BitOperatingSystem}");

Console.WriteLine();
Console.WriteLine($"Логических процессоров {Environment.ProcessorCount}");

Console.WriteLine();
Console.WriteLine($"PID процесса: {Environment.ProcessId}");
long memory = Environment.WorkingSet / 1024 / 1024;
Console.WriteLine($"Память процесса: {memory} МБ");
Console.WriteLine();