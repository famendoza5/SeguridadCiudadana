using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{


    public class PersonaDAO
    {

 
        /// <summary>
        /// Creamos persona
        /// </summary>
        /// <param name="modelo">datos de persona</param>
        /// <returns>Un objeto de tipo persona</returns>
        public async Task<persona> CrearPerona (persona modelo){

            using (SeguridadCiudadana db = new SeguridadCiudadana())
            {
                _ = db.persona.Add(modelo);
                _ = await db.SaveChangesAsync();
            }

            return modelo;
        }
    }
}
