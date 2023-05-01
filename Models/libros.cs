using Trabajo_Practico_2.Utils;
namespace Trabajo_Practico_2.Models;

public class Libros{

public int Id {get; set; }

public string Name{get; set; }

public string Editorial {get; set; }

public string Autor {get; set; }

public LibroGender Gender {get; set; }

public decimal Price {get ; set; }

public bool EsUsado {get; set; }


}