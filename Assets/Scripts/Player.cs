using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Person
{
    public int ExpPoint { get; private set; } = 50;

    [SerializeField] private int _expPoints = 50;

    public void Start()
    {
        Debug.Log("Start Player class");
        Debug.Log(Health);
        Debug.Log(PersonName);
        Debug.Log(ExpPoint);

        Health = 60;

        Debug.Log(Health);

        //ShowStat();
        Debug.Log("End Player class");
    }
}

//    public override void ShowStat()
//    {
//        Debug.Log($"Your name is {PersonName} from Player class and you have {_expPoints} exp Points");
//    }
//}
