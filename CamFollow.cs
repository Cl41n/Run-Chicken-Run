using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform player;

    public float offsetX, offsetY, offsetZ;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x + offsetX, player.position.y + offsetY, player.position.z + offsetZ);
    }
}