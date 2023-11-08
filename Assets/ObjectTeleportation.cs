using UnityEngine;

public class ObjectTeleportation : MonoBehaviour
{
    public Transform objectToTeleport; // assign the object to be teleported in the Inspector
    public Vector3 teleportPosition; // assign the teleport position in the Inspector
    public Vector3 teleportRotation; // assign the teleport rotation in the Inspector
    public Economy economy; // assign the Economy script object in the Inspector

    void Update()
    {
        // check if 'T' key is pressed
        if (Input.GetKeyDown(KeyCode.T))
        {
            // teleport the object to the stored position and rotation
            objectToTeleport.position = teleportPosition;
            objectToTeleport.rotation = Quaternion.Euler(teleportRotation);

            // deduct 35 units of currency from the player's balance
            economy.AddFunds(-35);
        }
    }
}
