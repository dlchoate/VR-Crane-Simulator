using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSubBoomRetract : MonoBehaviour
{
    public GameObject controlObject;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("subboom"))
        {
            controlObject.GetComponent<CraneController>().SetSubBoomRetract(false);
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("subboom"))
        {
            controlObject.GetComponent<CraneController>().SetSubBoomRetract(true);
        }
    }
}
