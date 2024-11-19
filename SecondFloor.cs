namespace One_night_at_Triangelen;

public class SecondFloor : Location
{
    public SecondFloor(Player player):base(player)
    {
        Description =
            "You are on the second floor in what you recognize as Triangelen. " +
            "There is an escalator and an entrance to the Ladies room.";
        _menu = new(this);
    }

    public override void HandleResponse(string response)
    {
        switch (response)
        {
            case "enter escalator":
                new Escalator(_player);
                break;
            case "enter ladies room":
                new LadiesRoom(_player);
                break;

        }

    }
}
