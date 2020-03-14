using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public void SetGazedAt(bool gazedAt) => GetComponent<Renderer>().material.color = gazedAt ? Color.blue : Color.black;
}





