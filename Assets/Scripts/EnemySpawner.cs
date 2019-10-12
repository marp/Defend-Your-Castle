using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField][Range(0.1f,2f)] float spawnPeriod = 1f;
    [SerializeField] GameObject enemyPrefab;
    void Start()
    {
        StartCoroutine(spawnContinously());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator spawnContinously()
    {
        while (true)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnPeriod);
        }
    }
}
