using System;
namespace sistema_cliente
{
    public class ClienteJuridico : Cliente
    {
        public string cnpj { set; get; }

        public ClienteJuridico()
        {
        }
    }
}
