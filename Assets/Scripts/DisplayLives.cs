using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLives : MonoBehaviour
{
    [SerializeField] Image[] hearts;
    [SerializeField] int currentHealth = 3;



    private void Update()
    {
        UpdateHealth();
    }
    public void TakeLives(int damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0)
        {
            //EndTheGame
            Debug.Log("Game Over");
        }
    }
    public void UpdateHealth()
    {
        for (int i = 2; i >= 0; i--)
        {
            if (i * 1 > currentHealth)
            {
                hearts[i].color = Color.black;
            }
        }
    }
}
