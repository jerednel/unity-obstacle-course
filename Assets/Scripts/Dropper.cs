using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidBody;
    [SerializeField] float dropDelay = 3f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > dropDelay){
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
