using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public float heath = 50f;
    
    public void  TakeDamage(float amount)
    {
        heath -= amount;
        if (heath <= 0f)
        {
            Die();
        }
    }

    void Die ()
    {
        UIManager.instance.killCount++;
        UIManager.instance.UpdateKillCounterUI();
        Destroy(gameObject);
    }
}
