public class SimpleGoal : Goal
{
    private bool _IsComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _IsComplete = false;
    }

    public override string GetDetailString()
    {
        if (_IsComplete)
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal;{_shortName};{_description};{_points};{_IsComplete}";
    }

    public override bool IsComplete()
    {
        return _IsComplete;
    }

    public override void RecordEvent()
    {
        _IsComplete = true;
    }
}