using System;
using System.ComponentModel;

class GoalManager
{
    public List<Goal> Goals { get; set; }
    start();
    DisplayPlayerInfo();
    ListGoalNames();
    ListGoalDetails();
    CreateGoal();
    record();
    SaveGoals();
    LoadGoals();
}
class SimpleGoal
{
    isComplete = false;
    SimpleGoal(name, DescriptionAttribute, points){
        RecordEvent();
        IsComplete();
        GetStringRepresntation();
    }
}
class EternalGoal
{
    EternalGoal(name, description) : base(name, description) {
        RecordEvent();
        IsComplete();
        GetStringRepresntation();
    }
}
class ChecklistGoal
{
    amountCompleted = 0;
    targetAmount = 0;
    bonusPoints = 0;
    ChecklistGoal(name, description, targetAmount, bonusPoints) : base(name, description) {
        this.targetAmount = targetAmount;
        this.bonusPoints = bonusPoints;
        RecordEvent();
        IsComplete();
        GetStringRepresentation();
    }
}
