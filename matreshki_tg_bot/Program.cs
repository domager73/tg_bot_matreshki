using Google.Cloud.Firestore;
using matreshki_tg_bot.Bot;
using matreshki_tg_bot.Utils.Timers;

BotInitializer bot = new BotInitializer();
bot.Start();

CustomUpdateActiveSlots updater = new CustomUpdateActiveSlots();
updater.Start(3600000);

TaskCompletionSource tcs = new TaskCompletionSource();

AppDomain.CurrentDomain.ProcessExit += (_, _) =>
{
    updater.Stop(); 
    bot.Stop();
    Console.WriteLine("Bot stopped");
    tcs.SetResult();
};

Console.WriteLine("Press enter to stop");

await tcs.Task;

Console.WriteLine("program finished");