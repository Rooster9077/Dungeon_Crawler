using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
   private Vector2 movement;

   private void Onmovement(InputValue value)
   {
      movement = value.Get<Vector2>();
   }
}
