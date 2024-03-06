using System.Runtime.InteropServices;

namespace matreshki_tg_bot.Models;

public class User
{
    public long UserId { get; set; }
    public int Score { get; set; }

    public int Energy { get; set; }

    public int ScorePerClick { get; set; }


    public Dictionary<string, object> toJson()
    {
        return new Dictionary<string, object>
        {
            { "user_id", UserId },
            { "score", Score },
            { "energy", Energy },
            { "score_per_click", ScorePerClick },
        };
    }

    public User UserDefault(long chatId)
    {
        return new User()
        {
            Score = 0,
            UserId = chatId,
            ScorePerClick = 1,
            Energy = 1000,
        };
    }
    
    public User UserFromJson(Dictionary<string, object> json)
    {
        return new User()
        {
            Score = Convert.ToInt32(json["score"]),
            UserId = Convert.ToInt64(json["user_id"]),
            ScorePerClick = Convert.ToInt32(json["score_per_click"]),
            Energy = Convert.ToInt32(json["energy"]),
        };
    }
}