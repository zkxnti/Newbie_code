using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Underon : MonoBehaviour
{
    
    public float maxCount = 50.0f;//초기 빈도값
    int count = 0;//카운터용
    bool flipFlag = false;//참,거짓을 판단하기 위해서 bool 데이터형을 사용
    // Start is called before the first frame update
    void Start()
    {
        count = 0;//
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count >= maxCount)
        {
            this.transform.Rotate(0, 0, 90);
            count = 0;
            flipFlag =! flipFlag;
            this.GetComponent<SpriteRenderer>().flipX = flipFlag;//스프라이터랜더러 라는 컴퍼넌트에 있는 
        }
    }
}
