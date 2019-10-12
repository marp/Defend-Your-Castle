using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    public int level = 1;
    [Header("Front sprites")]
    [SerializeField] Sprite[] frontWalls;

    [Header("Rear sprites")]
    [SerializeField] Sprite[] rearWalls;

    public void UpgradeCastle()
    {
        if ((level < frontWalls.Length) && (level < rearWalls.Length))
        {
            level++;
            UpdateCastle();
        }
    }

    public void DowngradeCastle()
    {
        if (level >= 2 )
        {
            level--;
            UpdateCastle();
        }
       

    }
    private void UpdateCastle()
    { 
            this.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = rearWalls[level-1];
            this.gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = frontWalls[level-1];
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    } 
}
