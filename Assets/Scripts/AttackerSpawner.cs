using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{


    [SerializeField] float minSpawnDelay;
    [SerializeField] float maxSpawnDelay;
    [SerializeField] Attacker[] atackerPrefabs;
    public bool spawn = true;


    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        int index = Random.Range(0, atackerPrefabs.Length);
        Spawn(index);
    }

    private void Spawn(int index)
    {
        var newAttacker = Instantiate(atackerPrefabs[index], transform.position, Quaternion.identity) as Attacker;
        newAttacker.transform.parent = transform;

    }
}
