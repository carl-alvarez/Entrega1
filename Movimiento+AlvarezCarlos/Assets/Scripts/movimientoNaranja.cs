using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class movimientoNaranja : MonoBehaviour
{
    public float speed = 0.005f;
    public Transform usteEscalemelo;
    public Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += pos * speed * Time.deltaTime;

        usteEscalemelo.localScale += usteEscalemelo.localScale * 0.0003f;

        transform.Rotate(0, 0.5f, 0);

        Debug.Log("Estoy creciendo en " + usteEscalemelo.localScale.x + " por frame");
    }
}
