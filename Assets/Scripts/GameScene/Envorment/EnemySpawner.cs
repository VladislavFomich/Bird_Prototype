using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Singleton<EnemySpawner>
{
    public GameObject[] enemies;
    public GameObject[] points;
    public GameObject platforms;
    public MoveSpawnPoint[] spawmPointMove;

    private bool needSpawn;
    private int randBool;
    private int randObj;
    private void Start()
    {
        for (int i = 0; i < spawmPointMove.Length; i++)
        {
            spawmPointMove[i].speed = Random.Range(-5f, 5f);
        }
    }

    public void SpawnObject()
    {
        for (int i = 0; i < points.Length; i++)
        {
            randBool = Random.Range(0, 2);
            if (randBool == 0)
                needSpawn = false;
            else
                needSpawn = true;

            if (needSpawn == true)
            {
                randObj = Random.Range(0, enemies.Length);
                var instance = Instantiate(enemies[randObj], points[i].transform.position, transform.rotation);
                instance.transform.SetParent(platforms.transform);
            }
        }
    }
}
