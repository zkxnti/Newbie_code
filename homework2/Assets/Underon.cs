using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Underon : MonoBehaviour
{
    
    public float maxCount = 50.0f;//�ʱ� �󵵰�
    int count = 0;//ī���Ϳ�
    bool flipFlag = false;//��,������ �Ǵ��ϱ� ���ؼ� bool ���������� ���
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
            this.GetComponent<SpriteRenderer>().flipX = flipFlag;//���������ͷ����� ��� ���۳�Ʈ�� �ִ� 
        }
    }
}
