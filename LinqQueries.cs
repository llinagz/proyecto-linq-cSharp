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
}