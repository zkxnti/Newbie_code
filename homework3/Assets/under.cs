using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class under : MonoBehaviour
{
    GameObject player;//player �������� Gameobject�� ������ ���̴�.

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");//�̸��� player�� Gameobject�� ���� player�� ����  
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-0.05f, 0);//-y������ �̵�
        if(transform.position.y < -4.5f)
        {
            Destroy(gameObject);
        }
        Vector2 p1 = transform.position;
        //�ڽ��� x,y,��ǥ���� ���� p1�� ����
        Vector2 p2 = this.player.transform.position;
        //player�� x,y��ǥ�� ���� p2�� ����
        Vector2 dir = p1 - p2;//���� dir�� p1-p2 ���� ����
        float d = dir.magnitude;//���� dir�� ���̸� �Ǽ��� ��ȯ
        float r1 = 0.8f;//r1�� ������Ʈ�� ������
        float r2 = 1.0f;//r2 ������Ʈ�� ������
        float r3 = r1 + r2;

        if(d <r3)
        {
            SceneManager.LoadScene("EndScene");
            //Destroy(gameObject);
        }
    }
    
}
