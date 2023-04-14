using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class ArdityVSBridge : MonoBehaviour
{
    public ScriptMachine visualScriptObject;
    public string eventName;
    public bool verbose = false;

    void OnConnectionEvent(bool success)
    {
        if(verbose) Debug.Log(success ? "Device connected" : "Device disconnected");
    }
    
    void OnMessageArrived(string msg)
    {
        if(verbose) Debug.Log("[ArdityReceiver]: " + msg); 
        CustomEvent.Trigger( visualScriptObject.gameObject, eventName, msg );
    }
}
