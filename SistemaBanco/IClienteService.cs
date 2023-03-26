using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco
{
    public interface IClienteService
{
    void CriarConta();
    Cliente BuscarCliente();
    void ExibirClientes();
}
}