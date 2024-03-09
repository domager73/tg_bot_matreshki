using System.Diagnostics;
using matreshki_tg_bot.FireBase;

namespace matreshki_tg_bot.Utils.Timers;

public class CustomUpdateActiveSlots
{
    public CustomUpdateActiveSlots()
    {
        _fireBaseDb = new FireBaseDb();
    }

    private FireBaseDb _fireBaseDb;
    private Timer timer;

    public void Start(int millisecondUpdate)
    {
        timer = new Timer(UpdateFunction, null, 0, millisecondUpdate);
    }

    private async void UpdateFunction(object obj)
    {
        if (DateTime.Now.Hour == 0)
        {
            await _fireBaseDb.UpdateActiveFullEnergy();
        }
    }

    public void Stop()
    {
        timer.Dispose();
    }
}