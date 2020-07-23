using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnappableObject : MonoBehaviour
{
    bool snapped = false;
    GameObject snapparent; // the gameobject this transform will be snapped to
    Vector3 offset; // the offset of this object's position from the parent

    public Transform snapchild;

    void Update()
    {
        if (snapped == true)
        {
            //retain this objects position in relation to the parent
            transform.position = snapparent.transform.position + offset;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "parentblock")
        {
            snapped = true;
            snapparent = col.gameObject;
            offset = transform.position - snapparent.transform.position; //store relation to parent
        }
    }

    public void Unsnap()
    {
        snapped = false;
        //snapchild.GetComponent<BoxCollider>().enabled = false;
        //snapparent.transform.parent = null;
        Debug.Log("Unsnap");
    }

}
