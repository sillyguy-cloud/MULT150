using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript  : MonoBehaviour
{
    void Start()
    {
        int TakeDamageFromFireball(int damage, int playerHealth)
        {
            return playerHealth - damage;
        }
        int x = TakeDamageFromFireball(5, 100);
        Debug.Log("Player health: " + x);
        int y = TakeDamageFromFireball(25, 100);
        Debug.Log("Player health: " + y);
        int z = TakeDamageFromFireball(30, 50);
        Debug.Log("Player health: " + z);
    }

    void Update()
    {
        
    }
}
