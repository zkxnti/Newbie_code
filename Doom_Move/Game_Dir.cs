using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Dir : MonoBehaviour
{
    GameObject Player;//플레이어 오브젝트를 대입할 변수 데이터형 Gameobject
    GameObject Wm;//목표물 오브젝트를 대입할 변수 데이터형 Gameobject
    GameObject distance;//플레이어 오브젝트와 목표물 오브젝트 사이의 거리를 표시할 UI오브젝트를 대입

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
            //Tostring("D")정수형 숫자는 자리수D4 천자리 숫자 Tostring("F숫자")소수점이하자리수
        }
        else
        {
            this.distance.GetComponent<Text>().text = "Gameover!!!";
        }




    }
}
