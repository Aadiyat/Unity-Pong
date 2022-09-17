using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleVerticalMovement : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    private Rigidbody2D m_rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        m_rigidbody2d.velocity = new Vector3(0, Input.GetAxis("Vertical"), 0) * moveSpeed;
    }
}
