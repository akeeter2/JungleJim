using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerInput : MonoBehaviour
{
    private Player player;


    private void Start()
    {
        player = GetComponent<Player>();
    }

    private void Update()
    {
        Vector2 directionalInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        player.SetDirectionalInput(directionalInput);

        if (Input.GetKeyDown("space")) //On Space bar the Jim will jump
        {
            player.OnJumpInputDown();
        }

        if (Input.GetKeyDown("space")) //Calls double jump
        {
            player.OnJumpInputUp();
        }
    }
}
