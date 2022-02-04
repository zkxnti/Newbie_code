using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class under : MonoBehaviour
{
    GameObject player;//player 변수에는 Gameobject를 대입할 것이다.

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");//이름이 player인 Gameobject를 변수 player에 대입  
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-0.05f, 0);//-y축으로 이동
        if(transform.position.y < -4.5f)
        {
            Destroy(gameObject);
        }
        Vector2 p1 = transform.position;
        //자신의 x,y,좌표값을 변수 p1에 대입
        Vector2 p2 = this.player.transform.position;
        //player의 x,y좌표를 변수 p2에 대입
        Vector2 dir = p1 - p2;//변수 dir는 p1-p2 값을 대입
        float d = dir.magnitude;//벡터 dir의 길이를 실수로 변환
        float r1 = 0.8f;//r1의 오브젝트의 반지름
        float r2 = 1.0f;//r2 오브젝트의 반지름
        float r3 = r1 + r2;

        if(d <r3)
        {
            SceneManager.LoadScene("EndScene");
            //Destroy(gameObject);
        }
    }
    
}
