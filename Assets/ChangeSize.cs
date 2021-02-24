using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    // Start is called before the first frame update
    Camera cam1;
    // Vector3 size = transform.localScale;

    Vector3 lTemp;
    Vector3 pivotOffset;
    Vector3 camOffset;
    const float sizeIncrement = 0.2f;

    float currentSize = 1f;
    ThirdPersonOrbitCamBasic refScript;

    float pivotY = 1.7f;
    float camOffsetZ = -3f;


    void Start()
    {
        refScript = GetComponentInChildren<ThirdPersonOrbitCamBasic>();
        camOffset = refScript.camOffset;
        pivotOffset = refScript.pivotOffset;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            currentSize = currentSize + sizeIncrement;
            pivotY = currentSize * 1.7f;
            camOffsetZ = currentSize * -3f;
            pivotOffset = new Vector3(0f, pivotY, 0f);
            camOffset = new Vector3(0f, 0f, camOffsetZ);
            refScript.SetTargetOffsets(pivotOffset, camOffset);
            lTemp = transform.localScale;
            lTemp.x += sizeIncrement;
            lTemp.y += sizeIncrement;
            lTemp.z += sizeIncrement;
            transform.localScale = lTemp;
        }
        if (Input.GetKeyDown("e"))
        {
            if (currentSize - 0.2f <= 0.4f)
            {
                print("Minimum size reached");
            }
            else
            {
                currentSize = currentSize - sizeIncrement;
                pivotY = currentSize * 1.7f;
                camOffsetZ = currentSize * -3f;
                pivotOffset = new Vector3(0f, pivotY, 0f);
                camOffset = new Vector3(0f, 0f, camOffsetZ);
                refScript.SetTargetOffsets(pivotOffset, camOffset);
                lTemp = transform.localScale;
                lTemp.x -= sizeIncrement;
                lTemp.y -= sizeIncrement;
                lTemp.z -= sizeIncrement;
                transform.localScale = lTemp;
            }
        }
    }
}
