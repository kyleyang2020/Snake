using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMove : MonoBehaviour
{
    // control direction of movement
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            direction = Vector2.up;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            direction = Vector2.left;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            direction = Vector2.down;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            direction = Vector2.right;
        }
    }

    // 
    void FixedUpdate()
    {
        this.transform.position = new Vector2(
            Mathf.Round(this.transform.position.x) + direction.x,
            Mathf.Round(this.transform.position.y) + direction.y
            );
    }
}
