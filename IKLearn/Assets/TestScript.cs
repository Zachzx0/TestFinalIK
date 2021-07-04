using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject basic;
    public GameObject go2;


    public Vector3 mulVector = Vector3.zero;

    public Vector3 RotateEuler = Vector3.zero;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotateQuaternion = Quaternion.Euler(RotateEuler) * basic.transform.rotation;

        go2.transform.rotation = rotateQuaternion;

        Vector3 axisInWorldSpace = rotateQuaternion * mulVector;

        Debug.Log($"axisInWorldSPace:{axisInWorldSpace},lenth:{axisInWorldSpace.magnitude}");
        go2.transform.position = basic.transform.position + axisInWorldSpace;
    }
}
