using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test4 : MonoBehaviour
{
    public float speed = 5.0f; //public ����,�������� (int(����), float(�Ǽ�), �����̸�:speed,������:5.0f
    // Start is called before the first frame update
    void Start()
    {
        this.transform.Translate(1.0f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0.1f, 0, 0);
    }
}
