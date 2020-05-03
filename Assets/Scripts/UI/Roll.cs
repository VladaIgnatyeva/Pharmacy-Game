using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{
    // Start is called before the first frame update
    float rotateX;
    float rotateY;
    float rotateZ;
    public float speed = 1;
    public float fallSpeed = 1;
    float curX;
    float curY;
    float curZ;

    void Start()
    {
       rotateX = Random.Range(0.0f, 1.0f) * speed;
       rotateY = Random.Range(0.0f, 1.0f) * speed;
       rotateZ = Random.Range(0.0f, 1.0f) * speed;
       curX = rotateX;
       curY = rotateY;
       curZ = rotateZ;
    }

    // Update is called once per frame
    void Update()
    { 
        curX = (curX + rotateX) % 360;
        curY = (curY + rotateY) % 360;
        curZ = (curZ + rotateZ) % 360;
        transform.eulerAngles = new Vector3(curX, curY, curZ);

        transform.position = new Vector3(transform.position.x , transform.position.y - fallSpeed * Time.deltaTime, transform.position.z);
        if(transform.position.y < -6.0f)
        {
            transform.position = new Vector3(transform.position.x , 6.0f, transform.position.z);
        }
    }
}
