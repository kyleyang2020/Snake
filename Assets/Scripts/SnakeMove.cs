using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeMove : MonoBehaviour
{
    // control direction of movement
    private Vector2 direction;

    List<Transform> segments; // variable to store all body parts of snake body
    public Transform segmentPrefab; // variable to store the segment

    // Start is called before the first frame update
    void Start()
    {
        segments = new List<Transform>(); // creates a new list
        segments.Add(transform); // add head of snake to list
    }

    // Update is called once per frame
    void Update()
    {
        // wasd movement
        if(Input.GetKeyDown(KeyCode.W))
            direction = Vector2.up;
        if (Input.GetKeyDown(KeyCode.A))
            direction = Vector2.left;
        if (Input.GetKeyDown(KeyCode.S))
            direction = Vector2.down;
        if (Input.GetKeyDown(KeyCode.D))
            direction = Vector2.right;
    }

    // FixedUpdate is called at a fixed interval
    void FixedUpdate()
    {
        // counts through each segment of the snake
        for(int i = segments.Count - 1; i > 0; i--)
            segments[i].position = segments[i - 1].position;

        // moving the snake segments
        this.transform.position = new Vector2(
            Mathf.Round(this.transform.position.x) + direction.x,
            Mathf.Round(this.transform.position.y) + direction.y
            );
    }

    void Grow()
    {
        // grow segment to snake
        Transform _segments = Instantiate(segmentPrefab);
        _segments.position = segments[segments.Count - 1].position;
        segments.Add(_segments);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if it hits food add segment
        if (collision.tag == "Food")
            Grow();
        // if it hits itself/wall
        else if (collision.tag == "Wall")
        {
            SceneManager.LoadScene("GameOverScene"); // goes to gameover scene
        }
    }
}
