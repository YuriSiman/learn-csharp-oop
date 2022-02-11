string original = "abcde FGHIJ ABC abc DEFG      ";

// Transformando para maiúsculo
string s1 = original.ToUpper();

// Transformando para minúsculo
string s2 = original.ToLower();

// Removendo espaços em branco antes e depois da string
string s3 = original.Trim();

// Retornando a posição da primeira ocorrência de um valor
int n1 = original.IndexOf("bc");

// Retornando a posição da última ocorrência de um valor
int n2 = original.LastIndexOf("bc");

// Recortando uma string, começando na posição 3
string s4 = original.Substring(3);

// Recortando uma string, começando na posição 3 e pegando apenas 5 caracteres
string s5 = original.Substring(3, 5);

//Substituindo uma parte da string por outra, trocando todo caracter 'a' por 'x'
string s6 = original.Replace('a', 'x');

//Substituindo uma parte da string por outra, trocando a string "abc" por "xy"
string s7 = original.Replace("abc", "xy");

// Verificar se o conteúdo da string é nulo ou vazio
bool b1 = string.IsNullOrEmpty(original);

// Verificando se o conteúdo da string é nulo ou espaços em branco
bool b2 = string.IsNullOrWhiteSpace(original);

Console.WriteLine($"Original: -{original}-");
Console.WriteLine($"ToUpper: -{s1}-");
Console.WriteLine($"ToLower: -{s2}-");
Console.WriteLine($"Trim: -{s3}-");
Console.WriteLine($"IndexOf('bc'): -{n1}-");
Console.WriteLine($"LastIndexOf('bc'): -{n2}-");
Console.WriteLine($"Substring(3): -{s4}-");
Console.WriteLine($"Substring(3, 5): -{s5}-");
Console.WriteLine($"Replace('a', 'x'): -{s6}-");
Console.WriteLine($"Replace('abc', 'xy'): -{s7}-");
Console.WriteLine($"IsNullOrEmpty: -{b1}-");
Console.WriteLine($"IsNullOrWhiteSpace: -{b2}-");
