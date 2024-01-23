using UnityEngine;
using UnityEngine.InputSystem;

public class TouchManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private PlayerMovement playerMovement;

    private PlayerInput playerInput;

    private InputAction touchPressAction;
    private InputAction touchPositionAction;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        playerMovement = player.GetComponent<PlayerMovement>();
        touchPressAction = playerInput.actions.FindAction("TouchPress");
        touchPositionAction = playerInput.actions.FindAction("TouchPosition");
    }

    private void OnEnable()
    {
        touchPressAction.performed += playerMovement.Jump;
    }

    //private void TouchPressed(InputAction.CallbackContext ctx)
    //{
    //    Vector3 position = Camera.main.ScreenToWorldPoint(touchPositionAction.ReadValue<Vector2>());

    //    position.z = player.transform.position.z;
    //    player.transform.position = position;
    //}
}
