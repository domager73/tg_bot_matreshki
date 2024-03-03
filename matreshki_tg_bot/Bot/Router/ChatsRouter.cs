using matreshki_tg_bot.Bot.Service;

namespace matreshki_tg_bot.Bot.Router;

public class ChatsRouter
{
    private ChatTransmittedDataPairs _chatTransmittedDataPairs;
    private ServicesManager _servicesManager;

    public ChatsRouter()
    {
        _servicesManager = new ServicesManager();
        _chatTransmittedDataPairs = new ChatTransmittedDataPairs();
    }

    public BotMessage Route(long chatId, string textData)
    {
        if (!_chatTransmittedDataPairs.ContainsKey(chatId))
        {
            _chatTransmittedDataPairs.CreateNew(chatId);
        }

        TransmittedData transmittedData = _chatTransmittedDataPairs.GetByChatId(chatId);

        return _servicesManager.ProcessBotUpdate(textData, transmittedData);
    }
}