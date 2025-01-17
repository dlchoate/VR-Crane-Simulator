﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneController : MonoBehaviour
{
    public float speed = 10.0F;
    public GameObject rotateableCraneObject;
    public GameObject rotateLever;
    public GameObject boomLever;
    public GameObject angleLever;
    public GameObject pulleyLever;
    public GameObject subBoom;
    public GameObject hook;
    public GameObject slewCrane;

    public GameObject pullyHead;
    public GameObject lerpObject;

    public bool rotateConRight;
    public bool rotateConLeft;

    public bool angleConUp;
    public bool angleConDown;

    public bool subBoomExt;
    public bool subBoomRct;

    // Start is called before the first frame update
    void Start()
    {
        rotateConRight = true;
        rotateConLeft = true;

        angleConUp = true;
        angleConDown = true;

        subBoomExt = true;
        subBoomRct = true;
    }

    // Update is called once per frame
    void Update()
    {
        RotateController();
        ExtendController();
        AngleUpDownController();
        PulleyUpDownController();
    }

    public void SetSubBoomExtend(bool n)
    {
        subBoomExt = n;
    }

    public void SetSubBoomRetract(bool n)
    {
        subBoomRct = n;
    }

    public void SetAngleControlDown(bool n)
    {
        angleConDown = n;
    }

    public void SetAngleControlUp(bool n)
    {
        angleConUp = n;
    }

    public void SetRotationControlRight(bool n)
    {
        rotateConRight = n;
    }

    public void SetRotationControlLeft(bool n)
    {
        rotateConLeft = n;
    }

    public void RotateController()
    {
        if (rotateLever.transform.rotation.eulerAngles.z <= 360 && rotateLever.transform.rotation.eulerAngles.z >= 270 && rotateConLeft == true)
        {
            RotateLeft();
        }
        else if (rotateLever.transform.rotation.eulerAngles.z >= 1 && rotateLever.transform.rotation.eulerAngles.z <= 45 && rotateConRight == true)
        {
            RotateRight();
        }
    }

    public void ExtendController()
    {
        if (boomLever.transform.rotation.eulerAngles.z <= 360 && boomLever.transform.rotation.eulerAngles.z >= 270 && subBoomRct == true)
        {
            RetractSubBoom();
        }
        else if (boomLever.transform.rotation.eulerAngles.z >= 1 && boomLever.transform.rotation.eulerAngles.z <= 45 && subBoomExt == true)
        {
            ExtendSubBoom();
        }
    }

    public void AngleUpDownController()
    {
        if (angleLever.transform.rotation.eulerAngles.z <= 360 && angleLever.transform.rotation.eulerAngles.z >= 270 && angleConUp == true)
        {
            CraneAngleUp();
        }
        else if (angleLever.transform.rotation.eulerAngles.z >= 1 && angleLever.transform.rotation.eulerAngles.z <= 45 && angleConDown == true)
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
        hook.transform.position = Vector3.MoveTowards(hook.transform.position, pullyHead.transform.position, .3f * Time.deltaTime);
        //hook.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    // Raises the pully
    public void RaisePulley()
    {
        hook.transform.position = Vector3.MoveTowards(hook.transform.position, lerpObject.transform.position, .3f * Time.deltaTime);
        //hook.transform.Translate(Vector3.back * speed * Time.deltaTime);
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
        pulleyLever.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
