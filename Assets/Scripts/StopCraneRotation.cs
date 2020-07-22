using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCraneRotation : MonoBehaviour
{
    public GameObject controlObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("boom"))
        {
            Debug.Log("OnTriggerEnter boom");
            controlObject.GetComponent<CraneController>().SetRotationControl(false);
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("boom"))
        {
            Debug.Log("OnTriggerExit boom");
            controlObject.GetComponent<CraneController>().SetRotationControl(true);
        }
    }
}
