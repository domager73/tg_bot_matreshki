using System.Runtime.InteropServices;

namespace matreshki_tg_bot.Models;

public class User
{
    public long UserId { get; set; }
    public int Score { get; set; }

    public Dictionary<string, object> toJson()
    {
        return new Dictionary<string, object>
        {
            { "user_id", UserId },
            { "score", Score }
        };
    }
}