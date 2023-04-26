using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject target;

    [Header("Camera height values")]
    public float maxHeight = 10.0f;
    public float minHeight = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        float verticalInput = Input.GetAxis("Mouse Y");

        Vector3 cameraMovement = new Vector3(0, verticalInput, 0);
        
        transform.Translate(cameraMovement * 10 * Time.deltaTime);
        
        transform.LookAt(target.transform);

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, minHeight, maxHeight), transform.position.z);
    }
}