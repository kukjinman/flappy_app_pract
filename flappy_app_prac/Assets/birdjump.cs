using UnityEngine;
using UnityEngine.InputSystem;

public class birdjump : MonoBehaviour
{

    public float jumpForce = 5f;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public InputAction jumpAction;

    private void OnEnable()
    {
        jumpAction.Enable();
        jumpAction.performed += OnJump;  // 이벤트 구독 추가
    }

    private void OnDisable()
    {
        jumpAction.performed -= OnJump;  // 이벤트 구독 해제
        jumpAction.Disable();
    }

    // InputAction 이벤트용 메서드 (기존 코드)
    private void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }
    }

}
