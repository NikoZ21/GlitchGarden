using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] float walkSpeed = 1f;
    [SerializeField] float health = 500f;

    void Update()
    {
        transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed)
    {
        walkSpeed = speed;
    }

}
