using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayStars : MonoBehaviour
{
    [SerializeField] Text starText;
    public int stars = 100;
    private void Start()
    {
        UpdateDisplay();
    }
    public void SpendingStars(int cost)
    {
        stars -= cost;
        UpdateDisplay();
    }
    public void AddingStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }
    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }
    public bool HaveEnoughStars(int cost)
    {
        return stars >= cost;
    }
}
