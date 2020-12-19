using System;

public class GameManager
{
    private static GameManager instance = new GameManager();
    public static GameManager Instance { get { return instance; } }

    public enum GameState { TitleScreen, Exploration, Interaction };
    public GameState gamesState = GameState.TitleScreen;

    public void Start()
    {
        StartGame.Instance.StartGameScreen();
    }


    public void WaitForInput()
    {
        if (gamesState == GameState.TitleScreen)
            BasicControls.Instance.TitleScreenControls();
        if (gamesState == GameState.Exploration)
            BasicControls.Instance.NavigationControls();
        if (gamesState == GameState.Interaction)
            BasicControls.Instance.InteractionControls();

    }

}



