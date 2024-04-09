using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Person
{
    public int ExpPoint { get; private set; } = 50;


    public new void Start()
    {
        Debug.Log("Start Player class");
        Debug.Log($"Your health is {Health}");
        Debug.Log($"You name is {PersonName}");
        Debug.Log($"You have {ExpPoint} points");

        ShowStat();
        TakeDamage(50);
        Debug.Log("End Player class");
    }
    public override void ShowStat()
    {
        Debug.Log($"Your name is {PersonName} from Player class and you have {ExpPoint} Points");
    }

    public override void TakeDamage(int damageValue)
    {
        Health -= damageValue;
        Debug.Log($"My name is {PersonName}: After hitting with {damageValue} force, I have {Health} health");
    }
}



