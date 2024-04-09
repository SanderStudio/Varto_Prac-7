using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public string PersonName { get; private set; } = "Indestructible";
    
    private int _health = 20;
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            if (value < 0 || value > 100)
            {
                Debug.Log("Invalid health value");
                _health = 20;
            }
            else
                _health = value;
        }
    }

    public void Start()
    {
        Debug.Log("Start Person class");
        Debug.Log(Health);
        Debug.Log($"{PersonName}");

        Health = 80;

        Debug.Log(Health);
        Debug.Log($"{PersonName}");

        Health = 200;

        Debug.Log(Health);
        Debug.Log($"{PersonName}");
        //ShowStat();
        Debug.Log("End Person class");
    }

    //public virtual void ShowStat()
    //{
    //    Debug.Log($"Your name is {PersonName} from Person class");
    //}
}
