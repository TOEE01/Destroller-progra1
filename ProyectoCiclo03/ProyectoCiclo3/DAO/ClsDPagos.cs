using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoCiclo3.MODELO;

namespace ProyectoCiclo3.DAO
{
    class ClsDPagos
    {
        private void AgregarConsumidor(Pagos pagos)
        {
            try
            {
                using (ACAPOLAMIEntities db =  new ACAPOLAMIEntities())
                {
                    Pagos pagos1 = new Pagos();
                    pagos1.monto = pagos.monto;
                    pagos1.montoCancelado = pagos.montoCancelado;
                }
            }
        }
    }
}
