using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;            //Tween�� ���� ���� ����

public class TweenTest : MonoBehaviour
{
    public bool isPunch = false;

    Sequence sequence;
    // Start is called before the first frame update
    void Start()
    {
        //transform.DOMoveX(5, 2);                            //��ü�� X�������� 5��ŭ 2�� ���� ���ڴ�.
        //transform.DORotate(new Vector3(0, 0, 180), 2);      //180�� 2�� ȸ��
        //transform.DOScale(new Vector3(3, 3, 3), 2);         //2�� ���� 3�� ũ��

        //sequence = DOTween.Sequence();
        //sequence.Append(transform.DOMoveX(5, 2).SetEase(Ease.OutBounce));           //sSetEase �߰� �ɼ�                       
        //sequence.Append(transform.DORotate(new Vector3(0, 0, 180), 2));
        //sequence.Append(transform.DORotate(new Vector3(3, 3, 3), 2));
        //sequence.SetLoops(-1, LoopType.Yoyo);            //������ ������.
                                                         

    }

    void SequnceEnd()
    {
        Debug.Log("ȸ�� �Ϸ�");
    }

    void EndPunch()
    {
        isPunch = false;                    //��Ī�� ������ �� ���°��� �ٽ� False�� ����
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(isPunch == false)                 //��Ī ���� �ƴҶ�
            {
                isPunch = true;                 //��Ī ���̴ٶ�� ���°� ����
                transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1).OnComplete(EndPunch);

                Color color = new Color(Random.value, Random.value, Random.value);            //�������� ���ؼ�
                Renderer renderer = GetComponent<Renderer>();                                 //Renderer ������Ʈ���� ��ü ����
                renderer.material.DOColor(color, 0.1f);                                       //Renderer�� Tween���� ����
            }
        }
    }
}
