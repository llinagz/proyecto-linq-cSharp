// See https://aka.ms/new-console-template for more information

LinqQueries queries = new LinqQueries();

//Toda la colección
//PrintValues(queries.AllCollection());

//Where. Reto 1 => Libros después del 2000
//PrintValues(queries.LibrosDespues2000());

//Where. Reto 2 ->
//PrintValues(queries.LibrosPaginasTitulo());

//All. Reto 1 -> Todos los libros tienen Status
//Console.WriteLine($" ¿Todos los libros tienen status?: {queries.TodosLosLibrosTienenStatus()}");

//Any. Reto 2 -> Si algun libro fue publicado en 2005
//Console.WriteLine($" ¿Algún libro fue publicado en 2005?: {queries.AlMenosUnLibroEn2005()}");

//Contains
PrintValues(queries.LibrosDePython());



//Funcion para imprimir en consola los libros
void PrintValues(IEnumerable<Book> bookList)
{
    Console.WriteLine("{0, -60} {1, 15} {2, 15}\n", "Titulo", "N. paginas", "Fecha publicacion");
    foreach(var item in bookList)
    {
        Console.WriteLine("{0, -60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}


