using matreshki_tg_bot.Bot.Service;
using matreshki_tg_bot.FireBase;
using matreshki_tg_bot.Models;

namespace matreshki_tg_bot.Bot.Router;

public class ChatsRouter
{
    private ChatTransmittedDataPairs _chatTransmittedDataPairs;
    private ServicesManager _servicesManager;
    private FireBaseDb _fireBase;

    public ChatsRouter()
    {
        _servicesManager = new ServicesManager();
        _chatTransmittedDataPairs = new ChatTransmittedDataPairs();
        _fireBase = new FireBaseDb();
    }

    public BotMessage Route(long chatId, string textData)
    {
        if (!_chatTransmittedDataPairs.ContainsKey(chatId))
        {
            if (!_fireBase.UserExist(chatId).Result)
            {
                _fireBase.CreateUser(new User().Default(chatId: chatId));
            }

            _chatTransmittedDataPairs.CreateNew(chatId);
        }

        TransmittedData transmittedData = _chatTransmittedDataPairs.GetByChatId(chatId);

        return _servicesManager.ProcessBotUpdate(textData, transmittedData);
    }
}