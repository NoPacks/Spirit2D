using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class SpiritController : MonoBehaviour
{
    private AIPath aiPath;
    private SpriteRenderer sRenderer;

    private void Start() {
        sRenderer = GetComponent<SpriteRenderer>();
        aiPath = GetComponent<AIPath>();
    }

    void Update()
    {
        if (aiPath.desiredVelocity.x >= 0.01f) {
            sRenderer.flipX = false;
        }else if (aiPath.desiredVelocity.x <= 0.01f) {
            sRenderer.flipX = true;
        }
    }
}
