using Arquivos;

var caminho = "C:\\ManipulandoArquivos";
var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
var caminhoArquivoCopia = Path.Combine(caminho, "(Cópia) arquivo-teste.txt");
var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" }; 
var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };
var novoCaminhoArquivo = Path.Combine(caminho, "Pasta 2", "arquivo-teste-stream.txt");

FileHelper helper = new FileHelper();

helper.CriarArquivoTexto(caminhoArquivo, "Olá Mundo!");
helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
helper.LerArquivo(caminhoArquivo);
helper.LerArquivoStream(caminhoArquivo);
helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
helper.CopiarArquivo(caminhoArquivo, caminhoArquivoCopia, false);
helper.DeletarArquivo(caminhoArquivoCopia);
