using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Models
{
    public class Lugares
    {
        public string Titulo { get; set; }
        public string Imagen { get; set; }
    }

    public class GestionLugares
    {
        public static List<Lugares> GetLugar()
        {
            var lugar = new List<Lugares>();

            lugar.Add(new Lugares { Titulo = "Foto 1", Imagen = "Assets/foto1.JPG" });
            lugar.Add(new Lugares { Titulo = "Foto 2", Imagen = "Assets/foto2.JPG" });
            lugar.Add(new Lugares { Titulo = "Foto 3", Imagen = "Assets/foto3.JPG" });
            lugar.Add(new Lugares { Titulo = "Foto 4", Imagen = "Assets/foto4.JPG" });
            lugar.Add(new Lugares { Titulo = "Foto 5", Imagen = "Assets/foto5.JPG" });
            lugar.Add(new Lugares { Titulo = "Foto 6", Imagen = "Assets/foto6.JPG" });
            
            return lugar;
        }
    }
}