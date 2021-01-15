using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        animator.SetFloat("Vertical", Input.GetAxis("Vertical"));

        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0.0f);

        transform.position = transform.position + horizontal * Time.deltaTime * 2;
    }
}
