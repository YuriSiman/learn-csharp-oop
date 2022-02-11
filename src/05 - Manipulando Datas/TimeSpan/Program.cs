// Um objeto TimeSpan internamente armazena uma duração (o intervalo entre dois instantes) na forma de "ticks" (100 nanosegundos)

// Informando horas, minutos e segundos
TimeSpan t1 = new TimeSpan(0, 1, 30);
Console.WriteLine(t1);
Console.WriteLine(t1.Ticks);

// Construtores

TimeSpan t2 = new TimeSpan();
Console.WriteLine(t2);
TimeSpan t3 = new TimeSpan(900000000L);
Console.WriteLine(t3);
TimeSpan t4 = new TimeSpan(2, 11, 21);
Console.WriteLine(t4);
TimeSpan t5 = new TimeSpan(2, 2, 11, 21);
Console.WriteLine(t5);
TimeSpan t6 = new TimeSpan(2, 2, 11, 21, 321);
Console.WriteLine(t6);

// Utilizando Builder do TimeSpan

// Um dia e meio
TimeSpan t7 = TimeSpan.FromDays(1.5);
// Uma hora e meia
TimeSpan t8 = TimeSpan.FromHours(1.5);
// Um minuto e meio
TimeSpan t9 = TimeSpan.FromMinutes(1.5);
// Um segundo e meio
TimeSpan t10 = TimeSpan.FromSeconds(1.5);
// Milisegundos
TimeSpan t11 = TimeSpan.FromMilliseconds(1);

TimeSpan t12 = TimeSpan.FromTicks(900000000L);