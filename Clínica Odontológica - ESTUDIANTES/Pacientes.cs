using System;
using System.Collections.Generic;

namespace ClinicaOdontologica
{
    public struct Paciente
    {
        public string Nombre;
        public int Edad;
        public string Tratamiento;
    }

    public static class Pacientes
    {
        public static list<Paciente> ListaPacientes = new List<Paciente>();
    }
}