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

public List<Paginas> Paginas{ get; } = new List<Paginas>();

public int Clientesid {get; set; }
public virtual Clientes Clientes { get; set; }


}
