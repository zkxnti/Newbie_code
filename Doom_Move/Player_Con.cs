using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Con : MonoBehaviour
{
    public float speed = 0;//변수선언 초기값
    public float 분모값 = 1000.0f;
    Vector2 startPos;//2차원좌표의 백터(x,y) 3차원좌표의 백터값(x,y,z)
    Vector2 endPos;
    //vector2는 2차원좌표값을 갖습니다.(x,y) vector3(x,y,z)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//마우스 왼클릭시 작동
        {
            this.startPos = Input.mousePosition;//마우스버튼으로 눌렀을떄의 위치값(x,y)
            //this.speed = 0.1f;//속도를 대입해놓음
            
        }
        else if (Input.GetMouseButtonUp(0))//마우스 우클릭시 작동
        {
            this.endPos = Input.mousePosition;//마우스버튼으로 눌렀다가 때었을떄의 위치값(x,y)
            float lengthSwipe = (this.endPos.x - this.startPos.x);//마지막 좌표값-처음 좌표값을 빼준다.
            this.speed = lengthSwipe / 분모값;
            GetComponent<AudioSource>().Play();
        }
        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
        
    }
}
