namespace Arquivos
{
    internal class FileHelper
    {
        // A classe File trabalha com Stream, ou seja, ela trabalha com arquivos de forma fracionada. Ela lê um arquivo de parte em parte até o seu fim, sem sobrecarregar a memória do seu programa.
        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            // Criando um arquivo com um conteúdo se o arquivo não existir
            if (!File.Exists(caminho)) File.WriteAllText(caminho, conteudo);
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.CreateText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        public void AdicionarTexto(string caminho, string conteudo)
        {
            // Se o arquivo existir ele vai acrescentar o conteúdo, caso o arquivo não exista ele vai criar o arquivo com o conteúdo.
            File.AppendAllText(caminho, conteudo);
        }

        public void AdicionarTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        // Leitura de arquivos
        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);

            foreach (var linha in conteudo)
            {
                Console.WriteLine(linha);
            }
        }

        // Leitura de arquivos com Stream
        public void LerArquivoStream(string caminho)
        {
            var linha = string.Empty;
            // Uma Stream não lê todo o conteúdo de uma vez, então preciso utilizar o OpenText para abrir o arquivo e retornar uma StreamReader para a leitura.
            using (var stream = File.OpenText(caminho))
            {
                // Leitura da linha atual
                while ((linha = stream.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }

        public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Move(caminho, novoCaminho, sobrescrever);
        }

        public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Copy(caminho, novoCaminho, sobrescrever);
        }

        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}
