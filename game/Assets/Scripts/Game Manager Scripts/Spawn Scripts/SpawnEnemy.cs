using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _enemiesPrefabs;

    [SerializeField]
    [Range(10, 100)]
    private int _numberOfEnemies;

    [SerializeField]
    [Range(50, 100)]
    private int _enemiesHp;

    [SerializeField]
    [Range(10, 75)]
    private int _enemiesAttackDamage;

    [SerializeField]
    InstantiateTiles points;

    void Start()
    {
        for (int i=0; i< _numberOfEnemies && i < points.spawnPoints.Count; i++)
        {
            int posToSpawn = (int)Random.Range(3, points.spawnPoints.Count);
            int index = (int)Random.Range(0, _enemiesPrefabs.Length);

            GameObject newEnemy = Instantiate(_enemiesPrefabs[index], points.spawnPoints[posToSpawn], Quaternion.identity);
            newEnemy.GetComponent<EnemyHP>()._hP = _enemiesHp;
            newEnemy.GetComponent<Attack>().attackDamage = _enemiesAttackDamage;
            newEnemy.transform.parent = this.transform;
        }
    }
}
