using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        // "Other" is the thing that our collider object has collided with
        if(other.gameObject.tag == "Player"){
            GetComponent<MeshRenderer>().material.color = Color.red;
            // No need for "Other" since this is basically self referential
            gameObject.tag = "Hit";
        }
        // Accessing the Mesh Renderer
        
    }
}
