using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    Vector3 cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = new Vector3(-0.69f, 6.9f, -106);
        transform.position = cam;
        cam.Set(-0.69f, 6.9f, -106);
    }

    // Update is called once per frame
    void Update()
    {
        cam.y += 0.1f;
        transform.transform.position = cam;
    }
}
