using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveh : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(speed/50,0,0);
    }
}
