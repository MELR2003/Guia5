using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia5
{
    class Program
    {
        static List<Telefono> inventario = new List<Telefono>();
        //PARTE QUE PEDIA LA GUIA
        static void Main(string[] args)
        {
            TelefonoInteligente te = new TelefonoInteligente();
            te.Marca = "Samsung";
            te.Modelo = "S21";
            te.Precio = 800;
            te.SistemaOperativo = "Android";
            te.MemoriaRam = 8;

            TelefonoBasico te1 = new TelefonoBasico();
            te1.Marca = "Samsung";
            te1.Modelo = "S21";
            te1.Precio = 800;
            te1.TieneRadioFM = true;
            te1.TieneLinterna = true;

            Console.WriteLine("Informacion del Telefono Inteligente: "  );
            te.MostrarInformacionInteligente();
            Console.WriteLine(); 
            
            Console.WriteLine("Informacion del Telefono Basico: "  );
            te1.MostrarInformacionBasico();
            Console.WriteLine();





            //PARTE INDEPENDIENTE
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("---------------------------------------------------\n"); 
                Console.WriteLine("Sistema de Gestion de Telefonos\n");
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Registrar Teléfono");
                Console.WriteLine("2. Mostrar Teléfonos Registrados");
                Console.WriteLine("3. Consultar Stock de un Teléfono Específico");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarTelefono();
                        break;
                    case 2:
                        MostrarTelefonosRegistrados();
                        break;
                    case 3:
                        ConsultarStock();
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }
       
        static void RegistrarTelefono()
        {
            Console.WriteLine("Tipo de Teléfono (1. Inteligente, 2. Básico): ");
            int tipo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Precio: ");
            decimal precio = Convert.ToDecimal(Console.ReadLine());

            if (tipo == 1)
            {
                TelefonoInteligente telefonoInteligente = new TelefonoInteligente();
                telefonoInteligente.Marca = marca;
                telefonoInteligente.Modelo = modelo;
                telefonoInteligente.Precio = precio;

                Console.Write("Sistema Operativo: ");
                telefonoInteligente.SistemaOperativo = Console.ReadLine();

                Console.Write("Memoria RAM (GB): ");
                telefonoInteligente.MemoriaRam = Convert.ToInt32(Console.ReadLine());

                inventario.Add(telefonoInteligente);
            }
            else if (tipo == 2)
            {
                TelefonoBasico telefonoBasico = new TelefonoBasico();
                telefonoBasico.Marca = marca;
                telefonoBasico.Modelo = modelo;
                telefonoBasico.Precio = precio;

                Console.Write("Tiene Radio FM (true/false): ");
                telefonoBasico.TieneRadioFM = Convert.ToBoolean(Console.ReadLine());

                Console.Write("Tiene Linterna (true/false): ");
                telefonoBasico.TieneLinterna = Convert.ToBoolean(Console.ReadLine());

                inventario.Add(telefonoBasico);
            }
            else
            {
                Console.WriteLine("Tipo de teléfono no válido.");
            }
        }
        
        static void MostrarTelefonosRegistrados()
        {
            foreach (var telefono in inventario)
            {
                if (telefono is TelefonoInteligente)
                {
                    ((TelefonoInteligente)telefono).MostrarInformacionInteligente();
                }
                else if (telefono is TelefonoBasico)
                {
                    ((TelefonoBasico)telefono).MostrarInformacionBasico();
                }
                Console.WriteLine();
            }
        }
        static void ConsultarStock()
        {
            Console.Write("Ingrese el modelo del teléfono a buscar: ");
            string modelo = Console.ReadLine();

            foreach (var telefono in inventario)
            {
                if (telefono.Modelo == modelo)
                {
                    if (telefono is TelefonoInteligente)
                    {
                        ((TelefonoInteligente)telefono).MostrarInformacionInteligente();
                    }
                    else if (telefono is TelefonoBasico)
                    {
                        ((TelefonoBasico)telefono).MostrarInformacionBasico();
                    }
                    return;
                }
            }
            Console.WriteLine("Teléfono no encontrado.");
        }

    }
}
