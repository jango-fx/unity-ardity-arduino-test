using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public bool isHit = false;
    public SerialController serialController;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "obstacle")
        {
            Debug.Log("GotHit: "+collision.impulse.magnitude);
            
            isHit = true;
            serialController.SendSerialMessage("!");
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "obstacle")
        {
            Debug.Log("GotTriggered");
            isHit = true;
        }
    }
}
