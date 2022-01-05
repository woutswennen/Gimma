using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridgeFall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == "Player"){
            Rigidbody2D ridged = GetComponent<Rigidbody2D>();
            ridged.constraints = RigidbodyConstraints2D.None;
        }
    }
}
