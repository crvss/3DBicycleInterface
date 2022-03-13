using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeMovement : MonoBehaviour
{
    [SerializeField] float horizontal = Input.GetAxis("Horizontal");
    [SerializeField] float vertical = Input.GetAxis("Vertical");
    float speed = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
    }
}
