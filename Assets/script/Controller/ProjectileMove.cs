using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 lanchDirection;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Wall") 
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.name == "Monster")
        {
            collision.gameObject.GetComponent<MonsterController>().Damanged(1);
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)               //Trigger 함수
    {     //벽에 충돌시 파괴
        if (other.gameObject.tag == "Wall")              //Name -> Tag 로 변환
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Monster")
        {
            other.gameObject.GetComponent<MonsterController>().Damanged(1);
            Destroy(this.gameObject);
        }
    }
    private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;

        transform.Translate(lanchDirection * moveAmount);
    }
}
