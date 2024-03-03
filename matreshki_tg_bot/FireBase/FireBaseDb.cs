using System.Collections.Immutable;
using FireSharp.Extensions;
using Google.Cloud.Firestore;
using matreshki_tg_bot.Models;
using Newtonsoft.Json;

namespace matreshki_tg_bot.FireBase;

public class FireBaseDb
{
    private FirestoreDb db;

    public FireBaseDb()
    {
        System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS",
            "C:\\Users\\user\\Downloads\\Telegram Desktop\\matreshki-13a87-10bcd47ab536.json");

        db = FirestoreDb.Create("matreshki-13a87");
    }

    public async void CreateUser(User user)
    {
        DocumentReference docRef = db.Collection("users").Document($"{user.UserId}");
        
        await docRef.SetAsync(JsonConvert.DeserializeObject(user.ToJson()));
    }

    public bool UserExist(long userId)
    {
        var user = db.Collection("users").Document($"{userId}");

        return user != null;
    }
}