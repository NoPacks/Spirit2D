using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private KeyCode kCode;
    private Rigidbody2D rb2d;

    [Header("PlayerStats")]
    public float p_Speed;
    public float p_JumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector3(1 * x*p_Speed, rb2d.velocity.y);

        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Mouse1) || Input.GetKeyDown(KeyCode.Space)) {
            DetectInput();
            ICommand command = new KeyCodeCommand(kCode, this.gameObject);
            CommandInvoker.AddCommand(command);
        }
    }

    public void DetectInput() {
        foreach (KeyCode vkey in System.Enum.GetValues(typeof(KeyCode))) {
            if (Input.GetKey(vkey)) {
                if (vkey != KeyCode.Return) {
                    kCode = vkey; //this saves the key being pressed               
                }
            }
        }
    }
}
