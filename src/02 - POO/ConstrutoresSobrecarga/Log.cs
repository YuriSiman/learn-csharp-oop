namespace ConstrutoresSobrecarga
{
    internal class Log
    {
        private static Log _log;
        public string PropriedadeLog { get; set; }

        // Definindo um construtor privado para bloquear qualquer tentativa de instância da classe Log
        private Log() { }

        // Método criado para quando for necessário usar a classe Log, trabalhando com a mesma instância durante toda a aplicação
        public static Log GetInstance()
        {
            if(_log == null)
            {
                _log = new Log();
            }
            return _log;
        }
    }
}
