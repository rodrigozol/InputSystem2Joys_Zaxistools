using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOldInput : MonoBehaviour
{

    [SerializeField] GameObject[] balls;
    [SerializeField] int id;   
   
    // Update is called once per frame
    void Update()
    {
        if (id == 1)
        {
            ControlsPlayer1();
        }
        else {
          ControlsPlayer2();
        }
    }

    void ControlsPlayer1() {

        if (Input.GetButtonDown("B1_P1_Button")) {
            balls[0].transform.localScale = new Vector3(3, 3, 3);
        }

        if (Input.GetButtonUp("B1_P1_Button"))
        {
            balls[0].transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetButtonDown("B2_P1_Button"))
        {
            balls[1].transform.localScale = new Vector3(3, 3, 3);
        }

        if (Input.GetButtonUp("B2_P1_Button"))
        {
            balls[1].transform.localScale = new Vector3(1, 1, 1);
        }

    }

    void ControlsPlayer2()
    {       
        if (Input.GetButtonDown("B1_P2_Button"))
        {     
            balls[0].transform.localScale = new Vector3(3, 3, 3);
        }

        if (Input.GetButtonUp("B1_P2_Button"))
        {
     
            balls[0].transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetButtonDown("B2_P2_Button"))
        {
            
            balls[1].transform.localScale = new Vector3(3, 3, 3);
        }

        if (Input.GetButtonUp("B2_P2_Button"))
        {
            
            balls[1].transform.localScale = new Vector3(1, 1, 1);
        }


    }
}
