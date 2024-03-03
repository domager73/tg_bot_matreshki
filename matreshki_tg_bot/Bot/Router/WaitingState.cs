namespace matreshki_tg_bot.Bot.Router;

public abstract class WaitingState
{
    public static StartMenu StartMenu { get; } = new();
    public static MainMenu MainMenu { get; } = new();
}

public class StartMenu
{
    public string CommandStart { get; } = "CommandStart";
}
public class MainMenu
{
    public string ClickInMainMenu { get; } = "ClickInMainMenu";
    public string ClickBackToMainMenu { get; } = "ClickBackToMainMenu";
}