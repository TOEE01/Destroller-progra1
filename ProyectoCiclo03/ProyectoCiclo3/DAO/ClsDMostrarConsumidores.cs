using ProyectoCiclo3.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCiclo3.DAO
{
    class ClsDMostrarConsumidores
    {
        //método que devolvera un listado de tipo sp_MostrarConsumidores_Result
        public List<sp_MostrarConsumidores_Result> Consultar()
        {
            //Contexto de datos
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                //Devolver el contenido como lista
                return db.sp_MostrarConsumidores().ToList();
            }
        }
    }
}
