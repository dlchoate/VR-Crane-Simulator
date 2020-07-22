using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCraneRotationRight : MonoBehaviour
{
    public GameObject controlObject;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("boom"))
        {
            controlObject.GetComponent<CraneController>().SetRotationControlRight(false);
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("boom"))
        {
            controlObject.GetComponent<CraneController>().SetRotationControlRight(true);
        }
    }
}
