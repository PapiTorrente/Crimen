using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movDetective : MonoBehaviour
{

    private Vector2 dirMov;
    public float velMov;
    public Rigidbody2D rb;
    public Animator anim;

    void FixedUpdate() {
        Movimiento();
        AnimacionesPlayer();
    }

    private void Movimiento() {
        float movX = Input.GetAxisRaw("Horizontal");
        float movY = Input.GetAxisRaw("Vertical");
        dirMov = new Vector2(movX, movY).normalized;
        rb.linearVelocity = new Vector2(dirMov.x * velMov, dirMov.y * velMov); 
    }

    void AnimacionesPlayer() {
        anim.SetFloat("movX", dirMov.x);
        anim.SetFloat("movY", dirMov.y);
    }
}
