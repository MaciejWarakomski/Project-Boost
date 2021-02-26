using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("This thing is friendly");
                break;
            case "Finish":
                Debug.Log("congtats finished");
                break;
            case "Fuel":
                Debug.Log("you picked fuel");
                break;
            default:
                Debug.Log("you destroyed rocket");
                break;
        }
    }
}
