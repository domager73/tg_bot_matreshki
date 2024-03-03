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
}