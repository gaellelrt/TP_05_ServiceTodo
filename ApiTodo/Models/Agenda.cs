public class Agenda{
    public string Nom{get; set; } = null! ;
    public int Id{get; set; }
    public ICollection<Todo> Todos { get; set; } = new List<Todo>();
}


