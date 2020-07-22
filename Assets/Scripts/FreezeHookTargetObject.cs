using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeHookTargetObject : MonoBehaviour
{
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionZ;
    }
}
