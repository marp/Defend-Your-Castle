using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    [SerializeField] int score = 0;
    [SerializeField] int health = 0;
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject shop;
    [SerializeField] bool shopVisible = false;
    public int GetScore()
    {
        return score;
    }
    public void SetScore(int scoreValue)
    {
        score = scoreValue;
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            var spawnEnemyPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));
            spawnEnemyPos.z = 0f;

            Instantiate(enemyPrefab, spawnEnemyPos, Quaternion.identity);
        }

        if (shopVisible)
        {
            shop.SetActive(true);
        }
        else
        {
            shop.SetActive(false);
        }
    }
    public void ToggleShop()
    {
        if (shopVisible)
        {
            shopVisible = false;
        }
        else
        {
            shopVisible = true;
        }
    }
}
