using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowForward : MonoBehaviour
{
    // Start is called before the first frame update

    public LineRenderer renderer;
    void Start()
    {
        if (renderer)
        {
            renderer.SetPosition(0, this.transform.position);
            renderer.SetPosition(0, this.transform.position + transform.forward * 10);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
