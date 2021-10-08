using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;
    private void OnMouseDown()
    {

        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (var item in buttons)
        {
            item.GetComponent<SpriteRenderer>().color = Color.black;
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<SpawnDefenders>().SetDefender(defenderPrefab);
    }
}
