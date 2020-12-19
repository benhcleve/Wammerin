using System;

public class BasicControls
{
    private static BasicControls instance = new BasicControls();
    public static BasicControls Instance { get { return instance; } }

    public void TitleScreenControls()
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.N:
                {
                    StartGame.Instance.NewGame();
                    break;
                }
            case ConsoleKey.Spacebar:
                {
                    //Will be for loading
                    break;
                }
            case ConsoleKey.T:
                {
                    //For Testing
                    GameManager.Instance.gamesState = GameManager.GameState.Exploration;
                    WorldAreaManager.Instance.GenerateTestArea(); //Generate the area made for testing!
                    Player.Instance.currentArea = "Test Area";
                    Player.Instance.name = "Wamm";
                    break;
                }
            default:
                GameManager.Instance.WaitForInput();
                break;
        }
    }

    public void NavigationControls()
    {
        WorldAreaManager.Instance.worldAreas[Player.Instance.currentArea].UpdateOBL();
        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.Spacebar:
                {
                    Exploration.Instance.ShowExploration();
                    break;
                }
            case ConsoleKey.LeftArrow:
                {
                    Exploration.Instance.MoveWest();
                    break;
                }
            case ConsoleKey.RightArrow:
                {
                    Exploration.Instance.MoveEast();
                    break;
                }
            case ConsoleKey.UpArrow:
                {
                    Exploration.Instance.MoveNorth();
                    break;
                }
            case ConsoleKey.DownArrow:
                {
                    Exploration.Instance.MoveSouth();
                    break;
                }
            case ConsoleKey.L: //Look Around
                {
                    Exploration.Instance.LookAround();
                    break;
                }
            case ConsoleKey.W: //Interact with north object
                {
                    Interaction.Instance.InteractWithWorldObject(Exploration.Instance.ObjectNextToPlayer("North"));
                    break;
                }
            case ConsoleKey.S: //Interact with south object
                {
                    Interaction.Instance.InteractWithWorldObject(Exploration.Instance.ObjectNextToPlayer("South"));
                    break;
                }
            case ConsoleKey.A: //Interact with west object
                {
                    Interaction.Instance.InteractWithWorldObject(Exploration.Instance.ObjectNextToPlayer("West"));
                    break;
                }
            case ConsoleKey.D: //Interact with east object
                {
                    Interaction.Instance.InteractWithWorldObject(Exploration.Instance.ObjectNextToPlayer("East"));
                    break;
                }
            default:
                {
                    GameManager.Instance.WaitForInput();
                    break;
                }
        }
    }

    public void InteractionControls()
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.Tab:
                {
                    GameManager.Instance.gamesState = GameManager.GameState.Exploration;
                    Exploration.Instance.ShowExploration();
                    break;
                }
            default:
                {
                    GameManager.Instance.WaitForInput();
                    break;
                }

        }
    }

}
