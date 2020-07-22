using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSubBoomExtend : MonoBehaviour
{
    public GameObject controlObject;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("subboom"))
        {
            controlObject.GetComponent<CraneController>().SetSubBoomExtend(false);
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("subboom"))
        {
            controlObject.GetComponent<CraneController>().SetSubBoomExtend(true);
        }
    }
}
