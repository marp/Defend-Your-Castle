using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class Drag : MonoBehaviour
{

    public Animator anim;

    private Vector3 screenPoint;
    private Vector3 offset;

    private Vector3 up;
    private Vector3 down;

    [SerializeField,Range(1f,10f)] float fallingLimit = 5f;

    public bool fallingDown = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if ((down.y - up.y) > fallingLimit)
        {
            anim.SetTrigger("death");
        }
        else
        {
            if (fallingDown)
            {
                anim.SetTrigger("gettingUp");
                fallingDown = false;
            }
        }
        Debug.Log(fallingDown);
    }

    void OnMouseDown()
    {
        up = transform.position;
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }
    
    void OnMouseUp()
    {
        down = transform.position;
        fallingDown = true;
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }

    //after death animation
    public void RemoveDeadBody()
    {
        Destroy(gameObject);

    }
}
