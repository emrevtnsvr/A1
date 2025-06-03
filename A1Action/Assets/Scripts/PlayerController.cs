using UnityEngine;
using UnityEngine.InputSystem.XR;

public class PlayerController : MonoBehaviour
{
   
    
   public float _speed = 5f; // speed value

   private CharacterController _playerController; //  Built In CharacterController 

   private Vector3 _playerVelocity;

   private bool onGround; // if character on ground

   private float inputX;
   private float inputY;

       

   void Start()
   {
        _playerController = GetComponent<CharacterController>();
            
   }

        // Update is called once per frame
   void Update()
   {
      // Making sure that player stays on the ground
     onGround = _playerController.isGrounded;
     if (onGround && _playerVelocity.y < 0)
     {
       _playerVelocity.y = 0f;
     }


      // Getting the input from the player
      inputX = Input.GetAxis("Horizontal");
      inputY = Input.GetAxis("Vertical");


      Vector3 move = transform.right * inputX + transform.forward * inputY;

     _playerController.Move(move * _speed * Time.deltaTime);


        }
    }
