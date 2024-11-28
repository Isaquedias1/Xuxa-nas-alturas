using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class colisao : MonoBehaviour
{
    private void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.CompareTag("livro")) {
            SceneManager.LoadScene("Gameover1");
        }

        if (colision.gameObject.CompareTag("colisao"))
        {
            SceneManager.LoadScene("Borboleta");
        }

        if (colision.gameObject.CompareTag("final"))
        {
            SceneManager.LoadScene("Vitoria");
        }

        if (colision.gameObject.CompareTag("nuvem"))
        {
            SceneManager.LoadScene("Gameover2");
        }
    }
}
