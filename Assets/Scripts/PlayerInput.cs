using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public string inputAxisName;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 movementDirecton = new Vector2(0, Input.GetAxis(inputAxisName)); 
        GetComponent<PaddleVerticalMovement>().updatePosition(movementDirecton);
    }
}
