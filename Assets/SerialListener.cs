using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerialListener : MonoBehaviour
{
    public bool verbose = false;

    void OnConnectionEvent(bool success)
    {
        if(verbose) Debug.Log(success ? "Device connected" : "Device disconnected");
    }
    
    void OnMessageArrived(string msg)
    {
        if(verbose) Debug.Log("[ArdityReceiver]: " + msg);
        
        //! PARSE MESSAGE…
    }
}
