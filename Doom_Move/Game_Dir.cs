using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Dir : MonoBehaviour
{
    GameObject Player;//�÷��̾� ������Ʈ�� ������ ���� �������� Gameobject
    GameObject Wm;//��ǥ�� ������Ʈ�� ������ ���� �������� Gameobject
    GameObject distance;//�÷��̾� ������Ʈ�� ��ǥ�� ������Ʈ ������ �Ÿ��� ǥ���� UI������Ʈ�� ����

    // Start is called before the first frame update
    void Start()
    {
        this.Player = GameObject.Find("Doom");
        this.Wm = GameObject.Find("Wm");
        this.distance = GameObject.Find("distance");
    }

    // Update is called once per frame
    void Update()
    {
        float lengthDis = this.Wm.transform.position.x - this.Player.transform.position.x;
        if (lengthDis >= 0)
        {
            this.distance.GetComponent<Text>().text = "distance" + ":" + lengthDis.ToString("F2") + "m";
            //Tostring("D")������ ���ڴ� �ڸ���D4 õ�ڸ� ���� Tostring("F����")�Ҽ��������ڸ���
        }
        else
        {
            this.distance.GetComponent<Text>().text = "Gameover!!!";
        }




    }
}
