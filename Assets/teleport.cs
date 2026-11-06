using UnityEngine;

public class teleport : MonoBehaviour
{





    public Transform teleportTarget;

    void OnTriggerEnter(Collider other)
    {
        CharacterController cc = other.GetComponent<CharacterController>();
        if (cc)
        {
            cc.enabled = false;
            other.transform.position = teleportTarget.position;     // teleport 
            cc.enabled = true;





        }

    }

}