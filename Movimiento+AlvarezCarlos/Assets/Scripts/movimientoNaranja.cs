using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoNaranja : MonoBehaviour
{
    public float speed = 0.005f;
    public Transform usteEscalemelo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0.5f, 0, 0) * speed * Time.deltaTime;

        usteEscalemelo.localScale += usteEscalemelo.localScale * 0.0003f;

        Debug.Log("Estoy creciendo en " + usteEscalemelo.localScale.x + " por frame");
    }
}
