using matreshki_tg_bot.Bot.Router;
using matreshki_tg_bot.Bot.Service.Menu;
using matreshki_tg_bot.Utils;

namespace matreshki_tg_bot.Bot.Service;

public class ServicesManager
{
    private Dictionary<string, Func<string, TransmittedData, BotMessage>>
        _methods;
    
    StartService startService = new StartService();
    MainService mainService = new MainService();

    public ServicesManager()
    {
        _methods =
            new Dictionary<string, Func<string, TransmittedData, BotMessage>>
            {   
                [WaitingState.StartMenu.CommandStart] = startService.ProcessCommandStart,
                
                [WaitingState.MainMenu.ClickInMainMenu] = mainService.ProcessClickInMainMenu,
                [WaitingState.MainMenu.ClickBackToMainMenu] = mainService.ProcessClickInBackMainMenu,
            };
    }

    public BotMessage ProcessBotUpdate(string textData, TransmittedData transmittedData)
    {
        Func<string, TransmittedData, BotMessage>? serviceMethod;
        
        if (textData == RouteNames.Start)
        {
            serviceMethod = _methods[WaitingState.StartMenu.CommandStart];
            
            return serviceMethod.Invoke(textData, transmittedData);
        }
        else if (textData == RouteNames.Info || textData == RouteNames.Help)
        {
            serviceMethod = _methods[WaitingState.MainMenu.ClickInMainMenu];
            
            return serviceMethod.Invoke(textData, transmittedData);
        }

        serviceMethod = _methods[transmittedData.State];
        
        return serviceMethod.Invoke(textData, transmittedData);
    }
}