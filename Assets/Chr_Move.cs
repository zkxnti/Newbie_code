using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Chr_Move : MonoBehaviour
{
    public float speed = 1.0f;






    bool leftFlag = false;//������ȯ�� ���� ����(��,����)
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("right"))//GetmouseButton 0=����,1=������,2�� ��
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
        float hor = Input.GetAxis("Horizontal");        //����, ������ Ű 
        float ver = Input.GetAxis("Vertical");          //��, �� Ű
        transform.Translate(Vector3.forward * speed * ver * Time.deltaTime);      //�̵�
        transform.Rotate(Vector3.up * speed * hor);    // ȸ��
        */
    }
    private void FixedUpdate()
    {
        



        //this.transform.Translate(Vector3.forward * speed, 0);
        //this.GetComponent<SpriteRendere>().flipX=leftFlag;//������,���� �������� �̵��� ��������Ʈ ���� �̵�
    }
    
}
