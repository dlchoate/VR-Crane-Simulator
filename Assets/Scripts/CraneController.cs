using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneController : MonoBehaviour
{
    public float speed = 50.0f;
    public GameObject rotateableCraneObject;
    public GameObject rotateLever;
    public GameObject boomLever;
    public GameObject angleLever;
    public GameObject pulleyLever;
    public GameObject subBoom;
    public GameObject hook;
    public GameObject slewCrane;

    public bool rotateCol;

    // Start is called before the first frame update
    void Start()
    {
        rotateCol = true;
    }

    // Update is called once per frame
    void Update()
    {
        RotateController();
        ExtendController();
        AngleUpDownController();
        PulleyUpDownController();
    }

    public void SetRotationControl(bool n)
    {
        Debug.Log("attempting to change bool value to false.");

        rotateCol = n;

        Debug.Log(rotateCol);
    }

    public void RotateController()
    {
        if (rotateLever.transform.rotation.eulerAngles.z <= 360 && rotateLever.transform.rotation.eulerAngles.z >= 270 && rotateCol == true)
        {
            RotateLeft();
        }
        else if (rotateLever.transform.rotation.eulerAngles.z >= 1 && rotateLever.transform.rotation.eulerAngles.z <= 45 && rotateCol == true)
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
        if (angleLever.transform.rotation.eulerAngles.z <= 360 && angleLever.transform.rotation.eulerAngles.z >= 270)
        {
            CraneAngleUp();
        }
        else if (angleLever.transform.rotation.eulerAngles.z >= 1 && angleLever.transform.rotation.eulerAngles.z <= 45)
        {
            CraneAngleDown();
        }
    }

    public void PulleyUpDownController()
    {
        if (pulleyLever.transform.rotation.eulerAngles.z <= 360 && pulleyLever.transform.rotation.eulerAngles.z >= 270)
        {
            LowerPulley();
        }
        else if (pulleyLever.transform.rotation.eulerAngles.z >= 1 && pulleyLever.transform.rotation.eulerAngles.z <= 45)
        {
            RaisePulley();
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

    // Lowers the pully
    public void LowerPulley()
    {
        hook.transform.Translate(Vector3.down * Time.deltaTime);
    }

    // Raises the pully
    public void RaisePulley()
    {
        hook.transform.Translate(Vector3.up * Time.deltaTime);
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
        angleLever.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    public void ResetAngleZeroPulleyLever()
    {
        angleLever.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
