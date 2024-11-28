using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mandala : MonoBehaviour
{
    public float tempo = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime % 60;
        if (tempo >= 10) {
            SceneManager.LoadScene("Céu");
        }
    }
}
