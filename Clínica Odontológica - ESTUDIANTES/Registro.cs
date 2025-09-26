using System;

namespace ClinicaOdontologica
{
    public static class Registro
    {
        public static void RegistrarPaciente()
        {
            Paciente NuevoPaciente = new Paciente();
            Console.Write("Ingrese el nombre del paciente: ");
            NuevoPaciente.Nombre = Console.ReadLine();
            Console.Write("Ingrese la edad del paciente: ");
            NuevoPaciente.Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tratamiento: ");
            NuevoPaciente.Tratamiento = Console.ReadLine();
            Pacientes.ListaPacientes.Add(NuevoPaciente);
          
        }
        public static void MostrarPacientes()
        {
            foreach (var p in Pacientes.ListaPacientes)
            {
                Console.WriteLine($"Nombre: {p.Nombre}");
                Console.WriteLine($"Edad: {p.Edad}");
                Console.WriteLine($"Tratamiento: {p.Tratamiento}");

            }
        }
    }
}