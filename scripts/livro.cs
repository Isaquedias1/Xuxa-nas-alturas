using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class livro : MonoBehaviour
{
    Vector3 book;
    // Start is called before the first frame update
    void Start()
    {
        book = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        book.y += -0.01f;
        transform.transform.position = book;
    }
}
