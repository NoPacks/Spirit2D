using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCodeCommand : ICommand {

    KeyCode keyCode;
    GameObject owner;

    public KeyCodeCommand(KeyCode keyCode, GameObject owner) {
        this.keyCode = keyCode;
        this.owner = owner;
    }

    public void Execute() {
        KeyCodeInput.ActionInput(keyCode, owner);
    }
}
