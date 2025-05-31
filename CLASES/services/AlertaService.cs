using supermecadoelectronico.CLASES.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES.services
{
    public class AlertaService
    {
        private readonly IAlertaRepository _alertaRepository;

        public AlertaService(IAlertaRepository alertaRepository)
        {
            _alertaRepository = alertaRepository;
        }

        public void EjecutarVerificacion(int limite = 10)
        {
            _alertaRepository.GenerarAlertasInventario(limite);
        }

        public List<Alerta> ConsultarAlertas()
        {
            return _alertaRepository.ObtenerAlertas();
        }
    }

}
