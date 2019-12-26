using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Start is called before the first frame update
    public void SetGazedAt(bool gazedAt) => GetComponent<Renderer>().material.color = gazedAt ? Color.blue : Color.black;
  }

    // Update is called once per frame


