using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour
{
    [SerializeField] int score = 0;
    [SerializeField] int health = 0;
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject shop;
    [SerializeField] bool shopVisible = false;
    [SerializeField] TextMeshProUGUI stageText;
    [SerializeField] int stage = 1;
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
        changeShopVisibility();
    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            var spawnEnemyPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));
            spawnEnemyPos.z = 0f;

            Instantiate(enemyPrefab, spawnEnemyPos, Quaternion.identity);
        }
        stageText.text = "Stage "+stage;

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
        changeShopVisibility();
    }

    public void changeShopVisibility()
    {

        if (shopVisible)
        {
            shop.SetActive(true);
        }
        else
        {
            shop.SetActive(false);
        }
    }
}
