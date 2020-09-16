using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using metodo_e_funcao;
using System.Data.SqlClient;


namespace metodo_e_funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abrir banco de dados");
            Controles cnn = new Controles();
            Console.WriteLine(cnn.Con());
            try
            {
                Console.WriteLine("banco de dados aberto");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine("agora temos a segunda versao com esta frase");
                Console.WriteLine("terceira atualizacao do sistema");
                Console.WriteLine();
            }
        }
    }
}
