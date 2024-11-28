using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botao : MonoBehaviour
{
    public void Transicao()
    {
        SceneManager.LoadScene("Floresta");
    }

    public void Saida() 
    {
        Application.Quit();
    }

    public void resetar()
    {
        SceneManager.LoadScene("Floresta");
    }

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
