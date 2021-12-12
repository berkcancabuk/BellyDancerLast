using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    public float distanceZ = 0;
    public GameObject rig;
    private void OnMouseDrag()
    {

        Vector3 drag = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceZ);
        Vector3 mousepos = Camera.main.ScreenToWorldPoint(drag);
        this.transform.position = mousepos;
        rig.transform.position = this.transform.position;
    }
}
