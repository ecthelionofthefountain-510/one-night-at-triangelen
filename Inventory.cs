namespace One_night_at_Triangelen;

public class Inventory
{
    public List<string> Items = new();

    public void Print()
    {
        foreach(var item in Items)
        {
            Console.WriteLine(item);
        }
    }
    
}