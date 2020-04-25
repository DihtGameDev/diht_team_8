using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMovement : MonoBehaviour
{
    float speed = 0.2f;

    private Rigidbody2D person;
    
    // Start is called before the first frame update
    void Start()
    { 
        person = GetComponent<Rigidbody2D>();
        person.MovePosition(new Vector3(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            var toPoint = new Vector3(person.position.x - speed, person.position.y, 0);
            person.MovePosition(toPoint);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            var toPoint = new Vector3(person.position.x + speed, person.position.y, 0);
            person.MovePosition(toPoint);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            var toPoint = new Vector3(person.position.x, person.position.y + speed, 0);
            person.MovePosition(toPoint);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            var toPoint = new Vector3(person.position.x, person.position.y - speed, 0);
            person.MovePosition(toPoint);
        }
    }
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("COLLISION");
    }
}
