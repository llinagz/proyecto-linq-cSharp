// See https://aka.ms/new-console-template for more information
Console.WriteLine("¡Hola, Mundo!");

LinqQueries queries = new LinqQueries();

//Toda la colección
//PrintValues(queries.AllCollection());

//Where. Reto 1 => Libros después del 2000
//PrintValues(queries.LibrosDespues2000());

//Where. Reto 2 ->
PrintValues(queries.LibrosPaginasTitulo());




//Funcion para imprimir en consola los libros
void PrintValues(IEnumerable<Book> bookList)
{
    Console.WriteLine("{0, -60} {1, 15} {2, 15}\n", "Titulo", "N. paginas", "Fecha publicacion");
    foreach(var item in bookList)
    {
        Console.WriteLine("{0, -60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}


