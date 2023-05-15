using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemmyController : MonoBehaviour
{
    public float speed = 5.0f;         //�� �ӵ�

    public float rotationSpeed = 1f;   //��ž ȸ�� �ӵ�
    public GameObject bulletPrefab;    //�Ѿ� ������
    public GameObject EnemyPivot;      //�� �Ǻ�
    public Transform firePoint;        //�߻� ��ġ
    public float fireRate = 1f;        //���� �ӵ�
    public float nextFireTime;         //����ӵ� �ð� ����

    private Rigidbody rb;              //������ �ٵ� ����
    private Transform player;          //�÷��̾� ��ġ ����

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  //�ڱ� �ڽ��� ������ �ٵ� �� �Է�

        GameObject Temp = GameObject.FindGameObjectWithTag("Player");     //�÷��̾��� ��ġ �� �Է�

        if(Temp != null)
        {
            player = Temp.transform;        //�÷��̾��� ��ġ �� �Է�
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            if (Vector3.Distance(player.position, transform.position) > 5.0f)      //Vector3.Distance �Ÿ� ���� �Լ�
            {
                Vector3 direction = (player.position - transform.position).normalized;
                rb.MovePosition(transform.position + direction * speed * Time.deltaTime);  //�� �̵�
            }

            //��ž ȸ��
            Vector3 targetDirection = (player.position - EnemyPivot.transform.position).normalized;  //�÷��̾�� �� �Ǻ� ���͸� �E���Ͽ� ���� ���͸� ����
            Quaternion targetRotate = Quaternion.LookRotation(targetDirection);                      //ȸ�� ���� ���ؼ�
            EnemyPivot.transform.rotation = Quaternion.Lerp(EnemyPivot.transform.rotation, targetRotate, rotationSpeed * Time.deltaTime); // ȸ�� �����ִ� �Լ�

            //�Ѿ� �߻�
            if (Time.time > nextFireTime)
            {
                nextFireTime = Time.time + 1f / fireRate;
                GameObject temp = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                temp.GetComponent<ProjectileMove>().lanchDirection = firePoint.localRotation * Vector3.forward;
                temp.GetComponent<ProjectileMove>().projectileType = ProjectileMove.PROJECTILETYPE.ENEMY; //�Ѿ� Ÿ�� ����
            }
        }
    }
}
