using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovment : MonoBehaviour
{
    private float targetSize = 11f;
    private float ActualltargetSize = 8;
    public float zoomSpeed;
    private bool isZoomingOut = false;
    private float zoomVelocity = 0f;

    [SerializeField] private Camera cam;

    private void Update()
    {
        ZoomOut();
    }

    private void ZoomOut()
    {
        if (Input.anyKeyDown && !isZoomingOut)
        {
            isZoomingOut = true;
        }

        if (isZoomingOut)
        {

            cam.orthographicSize = Mathf.SmoothDamp(cam.orthographicSize, targetSize, ref zoomVelocity, zoomSpeed);

            if (Mathf.Abs(cam.orthographicSize - ActualltargetSize) < 0.1f)
            {
                cam.orthographicSize = ActualltargetSize;
                isZoomingOut = false;
            }

        }
    }
}
