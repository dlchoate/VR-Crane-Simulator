using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCraneRotationLeft : MonoBehaviour
{
    public GameObject controlObject;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("boom"))
        {
            controlObject.GetComponent<CraneController>().SetRotationControlLeft(false);
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("boom"))
        {
            controlObject.GetComponent<CraneController>().SetRotationControlLeft(true);
        }
    }
}
