using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject zuchinniPrefab, gun;


    public void Fire()
    {
        Instantiate(zuchinniPrefab, gun.transform.position, Quaternion.identity);
    }
}
