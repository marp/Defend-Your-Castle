using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    [Header("Walls sprites")]
    [SerializeField] int wallsLevel = 1;
    [SerializeField] Sprite walls1;
    [SerializeField] Sprite walls2;
    [SerializeField] Sprite walls3;
    [SerializeField] Sprite walls4;
    [SerializeField] Sprite walls5;
    [SerializeField] Sprite walls6;
    [SerializeField] Sprite walls7;
    [SerializeField] Sprite walls8;
    [SerializeField] Sprite walls9;
    [SerializeField] Sprite walls10;
    [SerializeField] Sprite walls11;
    [SerializeField] Sprite walls12;
    [SerializeField] Sprite walls13;
    [SerializeField] Sprite walls14;
    [SerializeField] Sprite walls15;
    [SerializeField] Sprite walls16;
    [SerializeField] Sprite walls17;
    [SerializeField] Sprite walls18;
    [SerializeField] Sprite walls19;
    [SerializeField] Sprite walls20;

    [Header("Base sprites")]
    [SerializeField] int baseLevel = 1;
    [SerializeField] Sprite base1;
    [SerializeField] Sprite base2;
    [SerializeField] Sprite base3;
    [SerializeField] Sprite base4;
    [SerializeField] Sprite base5;
    [SerializeField] Sprite base6;
    [SerializeField] Sprite base7;

    public void UpgradeCastle()
    {
        wallsLevel++;
        baseLevel++;
        UpdateCastle();
    }

    public void DowngradeCastle()
    {
        wallsLevel--;
        baseLevel--;
        UpdateCastle();

    }
    private void UpdateCastle()
    {
        if (wallsLevel == 1 && baseLevel == 1)
        {
            this.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = base1;
            this.gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = walls1;
        }

        if (wallsLevel == 2 && baseLevel == 2)
        {
            this.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = base2;
            this.gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = walls2;
        }

        if (wallsLevel == 3 && baseLevel == 3)
        {
            this.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = base3;
            this.gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = walls3;
        }

        if (wallsLevel == 4 && baseLevel == 4)
        {
            this.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = base4;
            this.gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = walls4;
        }

        if (wallsLevel == 5 && baseLevel == 5)
        {
            this.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = base5;
            this.gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = walls5;
        }

        if (wallsLevel == 6 && baseLevel == 6)
        {
            this.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = base6;
            this.gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = walls6;
        }

        if (wallsLevel == 7 && baseLevel == 7)
        {
            this.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = base7;
            this.gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = walls7;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    } 
}
