using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test5 : MonoBehaviour
{
    public int rot_a=90;
    //Start is called before the first frame update
    void Start()
    {
        this.transform.Rotate(rot_a, 0, 0);
    }

     //Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 0, 45);
    }
}
