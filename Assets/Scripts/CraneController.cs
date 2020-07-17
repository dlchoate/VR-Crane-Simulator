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
        Debug.Log(rotateLever.transform.rotation.eulerAngles.z);
        if (rotateLever.transform.rotation.eulerAngles.z < 0)
        {
            RotateLeft();
        }
        else if (rotateLever.transform.rotation.eulerAngles.z > 0)
        {
            RotateRight();
        }
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

    public void ResetAngleZero()
    {
        rotateLever.transform.rotation = Quaternion.Euler(0,90,0);
    }
}
