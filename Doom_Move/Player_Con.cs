using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Con : MonoBehaviour
{
    public float speed = 0;//�������� �ʱⰪ
    public float �и� = 1000.0f;
    Vector2 startPos;//2������ǥ�� ����(x,y) 3������ǥ�� ���Ͱ�(x,y,z)
    Vector2 endPos;
    //vector2�� 2������ǥ���� �����ϴ�.(x,y) vector3(x,y,z)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//���콺 ��Ŭ���� �۵�
        {
            this.startPos = Input.mousePosition;//���콺��ư���� ���������� ��ġ��(x,y)
            //this.speed = 0.1f;//�ӵ��� �����س���
            
        }
        else if (Input.GetMouseButtonUp(0))//���콺 ��Ŭ���� �۵�
        {
            this.endPos = Input.mousePosition;//���콺��ư���� �����ٰ� ���������� ��ġ��(x,y)
            float lengthSwipe = (this.endPos.x - this.startPos.x);//������ ��ǥ��-ó�� ��ǥ���� ���ش�.
            this.speed = lengthSwipe / �и�;
            GetComponent<AudioSource>().Play();
        }
        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
        
    }
}
