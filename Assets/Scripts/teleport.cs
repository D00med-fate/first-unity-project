using UnityEngine;
using System;

public class teleport : MonoBehaviour
{
    

    public Transform teleportTargetMain = null;

    public Transform teleportTarget1 = null;
    public Transform teleportTarget2 = null;


    void OnTriggerEnter(Collider other)
    {
        TelaportChoice();
        CharacterController cc = other.GetComponent<CharacterController>();
        if (cc)
        {
            cc.enabled = false;
            other.transform.position = teleportTargetMain.position;     // teleport 
            cc.enabled = true;
        }

    }

    Transform TelaportChoice()
    {
        System.Random rnd = new System.Random();

        int choices = rnd.Next(1, 3);

        switch (choices) 
        { 
            case 1:
                teleportTargetMain = teleportTarget1;
                break;
            case 2:
                teleportTargetMain = teleportTarget2;
                break;
        }
        return teleportTargetMain;
    }

}