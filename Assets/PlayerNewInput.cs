using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerNewInput : MonoBehaviour
{


    [SerializeField] private PlayerInput playerInput = null;
    [SerializeField] GameObject[] balls;
    [SerializeField] int id;
    public PlayerInput PlayerInput => playerInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnButton1() {
        //if (id == 1){
            balls[0].transform.localScale = new Vector3(3, 3, 3);
            StartCoroutine(VoltaSizeBotao(balls[0]));
        //}
        
    }

    void OnButton2()
    {
       // if (id == 1) {
            balls[1].transform.localScale = new Vector3(3, 3, 3);
            StartCoroutine(VoltaSizeBotao(balls[1]));
       // }
      
    }

    void OnButton3()
    {
     //   if (id == 2) {
            balls[0].transform.localScale = new Vector3(3, 3, 3);
            StartCoroutine(VoltaSizeBotao(balls[0]));
     //   }
        
    }

    void OnButton4()
    {
      //  if (id == 2) {
            balls[1].transform.localScale = new Vector3(3, 3, 3);
            StartCoroutine(VoltaSizeBotao(balls[1]));
      //  }

      
    }

    IEnumerator VoltaSizeBotao(GameObject ball)
    {
        yield return new WaitForSeconds(1);
        ball.transform.localScale = new Vector3(1, 1, 1);
    }


}
