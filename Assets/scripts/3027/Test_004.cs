using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_004 : MonoBehaviour
{
    public int hp = 180;                      //���� hp ���� 180 �� �Է� (public�� �ν����� â���� ���̰� �ϱ� ���Ͽ� ���
    public Text hpText;
    public Text hpStatus;                     //Hp ���� ǥ�� UI

    void Update()
    {
        hpStatus.text = hp.ToString();          //hp ���� ǥ�� toString �� ������ ���ڿ��� ��ȯ

        if (Input.GetMouseButtonDown(0))       // 0�� ���� Ŭ��
        {
            hp += 10;
        }
        if (Input.GetMouseButtonDown(1))      // 1�� ������ Ŭ��
        {
            hp -= 10;
        }

            if (hp <= 50)                       //���� hp�� 50 �����϶�
        {
            //Debug.Log("����!!");                //consle.log â�� �����̶�� ������ �Ѵ�.
            hpText.text = "���� !!";
        }
        else if(hp >= 200)                      //���� hp�� 200 �̻��� ��
        {
            //Debug.Log("����!!");                //consle.log â�� �����̶�� ������ �Ѵ�.
            hpText.text = "���� !!";
        }
        else                                    // ���� �� ������ �ƴҶ�
        {
            //Debug.Log("���!!");                //consle.log â�� ����� ������ �Ѵ�.
            hpText.text = "��� !!";
        }
    }

    void Start()
    {
        
    }
}
