using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBallAtGameStart : MonoBehaviour
{   
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
