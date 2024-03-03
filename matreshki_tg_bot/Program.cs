﻿using Google.Cloud.Firestore;
using matreshki_tg_bot.Bot;

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