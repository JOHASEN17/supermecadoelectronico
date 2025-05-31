using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES.repositorios
{
    public interface IAlertaRepository
    {
        void GenerarAlertasInventario(int limite);
        List<Alerta> ObtenerAlertas();
    }
}
