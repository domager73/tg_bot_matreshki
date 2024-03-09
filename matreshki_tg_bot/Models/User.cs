using System.Globalization;
using System.Runtime.InteropServices;
using Google.Protobuf.WellKnownTypes;

namespace matreshki_tg_bot.Models;

public class User
{
    public long UserId { get; set; }
    public int Score { get; set; }
    public int Energy { get; set; }
    public int ScorePerClick { get; set; }
    public DateTime CreateAt { get; set; }
    public int MaxEnergy { get; set; }
    public string ActiveSkinId { get; set; }
    public List<string> SkinsList { get; set; }
    public List<string> PromoList { get; set; }
    public int RechargingSpeed { get; set; }
    public int ActiveFullEnergy { get; set; }

    public Dictionary<string, object> ToJson()
    {
        return new Dictionary<string, object>
        {
            { "user_id", UserId },
            { "score", Score },
            { "energy", Energy },
            { "score_per_click", ScorePerClick },
            { "create_at", DateTime.Now.ToUniversalTime().ToTimestamp() },
            { "user_skins", SkinsList },
            { "user_promo", PromoList },
            { "active_skin_id", ActiveSkinId },
            { "max_energy", MaxEnergy },
            { "recharging_speed", RechargingSpeed},
            { "active_full_energy", ActiveFullEnergy}
        };
    }

    public User Default(long chatId)
    {
        return new User
        {
            Score = 0,
            UserId = chatId,
            ScorePerClick = 1,
            Energy = 1000,
            CreateAt = DateTime.Now,
            ActiveSkinId = "aNE7E4A48M702iOBBsoO",
            SkinsList = new List<string> { "aNE7E4A48M702iOBBsoO" },
            PromoList = new List<string>(),
            MaxEnergy = 1000,
            RechargingSpeed = 1,
            ActiveFullEnergy = 3,
        };
    }

    public User FromJson(Dictionary<string, object> json)
    {
        return new User()
        {
            Score = Convert.ToInt32(json["score"]),
            UserId = Convert.ToInt64(json["user_id"]),
            ScorePerClick = Convert.ToInt32(json["score_per_click"]),
            Energy = Convert.ToInt32(json["energy"]),
            ActiveSkinId = json["active_skin_id"].ToString(),
            SkinsList = new List<string>(),
            PromoList = new List<string>(),
            RechargingSpeed = Convert.ToInt32(json["recharging_speed"]),
            ActiveFullEnergy = Convert.ToInt32(json["active_full_energy"]),
        };
    }
}