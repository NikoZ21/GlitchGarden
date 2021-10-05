using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDefenders : MonoBehaviour
{
    [SerializeField] GameObject cactus;

    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicked());

    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = snapToGrid(worldPos);
        return gridPos;
    }

    private Vector2 snapToGrid(Vector2 worldPos)
    {
        float newX = Mathf.RoundToInt(worldPos.x);
        float newY = Mathf.RoundToInt(worldPos.y) + 0.2f;
        return new Vector2(newX, newY);
    }

    private void SpawnDefender(Vector2 worlPos)
    {
        GameObject newDefender = Instantiate(cactus, worlPos, transform.rotation) as GameObject;
    }
}
