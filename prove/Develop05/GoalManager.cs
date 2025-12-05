using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _level; 

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
    }

    public void DisplayPlayerInfo()
    {
        _level = _score / 1000 + 1;
        Console.WriteLine($"Current Score: {_score} points | Level: {_level}");
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type selected.");
                break;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nThe Goals are:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("You currently have no goals set.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailString()}");
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails(); 
        
        Console.Write("\nWhich goal did you accomplish? ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= _goals.Count)
        {
            Goal goal = _goals[index - 1];
            
            int pointsEarned = goal.RecordEvent();
            _score += pointsEarned;
            
            Console.WriteLine($"You earned {pointsEarned} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number entered.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);

                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine($"\nGoals successfully saved to {filename}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving: {ex.Message}");
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename of the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }
        
        try
        {
            _goals.Clear(); 
            string[] lines = File.ReadAllLines(filename);

            if (lines.Length > 0)
            {
                _score = int.Parse(lines[0]);
            }

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(':'); 

                string goalType = parts[0];
                string[] details = parts[1].Split(','); 

                Goal newGoal = CreateGoalObject(goalType, details);
                if (newGoal != null)
                {
                    _goals.Add(newGoal);
                }
            }
            Console.WriteLine($"\nGoals successfully loaded from {filename}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading: {ex.Message}");
            _goals.Clear(); 
            _score = 0;
        }
    }
    
    private Goal CreateGoalObject(string type, string[] details)
    {
        string name = details[0];
        string description = details[1];
        int points = int.Parse(details[2]);

        switch (type)
        {
            case "SimpleGoal":
                bool isComplete = bool.Parse(details[3]);
                return new SimpleGoal(name, description, points, isComplete);
                
            case "EternalGoal":
                return new EternalGoal(name, description, points);
                
            case "ChecklistGoal":
                int target = int.Parse(details[3]);
                int bonus = int.Parse(details[4]);
                int completed = int.Parse(details[5]);
                return new ChecklistGoal(name, description, points, target, bonus, completed);
                
            default:
                Console.WriteLine($"Unknown goal type found: {type}");
                return null;
        }
    }
}