public class PromptGenerator
{
    public List<string> _prompts;
    public PromptGenerator()
    {
        _prompts = new List<string>()
        {
            // Enter prompts here with "" and , at end
            
            "Who was the most interesting person I interacted with today? ",
            "What was the best part of my day? ",
            "How did I see the hand of the Lord in my life today? ",
            "What was the strongest emotion I felt today? ",
            "If I had one thing I could do over today, what would it be? ",
            
            // Prompts from the assignment above | Personal prompts below:
            
            "What song on the radio today reminded you of a significant life event? ",
            "What is on your grocery list for today? ",
            "Did somebody do you wrong today? How did you overcome it? ",
            "What carnival food are you most excited to eat at the next carnival? ",
            "The open ocean is calling your name. If you were taking a cruise to anywhere where is it at?",
            "Who is/was your favorite Saturday Night Live castmember? ",
            "What are your thoughts on Measure twice - cut once? ",
            "What artist or celebrity are you tired of seeing so much of? ",
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}