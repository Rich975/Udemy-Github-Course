using UnityEngine;

public class Character
{
    public string name;
    public int exp = 0;

    public Character()
    {
        //name = "not assigned";
        Reset();
    }

    public Character(string name)
    {
        this.name = name;
    }

    public virtual void PrintStatsInfo()
    {
        Debug.Log($"The hero's name is {name} and he has {exp} exp points");
    }

    private void Reset()
    {
        this.name = "not assigned";
        this.exp = 0;
    }
}