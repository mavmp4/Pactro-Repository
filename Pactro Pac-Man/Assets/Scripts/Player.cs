using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 4.0f;

    private Vector2 direction = Vector2.zero;

    private float startingScale;

    // Start is called before the first frame update
    void Start()
    {
        startingScale = transform.localScale.x;
    }

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Vector2.right;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Vector2.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();

        Move();

        Rotate();
    }

    private void Move()
    {
        transform.localPosition += (Vector3)(direction * speed) * Time.deltaTime;
    }

    private void Rotate()
    {
        if(direction == Vector2.left)
        {
            transform.localScale = new Vector3(-startingScale, startingScale, startingScale);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (direction == Vector2.right)
        {
            transform.localScale = new Vector3(startingScale, startingScale, startingScale);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if(direction == Vector2.up)
        {
            transform.localScale = new Vector3(startingScale, startingScale, startingScale);
            transform.localRotation = Quaternion.Euler(0, 0, 90);
        }
        else if(direction == Vector2.down)
        {
            transform.localScale = new Vector3(startingScale, startingScale, startingScale);
            transform.localRotation = Quaternion.Euler(0, 0, 270);
        }
    }
}
