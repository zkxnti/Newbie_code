using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_turn : MonoBehaviour
{
    public float angle = 90.0f;//�ʱ� ������
    public float maxCount = 50.0f;//�ʱ� �󵵰�
    int count = 0;//ī���Ϳ�

    // Start is called before the first frame update
    void Start()
    {
        count = 0;//ī���͸� ����
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        Debug.Log(count);//count ���� �����ϴ°��� Ȯ���ϱ� ���� �ڵ�
        if (count>=maxCount)
        {
            this.transform.Rotate(0, 0, angle);
            count = 0;
        }
    }
}
