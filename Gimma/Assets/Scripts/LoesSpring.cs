using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoesSpring : MonoBehaviour
{
    [SerializeField] private LayerMask platformsLayerMask;
    public float jumpforce = 10f;
    Rigidbody2D rb;
    private BoxCollider2D boxCollider2D;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider2D = transform.GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        isGrounded();
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpforce);
            
        }
        
        
    }
    private bool isGrounded(){
        RaycastHit2D raycasthit2d = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down * .1f, platformsLayerMask);
        Debug.Log(raycasthit2d.collider);
        return raycasthit2d.collider != null;
    }
}

