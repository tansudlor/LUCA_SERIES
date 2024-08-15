using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour
{
    public float spawnRate = 1f;
    public GameObject[] enemyPrefabs;
    public bool canSpawn = true;
    GameObject enemyToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {

        while (canSpawn)
        {
            
            yield return new WaitForSeconds(spawnRate); ;
            int rand = Random.Range(0, enemyPrefabs.Length);
            GameObject enemyToSpawn = enemyPrefabs[rand];
            enemyToSpawn = Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
            spawnRate = 3f ;
        }

    }
}
