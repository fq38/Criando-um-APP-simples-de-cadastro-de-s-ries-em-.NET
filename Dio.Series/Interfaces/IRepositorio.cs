using System.Collections.Generic;

namespace Dio.Series.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();

         T RetornaPortId(int id);

         void Insere(T entidade);

         void Exclui(int id);

         void Atualiza(int id, T entidade);

         int ProximoId();


    }
}