using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBallAtGameStart : MonoBehaviour
{   
    private static  readonly System.Random random = new System.Random();
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        float launchAngleInDegrees = RandomMirroredAngle(-45.0f, 45.0f);
        Vector3 launchDirection = PolarCoordinatesToRectangular(1.0f, launchAngleInDegrees*(float)Math.PI/180.0f);
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = launchDirection * speed;
    }

    // Update is called once per frame
    void Update()
    {   
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
    }

    float RandomMirroredAngle(float minRange, float maxRange){
        float angle = UnityEngine.Random.Range(minRange, maxRange);
        bool shouldFlip = random.Next(0,2) == 0;

        if(shouldFlip){
            angle += 180.0f;
        }
        Debug.Log(angle);

        return angle;
    }

    Vector3 PolarCoordinatesToRectangular(float r, float thetaInRadians){
        float x = (float)(r*Math.Cos(thetaInRadians));
        float y = (float)(r*Math.Sin(thetaInRadians));

        return new Vector3(x, y, 0.0f);
    }
}
