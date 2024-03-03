using matreshki_tg_bot.Utils;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace matreshki_tg_bot.Bot;

public class BotInitializer
{
    
    private TelegramBotClient _botClient;
    private CancellationTokenSource _cancellationTokenSource;

    public BotInitializer()
    {
        _botClient = new TelegramBotClient(SystemStrings.TelegramToken);
        _cancellationTokenSource = new CancellationTokenSource();
    }
    
    public void Start()
    {
        ReceiverOptions receiverOptions = new ReceiverOptions
        {
            AllowedUpdates = Array.Empty<UpdateType>()
        };

        BotRequestHandlers botRequestHandlers = new BotRequestHandlers();

        _botClient.StartReceiving(
            botRequestHandlers.HandleUpdateAsync,
            botRequestHandlers.HandlePollingErrorAsync,
            receiverOptions,
            _cancellationTokenSource.Token
        );
    }

    public string GetBotName()
    {
        return _botClient.GetMeAsync().Result.Username;
    }

    public void Stop()
    {
        _cancellationTokenSource.Cancel();
    }
}