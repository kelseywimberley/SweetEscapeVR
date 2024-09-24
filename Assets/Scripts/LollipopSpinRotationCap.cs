using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LollipopSpinRotationCap : MonoBehaviour
{
    public bool correctPosition;
    public float startingRot;
    public float endingRot;

    private float currentRot;

    void Start()
    {
        currentRot = transform.eulerAngles.y;
    }

    void Update()
    {
        if (currentRot != transform.eulerAngles.y)
        {
            if (transform.eulerAngles.y < -60.0f)
            {
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 360.0f, 0);
            }
            else if (transform.eulerAngles.y > 300.0f)
            {
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y - 360.0f, 0);
            }

            currentRot = transform.eulerAngles.y;

            if (currentRot >= startingRot && currentRot <= endingRot)
            {
                correctPosition = true;
            }
            else
            {
                correctPosition = false;
            }
        }
    }
}
