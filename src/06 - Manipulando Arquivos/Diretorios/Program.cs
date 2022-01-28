using Diretorios;

var caminho = "C:\\ManipulandoArquivos";
var caminhoPathCombine = Path.Combine(caminho, "Pasta 3", "SubPasta 3");

FileHelper helper = new FileHelper();

helper.ListarDiretorios(caminho);
helper.ListarArquivosDiretorios(caminho);
helper.CriarDiretorio(caminhoPathCombine);
helper.ApagarDiretorio(caminhoPathCombine, true);
