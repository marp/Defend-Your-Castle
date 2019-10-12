using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    Castle castle;
    void Start()
    {
        castle = FindObjectOfType<Castle>();
    }

    // Update is called once per frame
    void Update()
    { 
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, castle.transform.position, step);

        if (Vector3.Distance(transform.position, castle.transform.position) < 0.001f)
        {
            // Swap the position of the cylinder.
            castle.transform.position *= -1.0f;
        }
    }
}
