namespace One_night_at_Triangelen;

public class Escalator : Location
{
    public Escalator(Player player):base(player)
    {
        Description = "You are on the escalator. There is a green button to the right. " +
                      "Below the escalator you can see the first floor. ";
        _menu = new(this);
    }

    public override void HandleResponse(string response)
    {
        switch (response)
        {
            case "walk down":
                new FirstFloor(_player);
                break;
            case "walk up":
                new SecondFloor(_player);
                break;
            case"press button":
                Console.WriteLine("The alarm goes off! The police enters and put you away for life. " +
                                  "Or at least 24 hours.");
                break;

        }
    }
}