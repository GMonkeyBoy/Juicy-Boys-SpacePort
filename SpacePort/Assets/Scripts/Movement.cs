using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    bool facingRight = true; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += move * Time.deltaTime * moveSpeed; 

        if(Input.GetAxis("Horizontal") > 0 && !facingRight)
        {
            turnAround();
        }
        else if (Input.GetAxis("Horizontal") < 0 && facingRight)
        {
            turnAround();
        }
    }
    
    void turnAround()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
