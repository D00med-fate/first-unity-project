using UnityEngine;

public class Key : MonoBehaviour
{
    [Header("KeySettings")]
    [SerializeField] private bool DestroyOnPickUp = true;


    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement player = other.GetComponent<PlayerMovement>();

        if(player != null)
        {
            player.CollectedKey();
            Debug.Log("player has key");

            if (DestroyOnPickUp)
            {
                Destroy(gameObject);
            }
        }
    }
}
