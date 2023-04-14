using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public enum Axis {X, Y, Z};
    public Axis axis;
    [Range(-1, 1)]public float speed = 0.01f;
    [Range(-1, 1)] public float gravity = 1;

    void Start()
    {
        
    }

    void Update()
    {
        Physics.gravity = new Vector3(0, -8*gravity, 0);

        if(axis == Axis.X) this.transform.Rotate(speed, 0, 0, Space.World);
        else if(axis == Axis.Y) this.transform.Rotate(0, speed, 0, Space.World);
        else if(axis == Axis.Z) this.transform.Rotate(0, 0, speed, Space.World);
    }
}	