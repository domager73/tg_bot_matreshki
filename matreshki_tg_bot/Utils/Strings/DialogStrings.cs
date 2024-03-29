using matreshki_tg_bot.Models;

namespace matreshki_tg_bot.Utils;

public class DialogStrings
{
    public const string Main = @"Матрешка Кликер - Зарабатывай Коин! 🪆💰

    Добро пожаловать в Матрешка Кликер! Это виртуальная игра-кликер, в которой каждое нажатие на экран приносит тебе монеты Notcoin.

    🪆 Лиги
        Чем больше монет ты заработаешь, тем выше поднимешься в лигах. Соревнуйся с другими игроками и докажи, что ты самый искусный кликер!

    💥 Boosts
        Получай бусты и выполняй разнообразные задания, чтобы увеличить свой доход в Notcoin. Это поможет тебе быстрее достичь вершины!

    🤝 Frens
        Пригласи своего друга и оба получите бонусы! Помоги другу перейти в следующую лигу, и вы оба получите ещё больше Notcoin бонусов. Вместе - веселее и выгоднее!

    👥 Squads
        Присоединяйся к Telegram-каналам и группам, которые являются Squads. Здесь ты сможешь играть вместе с другими игроками, делиться советами и стратегиями. Приглашай новых участников по своей ссылке и получай бонусы за каждого реферала!

    ❓ Wen
        Никто не знает, будет ли выпущен Notcoin токен и когда это произойдет. Никто не знает, будет ли он иметь стоимость или нет. И в этом вся прелесть! Давайте вместе исследовать этот удивительный мир Notcoin и узнать, что он нам приготовил!";

    public const string Start = @"Добро пожаловать в Матрешка Кликер Бот! 🪆💰

Приветствуем тебя в увлекательном мире кликеров и криптовалюты, где каждый клик приносит не только удовольствие, но и вознаграждение. 🚀

🟢 О чем этот бот?
Здесь ты можешь погрузиться в захватывающий процесс нажатия на матрешки и зарабатывать криптовалюту в процессе!

🟠 Что делать?
Просто кликай на матрешки, чтобы получать монеты. Чем больше кликов — тем больше крипты!

🔵 Криптовалюта и магазин:
Накопленную криптовалюту ты сможешь потратить в нашем магазине на уникальные предметы и улучшения для матрешек. Сделай свои клики еще эффективнее!

🟣 Промокоды и бонусы:
Не забудь заглянуть в раздел промокодов, там скрыты уникальные коды, которые приятно удивят тебя бонусами и сюрпризами!

💎 Активность и награды:
Участвуй в ежедневных заданиях и соревнованиях, чтобы получить дополнительные награды и подняться в рейтинге!

Наслаждайся игрой, зарабатывай криптовалюту и делай свои матрешки лучше всех! 💪🪆💸

Следи за новостями и обновлениями, у нас для тебя приготовлены много интересных событий и возможностей!

Для начала игры просто нажми Старт или используй команду /start. Удачи и пусть удача всегда будет на твоей стороне! 🍀✨";

    public const string Help = "Я тебе помог бро";
    
    public static string GetUserStats(User user) => $"Energy: {user.Energy}\nScore per click: {user.ScorePerClick}\nScore: {user.Score}";
}