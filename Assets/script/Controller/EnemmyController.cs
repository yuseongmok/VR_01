using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemmyController : MonoBehaviour
{
    public float speed = 5.0f;         //�� �ӵ�
    private Rigidbody rb;              //������ �ٵ� ����
    private Transform player;          //�÷��̾� ��ġ ����

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  //�ڱ� �ڽ��� ������ �ٵ� �� �Է�
        player = GameObject.FindGameObjectWithTag("Player").transform;     //�÷��̾��� ��ġ �� �Է�
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(player.position , transform.position) > 5.0f)      //Vector3.Distance �Ÿ� ���� �Լ�
        {
            Vector3 direction = (player.position - transform.position).normalized;
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);  //�� �̵�
        }
    }
}
