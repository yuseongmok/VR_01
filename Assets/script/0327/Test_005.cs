using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_005 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++)                        // i�� 0���� 5�̸� ���� 1������
        {
            Debug.Log(i);
        }

        for (int i= 0; i < 10; i +=2)                     // i �� 0���� 10 �̸� ���� +2�� ����
        {
            Debug.Log(i);
        }

        for(int i = 3; i > 0; i--)                        //i�� 3���� 0�ʰ����� 1�� ����
        {
            Debug.Log(i);
        }

        int sum = 0;                    

        for(int i = 1; i < 10; i ++)                      //i�� 1���� 10�̸����� 1�� ���� 
        {
            sum += i;                                     //(ó��) �� i�� ���� ���Ѵ�.
        }
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
