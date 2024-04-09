using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public abstract class Person : MonoBehaviour
{
    public string PersonName { get; private set; } = "Indestructible";
    
    private int _health = 100;
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
                _health = 100;
            }
            else
                _health = value;
        }
    }

    public void Start()
    {
        //Debug.Log("Start Person class");
        //Debug.Log($"Your health is {Health}");
        //Debug.Log($"Your name is {PersonName}");

        //Health = 80;

        //Debug.Log($"Your new health is {Health}");

        //ShowStat();
        //Debug.Log("End Person class");
    }

    public virtual void ShowStat()
    {
        //Debug.Log($"Your name is {PersonName} from Person class");
    }

    public abstract void TakeDamage(int damageValue);
}
