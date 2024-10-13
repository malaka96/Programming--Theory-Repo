using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject weapon1;
    [SerializeField] private GameObject weapon2;
    [SerializeField] private GameObject weapon3;

    [SerializeField] private GameObject enemyPrefab;
    private int spawnAmount = 1;

    private void Update()
    {
        int enemyAmout = FindObjectsOfType<EnemyController>().Length;
        if(enemyAmout <= 0)
        {
            SpawnBalls();
        }
    }

    void SpawnBalls()
    {
        if (spawnAmount < 6)
        {
            spawnAmount++;
        }
        for (int i = 0; i < spawnAmount; i++)
        {
            float spawnRange = Random.Range(-18f, 18f);
            Instantiate(enemyPrefab, new Vector3(spawnRange, 1.5f, 10f), Quaternion.identity);
        }
    }

    public void HandleDDList(int val)
    {
        if(val == 0)
        {
            weapon1.SetActive(true);
            weapon2.SetActive(false);
            weapon3.SetActive(false);
        }
        if(val == 1)
        {
            weapon1.SetActive(false);
            weapon2.SetActive(true);
            weapon3.SetActive(false);
        }
        if(val == 2)
        {
            weapon1.SetActive(false);
            weapon2.SetActive(false);
            weapon3.SetActive(true);
        }
    }
}
