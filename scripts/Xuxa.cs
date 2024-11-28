using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Xuxa : MonoBehaviour
{
    Vector3 xuxa;
    int cipo = 3;
    // Start is called before the first frame update
    void Start()
    {
        xuxa = new Vector3(-0.4f, 4, -61);
        transform.position = xuxa;
        xuxa.Set(-0.4f, 4f, -59f);
    }

    // Update is called once per frame
    void Update()
    {
        xuxa.y += 0.1f;
        transform.transform.position = xuxa;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        { 
            if (cipo == 1) //if de cipo
            {
                xuxa.x = -20.5f;
                transform.position = xuxa;
                cipo = 2;
            }

            else if (cipo == 2)
            {
                xuxa.x = -0.14f;
                transform.position = xuxa;
                cipo = 3;
            }

            else if (cipo == 3)
            {
                xuxa.x = 19.5f;
                transform.position = xuxa;
                cipo = 4;
            }

            else if (cipo == 4)
            {
                xuxa.x = 37.5f;
                transform.position = xuxa;
                cipo = 5;
            }
        }


        else if (Input.GetKeyDown(KeyCode.LeftArrow)) //if de tecla
        {
            if (cipo == 2)
            {
                xuxa.x = -41.5f;
                transform.position = xuxa;
                cipo = 1;
            }

            else if (cipo == 3)
            {
                xuxa.x = -20.5f;
                transform.position = xuxa;
                cipo = 2;
            }

            else if (cipo == 4)
            {
                xuxa.x = -0.14f;
                transform.position = xuxa;
                cipo = 3;
            }

           else if (cipo == 5)
            {
                xuxa.x = 19.5f;
                transform.position = xuxa;
                cipo = 4;
            }
        }
    }
}
