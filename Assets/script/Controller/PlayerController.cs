using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 6;
    public GameObject PlayerPivot;
    Camera viewCamera;
    Vector3 velocity;
    public ProjectileController projectileController;

    public int Player_HP = 50;                         //플레이어 HP선언

    public void Damanged(int Damage)                  //데미지 받는 함수 생성
    {
        Player_HP -= Damage;                         //받은 데미지 HP에 반영

        if(Player_HP < 0)
        {
            Destroy(this.gameObject);
        }
    }


    void Start()
    {
        viewCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))                  //마우스 누르면
        {
            projectileController.FireProjectile();       // 발사체 발사
        }

        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));

        Vector3 targetPosition = new Vector3(mousePos.x, transform.position.y, mousePos.z);

        PlayerPivot.transform.LookAt(targetPosition, Vector3.up);

        velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * moveSpeed;
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + velocity * Time.fixedDeltaTime);
    }
}
