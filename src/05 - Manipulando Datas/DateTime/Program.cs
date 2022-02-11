using System.Globalization;

// Retornando o instante atual do sistema
DateTime d1 = DateTime.Now;
Console.WriteLine(d1);

// Um objeto DateTime internamente armazena o instante na forma de "ticks" (100 nanosegundos) desde a meia noite do dia 1 de janeiro do ano 1 da era comum
Console.WriteLine(d1.Ticks);

// Instanciando o DateTime - Construtores
// Inserindo data
DateTime d2 = new DateTime(2022, 02, 10);
Console.WriteLine(d2);

// Inserindo data e hora
DateTime d3 = new DateTime(2022, 02, 10, 22, 45, 3);
Console.WriteLine(d3);

// Inserindo data e hora e milisegundos
DateTime d4 = new DateTime(2022, 02, 10, 22, 45, 3, 500);
Console.WriteLine(d4);


// Utilizando Builder do DateTime
DateTime d5 = DateTime.Now;
Console.WriteLine(d5);
DateTime d6 = DateTime.Today;
Console.WriteLine(d6);
DateTime d7 = DateTime.UtcNow;
Console.WriteLine(d7);
DateTime d8 = DateTime.UtcNow;
Console.WriteLine(d8);


// Convertendo de string para DateTime
DateTime d9 = DateTime.Parse("2022-02-10");
Console.WriteLine(d9);
DateTime d10 = DateTime.Parse("2022-02-10 13:05:58");
Console.WriteLine(d10);
DateTime d11 = DateTime.Parse("10/02/2022");
Console.WriteLine(d11);
DateTime d12 = DateTime.Parse("10/02/2022 13:05:58");
Console.WriteLine(d12);
DateTime d13 = DateTime.ParseExact("2022-02-10", "yyyy-MM-dd", CultureInfo.InvariantCulture);
Console.WriteLine(d13);
DateTime d14 = DateTime.ParseExact("22/02/2022 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
Console.WriteLine(d14);


// Propriedades do DateTime
DateTime d15 = new DateTime(2022, 02, 10, 13, 45, 58, 275);
Console.WriteLine(d15);
Console.WriteLine($"Date: {d15.Date}");
Console.WriteLine($"Day: {d15.Day}");
Console.WriteLine($"DayOfWeek: {d15.DayOfWeek}");
Console.WriteLine($"DayOfYear: {d15.DayOfYear}");
Console.WriteLine($"Hour: {d15.Hour}");
Console.WriteLine($"Kind: {d15.Kind}");
Console.WriteLine($"Millisecond: {d15.Millisecond}");
Console.WriteLine($"Minute: {d15.Minute}");
Console.WriteLine($"Month: {d15.Month}");
Console.WriteLine($"Second: {d15.Second}");
Console.WriteLine($"Ticks: {d15.Ticks}");
Console.WriteLine($"TimeOfDay: {d15.TimeOfDay}");
Console.WriteLine($"Year: {d15.Year}");


// Formatando o DateTime
string s1 = d15.ToLongDateString();
Console.WriteLine($"ToLongDateString: {d15}");
string s2 = d15.ToLongTimeString();
Console.WriteLine($"ToLongTimeString: {d15}");
string s3 = d15.ToShortDateString();
Console.WriteLine($"ToShortDateString: {d15}");
string s4 = d15.ToShortTimeString();
Console.WriteLine($"ToShortTimeString: {d15}");

// Diferença entre duas datas (duração)
TimeSpan t1 = d15.Subtract(d12);

// Operações com o DateTime
DateTime d16 = d15.Add(t1);
Console.WriteLine($"Add: {d16}");
DateTime d17 = d15.AddDays(5);
Console.WriteLine($"AddDays: {d17}");
DateTime d18 = d15.AddHours(10);
Console.WriteLine($"AddHours: {d18}");
DateTime d19 = d15.AddMilliseconds(200);
Console.WriteLine($"AddMilliseconds: {d19}");
DateTime d20 = d15.AddMinutes(5);
Console.WriteLine($"AddMinutes: {d20}");
DateTime d21 = d15.AddMonths(1);
Console.WriteLine($"AddMonths: {d21}");
DateTime d22 = d15.AddSeconds(13);
Console.WriteLine($"AddSeconds: {d22}");
DateTime d23 = d15.AddTicks(1);
Console.WriteLine($"AddTicks: {d23}");
DateTime d24 = d15.AddYears(2);
Console.WriteLine($"AddYears: {d24}");

