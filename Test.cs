using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour //파일명;클래스 이름은 스크립트 이름과 같아야함
{
    // Start is called before the first frame update
    void Start()//매번 프레임이 갱신되어도 스타트 메소드 안에 있는 내용은 한번만 실행된다.
    {
        this.transform.Translate(1.0f, 0, 0);
    }//이 스크립트가 속해있는 게임오브젝트가 트랜스폼컨포넌트를 이동시킨다.Translate(x,y,z)

// Update is called once per frame
void Update()//매 프레임마다 계속적으로 갱신(추가) 되는 메소드로 계속적으로 실행된다.
    {
        
    }
}
