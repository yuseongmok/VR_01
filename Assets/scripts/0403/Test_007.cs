using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
    void SayHello()                                        //SayHello �Լ��� ����
    {
        Debug.Log("Hello");                                //Hello ������ Console.log�� ���
    }
    void CallName(string name)                             //CallName �Լ� ���� (string ������ �μ�(��ame)�� ����)
    {
        Debug.Log("Hello" + name);
    }

    int Add(int a , int b)                                 //Add �Լ� ���� (�μ� , ��ȯ��) ��ȯ��, �����Ҷ� (int)
    {
        int c = a + b;                                     //c��� int ���� ���� a + b ���� �Է�
        return c;                                          //���� �Լ� ��ȯ ������ �ѱ� (return)
    }

    // Start is called before the first frame update
    void Start()
    {
        SayHello();                                        //�Լ��� ����
        SayHello();                                        //�Լ��� ����
        CallName("TOM");                                   //�Լ��� ���� string �Ķ���� Tom �� �Է�
        CallName("SAM");                                   //�Լ��� ���� string �Ķ���� SAM �� �Է�
        int answer = Add(2, 5);                            //���� int answer �����ϰ� �Լ� �� ��ȯ���� �Է�
        Debug.Log(answer);
    }
}
