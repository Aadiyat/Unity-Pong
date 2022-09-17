using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleVerticalMovement : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, Input.GetAxis("Vertical"), 0) * moveSpeed * Time.deltaTime);
    }
}