using System.Diagnostics.CodeAnalysis;

namespace JasonMadrid_Examen1
{
    public class Matricula : ICalculoNota
    {
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public List<double> NotasParciales { get; set; } = new List<double>();
        public double CalcularNotaFinal()
        {
            double suma = 0;
            foreach (var nota in NotasParciales)
            {
                suma += nota;
            }
            return suma;
        }
        public double CalcularNotaFinal(double n1, double n2, double n3)
        {
            return n1 + n2 + n3;
        }
        public string ObtenerMensajeNota(double notaFinal)
        {
            if (notaFinal < 60) return "Reprobado";
            else if (notaFinal < 80) return "Aprobado";
            else if (notaFinal < 90) return "Muy bueno";
            else return "Sobresaliente";
        }
        public void ValidarNotas(double n1, double n2, double n3)
        {
            if (n1 < 0 || n2 < 0 || n3 < 0) 
                throw new ArgumentException("Las notas no pueden ser negativas.");
            if ((n1 + n2 > 30))
                throw new ArgumentException("La suma de las dos primeras notas no puede ser mayor a 30.");
            if (n3 > 40)
                throw new ArgumentException("La tercera nota no debe superar 40.");            
        }
    }
}
