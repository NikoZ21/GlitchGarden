using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int cost = 100;

    public int GetStarCost()
    {
        return cost;
        
    }
     public void AddStars(int amount)
    {
        FindObjectOfType<DisplayStars>().AddingStars(amount);
    }
}
