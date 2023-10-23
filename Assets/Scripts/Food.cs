using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public BoxCollider2D grid; // grid/space where food can spawn

    void Start()
    {
        RandomPos(); // randomizes position of food in beginning
    }

    // randomize food in a grid
    private void RandomPos()
    {
        Bounds bounds = grid.bounds; // defines limit of the space
        float x = Random.Range(bounds.min.x, bounds.max.x); // give random x value within the limit
        float y = Random.Range(bounds.min.y, bounds.max.y); // give random y value within the limit

        // round x,y values when moving position of food so it doesn't spawn inbetween spaces of game
        transform.position = new Vector2(Mathf.Round(x), Mathf.Round(y)); 
    }

    // if player hits food, move the food
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            RandomPos();
    }
}
