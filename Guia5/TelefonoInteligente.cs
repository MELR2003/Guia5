using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia5
{
    public class TelefonoInteligente : Telefono
    {
        public string SistemaOperativo { get; set; }
        public int MemoriaRam { get; set; }

        public void MostrarInformacionInteligente()
        {
            MostrarInformacion();
            Console.WriteLine($"Sistema Operativo: {SistemaOperativo}, Memoria RAM: {MemoriaRam} GB");
        }
    }
}
