using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Person
{
    public int ExpPoint { get; private set; } = 50;

    [SerializeField] private int _expPoints = 50;

    public new void Start()
    {
        Debug.Log("Start Player class");
        Debug.Log($"Your health is {Health}");
        Debug.Log($"You name is {PersonName}");
        Debug.Log($"You have {ExpPoint} points");

        Health = 60;

        Debug.Log($"YOur new health is {Health}");

        ShowStat();
        Debug.Log("End Player class");
    }
    public override void ShowStat()
    {
        Debug.Log($"Your name is {PersonName} from Player class and you have {ExpPoint} Points");
    }
}



