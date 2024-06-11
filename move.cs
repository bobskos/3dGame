using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public int speed = 5;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            transform.Rotate(0.0f, -0.20f, 0.0f, Space.Self);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            transform.Rotate(0.0f, 0.20f, 0.0f, Space.Self);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 5);
        }

        if (Input.GetKey(KeyCode.A))
        {
            
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
           
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * 2;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed / 2;
        }

    }
        

    
}
