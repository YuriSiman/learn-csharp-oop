namespace Diretorios
{
    internal class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            // Buscando apenas o diretório recebido no parâmetro
            //var retornoCaminho = Directory.GetDirectories(caminho);

            // Buscando diretórios recursivamente (buscando todas as pastas, subpastas...)
            var retornaDiretorios = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornaDiretorios)
            {
                Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorios(string caminho)
        {
            // Buscando apenas arquivos do diretório recebido no parâmetro
            //var retornoArquivos = Directory.GetFiles(caminho);

            // Buscando somente arquivos .txt dos diretórios recursivamente (arquivos presentes em todas as pastas, subpastas...)
            //var retornaArquivos = Directory.GetFiles(caminho, "*.txt", SearchOption.AllDirectories);

            // Buscando arquivos dos diretórios recursivamente (arquivos presentes em todas as pastas, subpastas...)
            var retornaArquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornaArquivos)
            {
                Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorio(string caminho)
        {
            // Criando um diretório no caminho informado no parâmetros
            var diretorio = Directory.CreateDirectory(caminho);
            Console.WriteLine(diretorio.FullName);
        }

        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
            // Apagar o diretório informado, incluindo seus arquivos (apagarArquivos = true)
            Directory.Delete(caminho, apagarArquivos);
        }
    }
}
