using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepHookFacingGround : MonoBehaviour
{
    public GameObject slewCrane;

    private float slewCraneX;

    public void RotateHook()
    {
        transform.Rotate(new Vector3(0,0,0));

        slewCraneX = Mathf.Abs(slewCrane.transform.localRotation.eulerAngles.x - 90F);

        Debug.Log("SlewCraneRotation" + slewCraneX);

        transform.Rotate(new Vector3(0, slewCraneX, 0));
    }
}
