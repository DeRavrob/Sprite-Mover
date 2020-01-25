using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    private Transform tf;
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move up if the player presses up.
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.RightShift) && Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Only works if shift is held down, moves the player up one meter.
            tf.position = tf.position + Vector3.up * 1.0f;
        }
        else
        {
            //Only works if shift isn't held down.
            if (Input.GetKey(KeyCode.UpArrow) &! Input.GetKey(KeyCode.LeftShift))
            {
                tf.position = tf.position + Vector3.up * Time.deltaTime * speed;
            }
        }

        //Move right if the player presses right.
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKey(KeyCode.RightShift) && Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Only works if shift is held down, moves the player right one meter.
            tf.position = tf.position + Vector3.right * 1.0f;
        }
        else
        {
            //Only works if shift isn't held down.
            if (Input.GetKey(KeyCode.RightArrow) & !Input.GetKey(KeyCode.LeftShift))
            {
                tf.position = tf.position + Vector3.right * Time.deltaTime * speed;
            }
        }

        //Move left if the player presses left.
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightShift) && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Only works if shift is held down, moves the player left one meter.
            tf.position = tf.position + Vector3.left * 1.0f;
        }
        else
        {
            //Only works if shift isn't held down.
            if (Input.GetKey(KeyCode.LeftArrow) & !Input.GetKey(KeyCode.LeftShift))
            {
                tf.position = tf.position + Vector3.left * Time.deltaTime * speed;
            }
        }

        //Move down if the player presses down.
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightShift) && Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Only works if shift is held down, moves the player down one meter.
            tf.position = tf.position + Vector3.down * 1.0f;
        }
        else
        {
            //Only works if shift isn't held down.
            if (Input.GetKey(KeyCode.DownArrow) & !Input.GetKey(KeyCode.LeftShift))
            {
                tf.position = tf.position + Vector3.down * Time.deltaTime * speed;
            }
        }

    }
}
