using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
     int bumps = 0;

    private void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.tag != "Hit"){
            Debug.Log("Score Incremented");
            bumps = bumps + 1;
            Debug.Log("You've bumped into a thing this many times: " + bumps);
        }else{
            Debug.Log("Object already hit. No score change.");
        }
        
        
    }
}
