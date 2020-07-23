using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixPosition : MonoBehaviour
{
    public GameObject trackableObject;

    private Vector3 coord;

    // Update is called once per frame
    void Update()
    {
        coord = trackableObject.transform.position;
        transform.position = new Vector3(coord.x, -1F, coord.z);
    }
}
