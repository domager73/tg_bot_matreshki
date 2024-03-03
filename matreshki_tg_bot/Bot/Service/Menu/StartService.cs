using matreshki_tg_bot.Bot.Router;
using matreshki_tg_bot.Utils;
using matreshki_tg_bot.Utils.Buttons;
using Telegram.Bot.Types.ReplyMarkups;

namespace matreshki_tg_bot.Bot.Service.Menu;

public class StartService
{
    public BotMessage ProcessCommandStart(string textData, TransmittedData transmittedData)
    {
        if (textData == RouteNames.Start)
        {
            transmittedData.DataStorage.AddOrUpdate("isUser", false);

            transmittedData.State = WaitingState.MainMenu.ClickInMainMenu;

            return new BotMessage(DialogStrings.Start, InlineKeyboardsMarkupStorage.Main);
        }
        else
        {
            throw new Exception();
        }
    }
}