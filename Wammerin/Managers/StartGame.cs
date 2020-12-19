using System;
using static Styling;

public class StartGame
{
    private static StartGame instance = new StartGame();
    public static StartGame Instance { get { return instance; } }

    void WriteTitleLine(string characters) { Indent((Console.WindowWidth / 2) - 56); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.BackgroundColor = ConsoleColor.DarkYellow; Console.WriteLine(characters); Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.Black; }
    void WriteMenuLine(string characters) { Indent((Console.WindowWidth / 2) - 10); Console.ForegroundColor = ConsoleColor.Black; Console.BackgroundColor = ConsoleColor.DarkYellow; Console.WriteLine(characters); Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.Black; }
    public void StartGameScreen()
    {

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(new string('╩', Console.WindowWidth));

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        WriteTitleLine("                                                                                                                 ");
        WriteTitleLine(" █████   ███   █████   █████████   ██████   ██████ ██████   ██████ ██████████ ███████████   █████ ██████   █████ ");
        WriteTitleLine("▒▒███   ▒███  ▒▒███   ███▒▒▒▒▒███ ▒▒██████ ██████ ▒▒██████ ██████ ▒▒███▒▒▒▒▒█▒▒███▒▒▒▒▒███ ▒▒███ ▒▒██████ ▒▒███  ");
        WriteTitleLine("▒▒███   ▒███  ▒▒███   ███▒▒▒▒▒███ ▒▒██████ ██████ ▒▒██████ ██████ ▒▒███▒▒▒▒▒█▒▒███▒▒▒▒▒███ ▒▒███ ▒▒██████ ▒▒███  ");
        WriteTitleLine(" ▒███   ▒███   ▒███  ▒███    ▒███  ▒███▒█████▒███  ▒███▒█████▒███  ▒███  █ ▒  ▒███    ▒███  ▒███  ▒███▒███ ▒███  ");
        WriteTitleLine(" ▒███   ▒███   ▒███  ▒███████████  ▒███▒▒███ ▒███  ▒███▒▒███ ▒███  ▒██████    ▒██████████   ▒███  ▒███▒▒███▒███  ");
        WriteTitleLine(" ▒▒███  █████  ███   ▒███▒▒▒▒▒███  ▒███ ▒▒▒  ▒███  ▒███ ▒▒▒  ▒███  ▒███▒▒█    ▒███▒▒▒▒▒███  ▒███  ▒███ ▒▒██████  ");
        WriteTitleLine("  ▒▒▒█████▒█████▒    ▒███    ▒███  ▒███      ▒███  ▒███      ▒███  ▒███ ▒   █ ▒███    ▒███  ▒███  ▒███  ▒▒█████  ");
        WriteTitleLine("    ▒▒███ ▒▒███      █████   █████ █████     █████ █████     █████ ██████████ █████   █████ █████ █████  ▒▒█████ ");
        WriteTitleLine("     ▒▒▒   ▒▒▒      ▒▒▒▒▒   ▒▒▒▒▒ ▒▒▒▒▒     ▒▒▒▒▒ ▒▒▒▒▒     ▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒ ▒▒▒▒▒   ▒▒▒▒▒ ▒▒▒▒▒ ▒▒▒▒▒    ▒▒▒▒▒  ");
        WriteTitleLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        WriteMenuLine("                    ");
        WriteMenuLine("    [N] NEW GAME    ");
        WriteMenuLine("                    ");
        WriteMenuLine(" [SPACE] LOAD GAME  ");
        WriteMenuLine("                    ");
        GameManager.Instance.WaitForInput();
    }



    public void NewGame()
    {
        Console.Clear();
        Console.WriteLine("The dark void of unconscousness begins to fade away... What is your name?");
        Player.Instance.name = Console.ReadLine();
        if (Player.Instance.name == "")//If name is blank, ask name again.
        {
            NewGame();
            return;
        }
        else
        {
            GameManager.Instance.gamesState = GameManager.GameState.Exploration;
            WorldAreaManager.Instance.GenerateTestArea(); //Generate the area made for testing!
            Player.Instance.currentArea = "Test Area";
        }
    }

}

