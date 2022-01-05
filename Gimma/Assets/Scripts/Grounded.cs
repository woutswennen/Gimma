using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{

    GameObject Player;
    
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
        Debug.Log(Player);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Ground"){
            Player.GetComponent<LoesWandel>().isGrounded = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "Ground"){
            Player.GetComponent<LoesWandel>().isGrounded = false;
        }
        
    }
}
