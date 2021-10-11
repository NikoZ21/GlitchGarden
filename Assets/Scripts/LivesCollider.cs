using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesCollider : MonoBehaviour
{
    [SerializeField] int damageByAttackers = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var attacker = collision.GetComponent<Attacker>();
        if (attacker)
        {
            FindObjectOfType<DisplayLives>().TakeLives(damageByAttackers);
        }
    }
}
