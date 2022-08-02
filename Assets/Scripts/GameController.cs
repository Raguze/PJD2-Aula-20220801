using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 10000;
    [SerializeField]
    private int health = 10000;

    private void Awake()
    {
        GameEvents.OnTestEvent.AddListener(TestEvent);
    }

    private void TestEvent ()
    {
        Debug.Log("Test Event");
    }

    void ApplyDamage (int damage)
    {
        health -= damage;
        float ratio = (float)health / maxHealth;
        GameEvents.OnDamagePlayer.Invoke(ratio);
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            GameEvents.OnTestEvent.Invoke();
        }

        if(Input.GetKeyDown(KeyCode.Z))
        {
            GameEvents.OnPlayerHealth.Invoke(Random.Range(0, 100));
        }

        ApplyDamage(1);
    }
}
