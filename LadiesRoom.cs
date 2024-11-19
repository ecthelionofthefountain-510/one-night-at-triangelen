namespace One_night_at_Triangelen;

public class LadiesRoom : Location
{
    
    public LadiesRoom(Player player):base(player)
    {
        Description = ("You are in the Ladies room. There is a row of stalls, a bottle of booze and an exit.");
        _menu = new(this);
    }

    public override void HandleResponse(string response)
    {
        switch (response)
        {
            case("exit"):
                Console.WriteLine("exiting");
                new SecondFloor(_player); 
                break;
            case("drink booze"):
                Console.WriteLine("*glug glug glug*");
                new LadiesRoom(_player); // unneccesary
                // _menu.PrintOptions();
                break;
        }
    }
}