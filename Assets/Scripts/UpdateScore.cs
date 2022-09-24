using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision){
        foreach(ContactPoint2D contact in collision.contacts){
            GameObject contactObject = contact.rigidbody.gameObject;
            if(contactObject.tag == "goalpost"){
                contactObject.GetComponentInParent<PlayerScore>().incrementScore();
                Debug.Log(contactObject.GetComponentInParent<PlayerScore>().getScore());
                break;
            }
        }
    }
}
