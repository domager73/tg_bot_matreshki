namespace matreshki_tg_bot.Bot.Router;

public class TransmittedData
{
    public string State { get; set; }
    public DataStorage DataStorage { get; set; }
    
    public long ChatId { get; }

    public TransmittedData(long chatId)
    {
        ChatId = chatId;
        State = WaitingState.StartMenu.CommandStart;
        DataStorage = new DataStorage();
    }
}