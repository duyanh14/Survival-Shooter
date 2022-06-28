using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject enemyPrefab;
    
    private int i; 

    void Update()
    {
        if (Time.time> i)
        {
            i += 5;
            float spawnY = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
            float spawnX = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);
 
            Vector2 spawnPosition = new Vector2(spawnX, spawnY);
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
