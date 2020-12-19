using System;

public class Interaction
{
    private static Interaction instance = new Interaction();
    public static Interaction Instance { get { return instance; } }



    public void InteractWithWorldObject(WorldObject obj)
    {
        GameManager.Instance.gamesState = GameManager.GameState.Interaction;
        InteractionUI(obj);
        GameManager.Instance.WaitForInput();
    }

    public void InteractionUI(WorldObject obj = null)
    {
        Console.Clear();
        Player.Instance.DisplayPlayerInfo();

        if (obj == null)
        {
            Console.WriteLine("There is nothing there.");
        }
        else
        {
            Console.WriteLine(obj.name);

        }


        GameManager.Instance.WaitForInput();
    }
}
