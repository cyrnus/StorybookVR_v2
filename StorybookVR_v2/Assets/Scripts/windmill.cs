using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windmill : MonoBehaviour
{
    public GameObject windmillBlades;
    public float leverPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leverPos = transform.rotation.x;
        var motor = windmillBlades.GetComponent<HingeJoint>().motor;
        motor.targetVelocity = leverPos * 100;
        windmillBlades.GetComponent<HingeJoint>().motor = motor;
    }
}
