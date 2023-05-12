using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class PlayerNewInput2 : MonoBehaviour
{


    [SerializeField] private PlayerInput playerInput = null;
    [SerializeField] GameObject[] balls;
    //[SerializeField] int id;
    public PlayerInput PlayerInput => playerInput;


    [Header("FazendoComArray")]
    [SerializeField] string[] actionsArrayName;
    public InputAction[] actionsArray; // analogo ao hold    
    public bool[] segurandoB2;
    private int quantBotoes = 2;
    [SerializeField] public InputActionAsset ActionMapAsset;

    
    
    void Awake()
    {
        actionsArrayName = new string[quantBotoes];      
        segurandoB2 = new bool[quantBotoes];
        for (var i = 0; i < quantBotoes; i++)
        {
            /*
            if (this.gameObject.name == "Player1")
            {
                actionsArrayName[i] = "Button" + i;
            }
            */

            
            if (this.gameObject.name == "Player2")
            {
                actionsArrayName[i] = "Button" + (i + 2);
            }
            

        }
        actionsArray = new InputAction[quantBotoes];

        for (var n = 0; n < quantBotoes; n++)
        {
            actionsArray[n] = ActionMapAsset.FindAction(actionsArrayName[n]);
            //Debug.Log("Achada!!!: " + actionsArray[n].name);
        }

    }

    private void Start()
    {
        if (gameObject.name == "Player2") {
           // StartCoroutine("DesligaLigaInput"); // Não Há necessida, não é isso que gera a confusão
        } 
    }

    IEnumerator DesligaLigaInput() {
        playerInput.enabled = false;
        yield return new WaitForSeconds(0.1f);
        playerInput.enabled = true;
    }


    void OnEnable()
    {
        /*
        if (this.gameObject.name == "Player1") {
            for (var i = 0; i < quantBotoes/2; i++)
            {
                actionsArray[i].Enable();
                actionsArray[i].performed += HoldButton;
                actionsArray[i].canceled += ReleaseButton;
            }

        }
        */

        
        if (this.gameObject.name == "Player2")
        {
            for (var i = 0; i < quantBotoes; i++)
            {
                actionsArray[i].Enable();
                actionsArray[i].performed += HoldButton2;
                actionsArray[i].canceled += ReleaseButton2;
            }

        }
        



    }

    void OnDisable()
    {
        /*
        if (this.gameObject.name == "Player1")
        {
            for (var i = 0; i < quantBotoes/2; i++)
            {
                actionsArray[i].Disable();
                actionsArray[i].performed -= HoldButton;
                actionsArray[i].canceled -= ReleaseButton;
            }

        }
        */

        
        if (this.gameObject.name == "Player2")
        {
            for (var i = 0; i < quantBotoes; i++)
            {
                actionsArray[i].Disable();
                actionsArray[i].performed -= HoldButton2;
                actionsArray[i].canceled -= ReleaseButton2;
            }
        }
        
    }

    /*
    void HoldButton(InputAction.CallbackContext context)
    {
        InputAction triggeredAction = context.action;

        if (this.gameObject.name == "Player1") {
            for (int i = 0; i < quantBotoes/2; i++)
            {
                if (triggeredAction == actionsArray[i])
                {
                    Debug.Log("HoldP1Button " + i + " was pressed!");
                    segurandoB[i] = true;
                    break;
                }
            }
        }
    }
    */

    
    void HoldButton2(InputAction.CallbackContext context) {
        InputAction triggeredAction = context.action;

        if (this.gameObject.name == "Player2")
        {
            for (int i = 0; i < quantBotoes; i++)
            {
                if (triggeredAction == actionsArray[i])
                {
                    Debug.Log("HoldP2Button " + i + " was pressed!");
                    segurandoB2[i] = true;
                    break;
                }
            }
        }
    }
   
    /*
    void ReleaseButton(InputAction.CallbackContext context)
    {
        InputAction triggeredAction = context.action;
        
        if (this.gameObject.name == "Player1") {
            for (int i = 0; i < quantBotoes/2; i++)
            {
                if (triggeredAction == actionsArray[i])
                {
                    Debug.Log("ReleaseP1Button " + i + " was soltou");
                    segurandoB[i] = false;
                    break;
                }
            }
        }
    }

    */
    void ReleaseButton2(InputAction.CallbackContext context) {
        InputAction triggeredAction = context.action;

        if (this.gameObject.name == "Player2")
        {
            for (int i = 0; i < quantBotoes; i++)
            {
                if (triggeredAction == actionsArray[i])
                {
                    Debug.Log("ReleaseButton " + i + " was soltou");
                    segurandoB2[i] = false;
                    break;
                }
            }

        }
    }
    
    
    /*
    void OnButton0() {
        //if (id == 1){
            balls[0].transform.localScale = new Vector3(3, 3, 3);
            StartCoroutine(VoltaSizeBotao(balls[0]));
        //}
        
    }

    void OnButton1()
    {
       // if (id == 1) {
            balls[1].transform.localScale = new Vector3(3, 3, 3);
            StartCoroutine(VoltaSizeBotao(balls[1]));
       // }
      
    }
    */

    
    void OnButton2()
    {
   
            balls[0].transform.localScale = new Vector3(3, 3, 3);
            StartCoroutine(VoltaSizeBotao(balls[0]));
   
        
    }

    void OnButton3()
    {
   
            balls[1].transform.localScale = new Vector3(3, 3, 3);
            StartCoroutine(VoltaSizeBotao(balls[1]));
   

      
    }
    

    IEnumerator VoltaSizeBotao(GameObject ball)
    {
        yield return new WaitForSeconds(1);
        ball.transform.localScale = new Vector3(1, 1, 1);
    }


}
