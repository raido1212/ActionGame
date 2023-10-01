using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.InputSystem;

public class PlayerInputEvent : MonoBehaviour
{
    private PlayerInput playerInput;

    private InputAction fireAction, moveAction;

    // 基本情報
    float speedBase = 0.1f;

    private void Awake()
    {
//        TryGetComponent(out playerInput);
        playerInput = GetComponent<PlayerInput>();
        fireAction = playerInput.actions.FindAction("Fire");
        moveAction = playerInput.actions.FindAction("Move");
    }

    private void OnEnable()
    {
        fireAction.started += Fire;
        moveAction.started += Move;
    }

    private void OnDisable()
    {
        fireAction.started -= Fire;
        moveAction.started -= Move;
    }

    private void Fire(InputAction.CallbackContext context)
    {
        if (context.ReadValueAsButton())
        {
            Debug.Log("ファイヤー");
        }
    }

    private void Move(InputAction.CallbackContext context)
    {
        //this.transform.position += new Vector3(moveAction.ReadValue<Vector2>().x, 0, moveAction.ReadValue<Vector2>().y);
    }

    private void Update()
    {
        this.transform.position += new Vector3(moveAction.ReadValue<Vector2>().x * speedBase, 0, moveAction.ReadValue<Vector2>().y * speedBase);
    }


}
