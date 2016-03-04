using UnityEngine;
using System.Collections;

public class Cam : MonoBehaviour {
    public float Cam_speed;
    public GameObject _cam;
    void Update()
    {
        Cam_Move();
        xuanzhuanScene();
    }
    void xuanzhuanScene()
    {
        if (Input.GetMouseButton(1))
        {
            float mousX = Input.GetAxis("Mouse X");
            this.transform.transform.Rotate(0, mousX, 0);
            float mousY = Input.GetAxis("Mouse Y");
            _cam.transform.Rotate(-mousY*Time.timeScale, 0, 0);
            if (_cam.transform.eulerAngles.x > 30&&_cam.transform.eulerAngles.x<180)
            {
                _cam.transform.eulerAngles = new Vector3(30, _cam.transform.eulerAngles.y, _cam.transform.eulerAngles.z);
            }
            if (_cam.transform.eulerAngles.x<330&&_cam.transform.eulerAngles.x>180)
            {
                _cam.transform.eulerAngles = new Vector3(330, _cam.transform.eulerAngles.y, _cam.transform.eulerAngles.z);
            }
         
        }
    }
    void Cam_Move()
    {
        if (Input.GetKey("w"))
        {
            this.transform.Translate(Vector3.forward*Time.deltaTime*Cam_speed);
        }
        if (Input.GetKey("a"))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime * Cam_speed);
        }
        if (Input.GetKey("d"))
        {
            this.transform.Translate(Vector3.right * Time.deltaTime * Cam_speed);
        }
        if (Input.GetKey("s"))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime * Cam_speed);
        }
        

    }
}
