using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public GameObject camera;

    [Header("Player movement variables")]
    public float moveSpeed = 5f;
    public float rotationSensitivity = 1f;

    [Header("Camera variables")]
    float lowerBound = -15f;
    float upperBound = 25f;


    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float rotateHorizontal = Input.GetAxis("Mouse X");

        Vector3 movement = new Vector3(x, 0, z);

        transform.Translate(movement * moveSpeed * Time.deltaTime);
        transform.RotateAround(player.transform.position, -Vector3.up, rotateHorizontal * rotationSensitivity);
    }
}
