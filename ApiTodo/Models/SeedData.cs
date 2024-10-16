
public class SeedData{

    public static void Init(){
    
        using (var context = new TodoContext()){
        
            Todo todo1 = new Todo
            {
                Task = "Wash the dishes", 
                Deadline = DateTime.Parse("2024-10-16")
            };

            Todo todo2 = new Todo
            {
                Task = "Clean the house",
                Completed = true
            };

            Todo todo3 = new Todo
            {
                Task = "Buy some milk",
                Completed = false
            };

            context.Todos.AddRange(
                todo1,
                todo2,
                todo3
            );

            context.SaveChanges();

        }
    }
}     