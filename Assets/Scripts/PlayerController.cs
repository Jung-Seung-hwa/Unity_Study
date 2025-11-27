using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour{   
    public Rigidbody playerRigidbody; // 이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f; // 이동 속력
   void Start () {
        // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 playerRigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();
   }

   void Update() {

        // 수평축과 수직충의 입력값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");


        // 실제 이동 속도를 입력값과 이동 속력을 통해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 속도를 (xSpeed, 0, zSpeed)로 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        // 리지드바디의 속도에 newVelocity 할당
        playerRigidbody.linearVelocity = newVelocity;


        if (Input.GetKey(KeyCode.W) == true) {
            // 위쪽 방향키 입력이 감지된 경우 z 방향 힘주기
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        // → 특정 키를 지목하는 방식은 조작 키를 실시간으로 변경할 수 없는 단점이 있어서 아래방향으로
        // 사용한다
        // if (Input.GetKey(KeyCode.UpperArrow) == true) {
        //     // 위쪽 방향키 입력이 감지된 경우 z 방향 힘주기
        //     playerRigidbody.AddForce(0f, 0f, speed);
        // } 

        if (Input.GetKey(KeyCode.DownArrow) == true) {
            // 아래쪽 방향키 입력이 감지된 경우 z 방향 힘주기
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true) {
            // 오른쪽 방향키 입력이 감지된 경우 z 방향 힘주기
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true) {
            // 왼쪽 방향키 입력이 감지된 경우 z 방향 힘주기
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }

  
    }
        public void Die() {
        gameObject.SetActive(false);

        GameManager gameManager = FindFirstObjectByType<GameManager>();

        gameManager.EndGame();
    }  
}