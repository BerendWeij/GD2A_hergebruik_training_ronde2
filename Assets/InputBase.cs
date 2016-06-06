using UnityEngine;
using System.Collections.Generic;

public class InputBase : MonoBehaviour
{
    //[SerializeField]
    //private List<KeyCode> inputButtons;

   // [SerializeField]
    //private List<>


    [SerializeField]
    private KeyCode jumpButton = KeyCode.W;

    [SerializeField]
    private KeyCode moveLeft = KeyCode.A;

    [SerializeField]
    private KeyCode moveRight = KeyCode.D;

    [SerializeField]
    private KeyCode shoot = KeyCode.Mouse0;

    void Update() {
        if (Input.GetKeyDown(jumpButton))
        {

        } else if (Input.GetKeyDown(moveLeft)) {

        } else if (Input.GetKeyDown(moveRight)) {

        } else if (Input.GetKeyDown(shoot)) {

        }
    }

    protected virtual void MoveLeft() {

    }
    protected virtual void MoveRight()
    {

    }
    protected virtual void Jump()
    {

    }
    protected virtual void Shoot()
    {

    }
}
