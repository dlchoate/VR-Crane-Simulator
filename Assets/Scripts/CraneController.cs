using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneController : MonoBehaviour
{
    public float speed = 50.0f;
    public GameObject rotateableCraneObject;
    public GameObject rotateLever;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateController();
    }

    public void RotateController()
    {
        Debug.Log("ROTATE CONTROLLER FUNCTION CALLED");

        if (rotateLever.transform.rotation.x < 0)
        {
            RotateLeft();
            Debug.Log("ROTATE LEFT");
        }
        //else if (rotateLever.transform.rotation.x >= 1F && rotateLever.transform.rotation.x <= 35F)
        //{
        //    RotateRight();
        //}
    }


    // Rotates the Crane Right
    public void RotateRight()
    {
        rotateableCraneObject.transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }

    // Rotates the Crane Right
    public void RotateLeft()
    {
        rotateableCraneObject.transform.Rotate(Vector3.down * speed * Time.deltaTime);
    }
}
