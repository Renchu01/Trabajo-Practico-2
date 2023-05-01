namespace Trabajo_Practico_2.Models;

public class Paginas {

    public int Id {get; set; }

    public int cantPaginas {get;set; }

    public List<Libros> Libros{ get; } = new List<Libros>();

}