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
        transform.rotation = Quaternion.identity;
        float step = speed * Time.deltaTime;
        transform.Translate(Vector2.right * step);
    }
}
