using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject camera0;
    public GameObject camera1;
    public GameObject camera2;
    //private GameObject camera_0;
    //private GameObject camera_1;
    void FindCamera()
    {
        camera0 = GameObject.Find("camera0");
        camera1 = GameObject.Find("camera1");
        camera2 = GameObject.Find("camera2");
        camera0.SetActive(true);
        camera1.SetActive(false);
        camera2.SetActive(false);
    }
    void Start()
    {
        // camera_0 = GameObject.Find("camera0");
        FindCamera();
    }

    public void model1() {
        camera0.SetActive(false);
        camera1.SetActive(true);
        camera2.SetActive(false);

    }
    public void model2() {
        camera0.SetActive(false);
        camera1.SetActive(false);
        camera2.SetActive(true);
    }
    public void menu() {
        camera0.SetActive(true);
        camera1.SetActive(false);
        camera2.SetActive(false);
    }

    void Update()
    {
    }
}
