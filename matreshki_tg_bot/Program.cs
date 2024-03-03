using Google.Cloud.Firestore;
using matreshki_tg_bot.Bot;

System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "C:\\Users\\user\\Downloads\\Telegram Desktop\\matreshki-13a87-10bcd47ab536.json");

FirestoreDb db = FirestoreDb.Create("matreshki-13a87");

DocumentReference docRef = db.Collection("users").Document("alovelace");
Dictionary<string, object> user = new Dictionary<string, object>
{
    { "First", "Ada" },
    { "Last", "Lovelace" },
    { "Born", 1815 }
};
await docRef.SetAsync(user);

BotInitializer bot = new BotInitializer();
bot.Start();

TaskCompletionSource tcs = new TaskCompletionSource();

AppDomain.CurrentDomain.ProcessExit += (_, _) =>
{
    bot.Stop();
    Console.WriteLine("Bot stopped");
    tcs.SetResult();
};

Console.WriteLine("Press enter to stop");

await tcs.Task;

Console.WriteLine("program finished");