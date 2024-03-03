using matreshki_tg_bot.Bot.Router;
using matreshki_tg_bot.Utils;
using matreshki_tg_bot.Utils.Buttons;

namespace matreshki_tg_bot.Bot.Service.Menu;

public class MainService
{
    public BotMessage ProcessClickInMainMenu(string textData, TransmittedData transmittedData)
    {
        Console.WriteLine(textData);
        if (textData == RouteNames.Help)
        {
            transmittedData.State = WaitingState.MainMenu.ClickBackToMainMenu;

            return new BotMessage(DialogStrings.Help, InlineKeyboardsMarkupStorage.BackMainMenu);
        }
        else if (textData == RouteNames.Info)
        {
            transmittedData.State = WaitingState.MainMenu.ClickBackToMainMenu;

            return new BotMessage(DialogStrings.Main, InlineKeyboardsMarkupStorage.BackMainMenu);
        }
        else
        {
            throw new Exception();
        }
    }
    public BotMessage ProcessClickInBackMainMenu(string textData, TransmittedData transmittedData)
    {
        Console.WriteLine(textData);
        if (textData == RouteNames.Main)
        {
            transmittedData.State = WaitingState.MainMenu.ClickInMainMenu;

            return new BotMessage(DialogStrings.Main, InlineKeyboardsMarkupStorage.Main);
        }
        else
        {
            throw new Exception();
        }
    }
}