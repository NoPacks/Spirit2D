using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class KeyCodeInput
{
    public static void ActionInput(KeyCode kCode, GameObject owner) {
        switch (kCode) {
            case KeyCode.Mouse0:
                Attack(owner);
                break;

            case KeyCode.Mouse1:
                GoToSpirit(owner);
                break;

            case KeyCode.Space:
                Jump(owner);
                break;

            case KeyCode.Pipe:
                Debug.Log("error, there is no action attached to that key");
                break;
        }
    }

    private static void Attack(GameObject owner) {
        Debug.Log("Attack");
    }

    private static void GoToSpirit(GameObject owner) {
        Debug.Log("go to spirit");
    }

    private static void Jump(GameObject owner) {
        Debug.Log("Jump");
        owner.GetComponent<Rigidbody2D>().velocity = new Vector3(owner.GetComponent<Rigidbody2D>().velocity.x, owner.GetComponent<PlayerController>().p_JumpForce);
    }
}
