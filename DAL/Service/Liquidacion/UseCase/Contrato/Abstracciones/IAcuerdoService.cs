using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Service.Liquidacion.UseCase.Contrato.Abstracciones
{
    public interface IAcuerdoService
    {
        public Task<string> Crear(CrearAcuerdoRequest req);
    }
}
