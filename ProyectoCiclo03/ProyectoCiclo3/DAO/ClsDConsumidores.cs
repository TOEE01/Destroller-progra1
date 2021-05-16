using ProyectoCiclo3.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCiclo3.DAO
{
    class ClsDConsumidores
    {
        public void InsertarUsuario(Consumidores consumidores)
        {
            try {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    Consumidores consumidores1 = new Consumidores();

                    consumidores1.nombresConsumidor = consumidores.nombresConsumidor;
                    consumidores1.apellidosConsumidor = consumidores.apellidosConsumidor;
                    consumidores1.numeroDocumento = consumidores.numeroDocumento;
                    consumidores1.telefono = consumidores.telefono;
                    consumidores1.correo = consumidores.correo;
                    consumidores1.idComunidad_FK = consumidores.idComunidad_FK;
                    db.Consumidores.Add(consumidores1);
                    db.SaveChanges();

                    MessageBox.Show("Los datos se agregaron exitosamente");
                }
            }

            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        public void EliminarConsumidor(int iD)
        {
            try
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    int Eliminar = Convert.ToInt32(iD);
                    Consumidores Consu = db.Consumidores.Where(x => x.idConsumidor == Eliminar).Select(x => x).FirstOrDefault();
                    Consu = db.Consumidores.Find(Eliminar);
                    db.Consumidores.Remove(Consu);
                    db.SaveChanges();

                    MessageBox.Show("Los datos han sido eliminados exitosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void ModificarCliente(Consumidores consumidor)
        {
            try
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    int modificar = consumidor.idConsumidor;
                    Consumidores consu = db.Consumidores.Where(x => x.idConsumidor == modificar).Select(x => x).FirstOrDefault();

                    consu.nombresConsumidor = consumidor.nombresConsumidor;
                    consu.apellidosConsumidor = consumidor.apellidosConsumidor;
                    consu.numeroDocumento = consumidor.numeroDocumento;
                    consu.telefono = consumidor.telefono;
                    consu.correo = consumidor.correo;
                    consu.idComunidad_FK = consumidor.idComunidad_FK;

                    db.SaveChanges();

                    MessageBox.Show("Los datos se actualizaron exitosamnete");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
