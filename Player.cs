using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }

    //플레이어가 해당 좌표만큼 이동하기 때문에 게임내에서 굉장히 부자연스럽게 움직임
  //  void Update() 
  //  {
  //     if(Input.GetKeyDown(KeyCode.LeftArrow)){ //플레이어가 해당 좌표만큼 이동하기 때문에 게임내에서 굉장히 부자연스럽게 움직임
  //      transform.Translate (-1,0,0);
  //     } 
  //     if(Input.GetKeyDown(KeyCode.RightArrow)){
  //      transform.Translate (1,0,0);
  //     }


  // 플레이어가 Axis함수( 축을 기준으로한)를 호출받아 위치값이 서서히 증가한다.
    void Update()
    {
         
      float playerMove = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
      if(Input.GetKey(KeyCode.LeftArrow)){
        playerMove = -Speed * Time.deltaTime;
      }
      if(Input.GetKeyDown(KeyCode.RightArrow)){
        playerMove = Speed * Time.deltaTime;
      }
      this.transform.Translate(new Vector3(playerMove,0,0));
    }

     
}
