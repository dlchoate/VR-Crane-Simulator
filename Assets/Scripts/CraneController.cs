using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneController : MonoBehaviour
{
    public float speed = 50.0f;
    public GameObject rotateableCraneObject;
    public GameObject rotateLever;
    public GameObject boomLever;
    public GameObject raiseLever;
    public GameObject subBoom;
    public GameObject slewCrane;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateController();
        ExtendController();
        AngleUpDownController();
    }

    public void RotateController()
    {
        if (rotateLever.transform.rotation.eulerAngles.z <= 360 && rotateLever.transform.rotation.eulerAngles.z >= 270)
        {
            RotateLeft();
        }
        else if (rotateLever.transform.rotation.eulerAngles.z >= 1 && rotateLever.transform.rotation.eulerAngles.z <= 45)
        {
            RotateRight();
        }
    }

    public void ExtendController()
    {
        if (boomLever.transform.rotation.eulerAngles.z <= 360 && boomLever.transform.rotation.eulerAngles.z >= 270)
        {
            RetractSubBoom();
        }
        else if (boomLever.transform.rotation.eulerAngles.z >= 1 && boomLever.transform.rotation.eulerAngles.z <= 45)
        {
            ExtendSubBoom();
        }
    }

    public void AngleUpDownController()
    {
        if (raiseLever.transform.rotation.eulerAngles.z <= 360 && raiseLever.transform.rotation.eulerAngles.z >= 270)
        {
            CraneAngleUp();
        }
        else if (raiseLever.transform.rotation.eulerAngles.z >= 1 && raiseLever.transform.rotation.eulerAngles.z <= 45)
        {
            CraneAngleDown();
        }
    }

    // Extends the subboom game object
    public void ExtendSubBoom()
    {
        subBoom.transform.Translate(Vector3.left * Time.deltaTime);
    }

    // Retracts the subboom game object
    public void RetractSubBoom()
    {
        subBoom.transform.Translate(Vector3.right * Time.deltaTime);
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

    // Raises angle of crane.
    public void CraneAngleUp()
    {
        slewCrane.transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }

    // Lowers angle of crane.
    public void CraneAngleDown()
    {
        slewCrane.transform.Rotate(Vector3.left * speed * Time.deltaTime);
    }

    public void ResetAngleZeroBoomLever()
    {
        boomLever.transform.rotation = Quaternion.Euler(0,0,0);
    }

    public void ResetAngleZeroRotateLever()
    {
        rotateLever.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    public void ResetAngleZeroRaiseLever()
    {
        raiseLever.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
