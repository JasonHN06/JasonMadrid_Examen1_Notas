using JasonMadrid_Examen1;

Alumno alumno = new Alumno();
alumno.Nombre = "Juan Perez";
alumno.NumeroCuenta = "20253257";
alumno.Email = "CarlosBmt@gmail.com";

Asignatura asignatura = new Asignatura();
asignatura.NombreAsignatura = "Programación II";
asignatura.NombreDocente = "Ing. Roger Guardian";
asignatura.Horario = "Lunes y Miércoles de 6:00 p.m. a 7:30 p.m.";

Matricula matricula = new Matricula();
matricula.Alumno = alumno;
matricula.Asignatura = asignatura;

try
{
    Console.Write("Ingrese la primera nota (0-30): ");
    double n1 = double.Parse(Console.ReadLine());

    Console.Write("Ingrese la segunda nota (0-30): ");
    double n2 = double.Parse(Console.ReadLine());

    Console.Write("Ingrese la tercera nota (0-40): ");
    double n3 = double.Parse(Console.ReadLine());

    matricula.ValidarNotas(n1, n2, n3);

    matricula.NotasParciales.Add(n1);
    matricula.NotasParciales.Add(n2);
    matricula.NotasParciales.Add(n3);

    double notaFinal1 = matricula.CalcularNotaFinal();
    double notaFinal2 = matricula.CalcularNotaFinal(n1, n2, n3);

    Console.WriteLine($"Resumen de las notas para {alumno.Nombre}:");
    Console.WriteLine($"Nota Final (interfaz): {notaFinal1} - {matricula.ObtenerMensajeNota(notaFinal1)}");
    Console.WriteLine($"Nota Final (sobrecarga): {notaFinal2} - {matricula.ObtenerMensajeNota(notaFinal2)}");
}
catch (FormatException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Error: Ingrese un numero valido para las notas");
    Console.ResetColor();
}
catch (ArgumentException ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Error: {ex.Message}");
    Console.ResetColor();
}