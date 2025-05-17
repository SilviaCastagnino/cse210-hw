public class MotivationGenerator
{
    public List<string> _motivationalQuotes = new List<string>()
    {
        "Every small step counts! You're doing great!",
        "Your words matter. Even one sentence is valuable.",
        "Journaling is a gift to your future self.",
        "Journaling is a gift for future generations",
        "Don't worry about writing perfectly, just write honestly.",
        "This journal is your safe space. No judgments here.",
        "Remember why you started. You've got this!",
        "Your story is important. Keep writing it.",
        "Some days will be short entries, and that's okay.",
        "Progress, not perfection. Keep going!",
        "Your future self will thank you for these memories.",
        "Those who keep a personal journal are more likely to achieve their goals because they can track their progress and see where they need to improve.- Elder M. Russell Ballard",
        "Start today to keep a personal journal. This will become a precious possession for you and your posterity. - President Spencer W. Kimball",
        "Your life is worth recording. Your experiences are worth sharing. - Elder Dieter F. Uchtdorf",
        "Through our journals, we can communicate with our future selves. - Elder Dallin H. Oaks"
    };

    public string GetRandomMotivation()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _motivationalQuotes.Count);
        return _motivationalQuotes[randomNumber];
    }
}