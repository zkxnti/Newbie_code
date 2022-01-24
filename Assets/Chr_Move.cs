using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Chr_Move : MonoBehaviour
{
    public float speed = 1.0f;






    bool leftFlag = false;//방향전환을 위한 변수(참,거짓)
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("right"))//GetmouseButton 0=왼쪽,1=오른쪽,2는 휠
        {
            transform.Translate(speed, 0, 0);
            leftFlag = false;
        }
        else if (Input.GetKey("left"))
        {
            transform.Translate(-speed, 0, 0);
            

        }
        else if (Input.GetKey("up"))
        {
            transform.Translate(0, speed, 0);
        }
        else if (Input.GetKey("down"))
        {
            transform.Translate(0, -speed, 0);
        }
       
        
        /*
        float hor = Input.GetAxis("Horizontal");        //왼쪽, 오른쪽 키 
        float ver = Input.GetAxis("Vertical");          //앞, 뒤 키
        transform.Translate(Vector3.forward * speed * ver * Time.deltaTime);      //이동
        transform.Rotate(Vector3.up * speed * hor);    // 회전
        */
    }
    private void FixedUpdate()
    {
        



        //this.transform.Translate(Vector3.forward * speed, 0);
        //this.GetComponent<SpriteRendere>().flipX=leftFlag;//오른쪽,왼쪽 방향으로 이동시 스프라이트 방향 이동
    }
    
}
