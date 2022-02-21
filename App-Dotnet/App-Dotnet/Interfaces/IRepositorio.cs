using System.Collections.Generic;

namespace App_Dotnet.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();

         T RetornaPorId(int id);

         void Insere(T identidade);
         void Excluir(int id);
         void Atualizar(int id, T identidade);
         int ProximoId();
    }
}