using Telegram.Bot.Types.ReplyMarkups;

namespace matreshki_tg_bot.Bot;

public class BotMessage
{
    public string Text { get; }
    public InlineKeyboardMarkup? InlineKeyboardMarkups { get; }

    public BotMessage(string text)
    {
        Text = text;
    }
    
    public BotMessage(string text, InlineKeyboardMarkup inlineKeyboardMarkups)
    {
        Text = text;
        InlineKeyboardMarkups = inlineKeyboardMarkups;
    }
}