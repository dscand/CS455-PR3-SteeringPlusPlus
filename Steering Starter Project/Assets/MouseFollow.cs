using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    public new Camera camera;

    void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit)) {
            transform.position = new Vector3(hit.point.x, 0, hit.point.z);
        }
        else {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
