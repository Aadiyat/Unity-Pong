using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleVerticalMovement : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public ContactFilter2D movementFilter;

    private List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();
    private Rigidbody2D rigidBody;
    private float collisionOffset = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        updatePosition();
    }

    private void updatePosition()
    {
        Vector2 movementDirecton = new Vector2(0, Input.GetAxis("Vertical"));
        bool willCollide = checkCollisions(movementDirecton);
        Debug.Log(willCollide);
        if(!willCollide) rigidBody.MovePosition(rigidBody.position + movementDirecton * moveSpeed * Time.deltaTime);
    }

    private bool checkCollisions(Vector2 movementDirection){
        int numCollisions = rigidBody.Cast(
            movementDirection,
            movementFilter,
            castCollisions,
            moveSpeed * Time.fixedDeltaTime + collisionOffset
        );

       if (castCollisions.Exists(collider => collider.rigidbody.bodyType == RigidbodyType2D.Static))
            return true;
        
        return false;
    }
}
