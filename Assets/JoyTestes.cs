using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JoyTestes : MonoBehaviour
{
    public TMP_Text textoJoy;
    public bool mostraJoyTextBool;
    public bool joy1Pressed;
    public bool joy2Pressed;

    private void Start()
    {
        mostraJoyTextBool = false;
    }

    // Update is called once per frame
    void Update()
    {

        /*
        if (Input.GetKeyDown(KeyCode.O)) {
            mostraJoyTextBool = !mostraJoyTextBool;

            if (mostraJoyTextBool) {
                textoJoy.enabled = true;
            }
            else
            {
                textoJoy.enabled = false;
            }

        }
        */

        textoJoy.text = "";

        for (var i = 0; i < 20; i++)
        {
            if (Input.GetKey("joystick button " + i))         
            {
                textoJoy.text += "JoyButton_Geral: " + i + "\n";
                Debug.Log("JoyGeral " + i);              
            }
            
        }


        for (var i = 0; i < 20; i++)
        {
            if (Input.GetKey("joystick 1 button " + i))          
            {
                textoJoy.text += "joystick 1 button " + i + "\n";
                Debug.Log("JoyButton1: " + i);
                joy1Pressed = true;
            }

            if (Input.GetKeyUp ("joystick 1 button " + i))           
            {               
                joy1Pressed = false;
            }

        }

        for (var i = 0; i < 20; i++)
        {
            if (Input.GetKey("joystick 2 button " + i))           
            {
                textoJoy.text += "joystick 2 button " + i + "\n";
                Debug.Log("JoyButton2: " + i);
                joy2Pressed = true;
            }

            if (Input.GetKeyUp("joystick 2 button " + i))            
            {                
                joy2Pressed = false;
            }


        }

        for (var i = 0; i < 20; i++)
        {
            if (Input.GetKey("joystick 3 button " + i))           
            {
                textoJoy.text += "joystick 3 button " + i + "\n";
                Debug.Log("JoyButton3: " + i);
            }

        }
       

    }
}
