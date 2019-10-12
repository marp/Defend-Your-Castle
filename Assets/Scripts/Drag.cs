using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class Drag : MonoBehaviour
{

    private Vector3 screenPoint;
    private Vector3 offset;

    private Vector3 up;
    private Vector3 down;

    [SerializeField,Range(1f,10f)] float fallingLimit = 5f;

    void Start()
    {
        
    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if ((down.y - up.y) > fallingLimit)
        {
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Slabo!");
            Debug.Log(down.y-up.y);

        }
    }

    void OnMouseDown()
    {
        up = transform.position;
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }
    
    void OnMouseUp()
    {
        down = transform.position;
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
}
