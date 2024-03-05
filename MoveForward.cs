using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwards : MonoBehaviour
{
    public float speed = 40.0f;
    public float xRange = 25;
    private GameObject obstacle;
    void Start()
    {
        
    }


    void Update()
    {
        

        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (transform.position.x < -xRange)
        {

            Destroy(gameObject);
        }
    }

}