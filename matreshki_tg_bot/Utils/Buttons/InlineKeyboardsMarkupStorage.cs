using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace matreshki_tg_bot.Utils.Buttons;

public class InlineKeyboardsMarkupStorage
{
    public static InlineKeyboardMarkup Main = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData("Как играть?",
                RouteNames.Help),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData("Инфо",
                RouteNames.Info),
        },
        new[]
        {
            InlineKeyboardButton.WithWebApp("Хочу играть", new WebAppInfo()
            {
                Url = "https://fascinating-sable-89d740.netlify.app/"
            })
        },
    });

    public static InlineKeyboardMarkup BackMainMenu = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData("Обратно в главное меню",
                RouteNames.Main),
        },
    });
}