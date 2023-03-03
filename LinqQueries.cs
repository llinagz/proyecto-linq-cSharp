public class LinqQueries
{
    private List<Book> librosCollection = new List<Book>();
    public LinqQueries()
    {
        using(StreamReader reader = new StreamReader("books.json"))
        {
            //Guardamos dentro de un json la lectura de todo el archivo
            string json = reader.ReadToEnd();
            //Transformamos en coleccion librosCollection
            this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions(){PropertyNameCaseInsensitive = true});
        }
    }

    //Solo queremos imprimir, así que la hacemos IEnumerable
    public IEnumerable<Book> AllCollection()
    {
        return librosCollection;
    }

    //Where. Reto 1 -> Filtrar libros publicados a partir del 2000
    public IEnumerable<Book> LibrosDespues2000()
    {
        //Extension method
        //return librosCollection.Where(p => p.PublishedDate.Year > 2000);

        //Query expresion
        return from libros in librosCollection where libros.PublishedDate.Year > 2000 select libros;
    }

    //Where. Reto 2 -> Mas de 250 paginas y que contenga el titulo "in Action"
    public IEnumerable<Book> LibrosPaginasTitulo()
    {
        //Extension method
        //return librosCollection.Where(p => p.PageCount >= 250 && p.Title.Contains("in Action")); 
        
        //Query expresion
        return from libros in librosCollection where libros.PageCount >= 250 && libros.Title.Contains("in Action") select libros;

    }


}