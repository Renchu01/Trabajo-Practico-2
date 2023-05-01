namespace Trabajo_Practico_2.Models;

public class Clientes
{
public int Id {get; set; }

public string Name{get; set; }

public string Apellido {get; set; }

public string DNI {get; set; }

public int Edad {get; set; }

public int LibrosId {get;set; }
public virtual Libros Libros {get;set; }
}