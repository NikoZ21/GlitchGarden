using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDefenders : MonoBehaviour
{
    [SerializeField] GameObject cactus;

    private void OnMouseDown()
    {
        GameObject newDefender = Instantiate(cactus, transform.position, transform.rotation) as GameObject;
    }
}
