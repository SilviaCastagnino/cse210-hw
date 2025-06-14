public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _level;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        DisplayPlayerInfo();
        Console.WriteLine("Menu option:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Events\n  6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\nYou are currently level {_level}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int i = 0;
        foreach (Goal goal in _goals)
        {
            if (goal.GetDetailString().StartsWith("[ ]"))
            {
                Console.WriteLine($"{i}. {goal.GetShortName()}");
            }
            i++;
        }
    }

    public void ListGoalDettails()
    {
        Console.WriteLine("The goal dettails are: ");
        int i = 0;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDescription()}");
            i++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
        Console.Write("Which type of Goal you want to create? ");
        int goalChoice = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your Goal? ");
        string shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the ammount of point associated with this goal? ");
        string points = Console.ReadLine();
        switch (goalChoice)
        {
            case 1:
                SimpleGoal simpleGoal = new SimpleGoal(shortName, description, points);
                _goals.Add(simpleGoal);
                break;
            case 2:
                EternalGoal eternalGoal = new EternalGoal(shortName, description, points);
                _goals.Add(eternalGoal);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal(shortName, description, points, target, bonus);
                _goals.Add(checklistGoal);
                break;
            default:
                Console.WriteLine("Wrong number. Not creating a goal.");
                break;
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        int completeGoal = int.Parse(Console.ReadLine());
        _goals[completeGoal].RecordEvent();
        _score += int.Parse(_goals[completeGoal].GetPoints());
        if (_goals[completeGoal] is ChecklistGoal checklistGoal && _goals[completeGoal].IsComplete())
        {
            _score += checklistGoal.GetBonus();
            Console.WriteLine($"Congratulation! You have earned {checklistGoal.GetBonus() + int.Parse(_goals[completeGoal].GetPoints())} points.");
        }
        else
        {
            Console.WriteLine($"Congratulation! You have earned {_goals[completeGoal].GetPoints()} points.");
        }
        GetLevel();
    }

    public void SaveGoals()
    {
        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(';');
            switch (parts[0])
            {
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], parts[3]);
                    if (parts[4] == "True")
                    {
                        simpleGoal.RecordEvent();
                    }
                    _goals.Add(simpleGoal);
                    break;
                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], parts[3]);
                    _goals.Add(eternalGoal);
                    break;
                case "ChecklistGoal":
                    ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[5]), int.Parse(parts[4]));
                    for (int y = 0; y < int.Parse(parts[6]); y++)
                    {
                        checklistGoal.RecordEvent();
                    }
                    _goals.Add(checklistGoal);
                    break;
                default:
                    Console.WriteLine("Error. Exiting.");
                    break;
            }
        }
        GetLevel();
    }

    public void ListGoals()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailString());
        }
    }

    public void GetLevel()
    {
        _level = _score / 100;
    }

}