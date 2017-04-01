using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraScrollView : MonoBehaviour
{
    void Update()
    {
        if(!EventSystem.current.IsPointerOverGameObject() && Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x < 100 && Camera.main.transform.position.x > -30)
                Camera.main.transform.position += new Vector3(-20 * Time.deltaTime, 0, 0);
            if (Input.mousePosition.y < 100 && Camera.main.transform.position.y > -20)
                Camera.main.transform.position += new Vector3(0, -20 * Time.deltaTime, 0);
            if (Input.mousePosition.x > 1180 && Camera.main.transform.position.x < 30)
                Camera.main.transform.position += new Vector3(20 * Time.deltaTime, 0, 0);
            if (Input.mousePosition.y > 520 && Camera.main.transform.position.y < 10)
                Camera.main.transform.position += new Vector3(0, 20 * Time.deltaTime, 0);
        }
    }
}
