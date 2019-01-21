using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    public Vector2 movepos;

	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}

    private void Update()
    {
        MovePosition();
    }

    public void MovePosition()
    {
        if (movepos != Vector2.zero)
        {
            Vector2 newPos = movepos;

            newPos.x += transform.position.x;
            newPos.y += transform.position.y;

            rb.MovePosition(newPos);
        }
    }
}
