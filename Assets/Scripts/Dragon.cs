using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dragon : Person
{

    public new void Start()
    {
        Debug.Log($"Start Dragon class");
        Debug.Log($"Your health is {Health}");

        TakeDamage(60);
        Debug.Log("End Dragon class");
    }
    public override void TakeDamage(int damageValue)
    {
        Health -= damageValue;
        Debug.Log($"I, the mighty dragon, have lost {damageValue} hit points from a hunter's shot, I have {Health} health");
    }

}



