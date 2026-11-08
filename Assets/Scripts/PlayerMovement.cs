using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   



    [SerializeField] private CharacterController controller;
    [SerializeField] private InputActionReference moveAction;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] public bool HasKey = false;

    void Update()
    {
        Vector2 input = moveAction.action.ReadValue<Vector2>();

        Vector3 movement =
            transform.right * input.x +
            transform.forward * input.y;

        controller.Move(movement * moveSpeed * Time.deltaTime);
    }

    public void CollectedKey()
    {
        HasKey = true;
    }









}
