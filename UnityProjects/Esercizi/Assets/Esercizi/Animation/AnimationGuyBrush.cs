using UnityEngine;
using System.Collections;

public class AnimationGuyBrush : MonoBehaviour
{
    public Animator moveGuy;

    void Update ()
    {
        if (Input.GetKey(KeyCode.D))
        {
            moveGuy.SetTrigger("isDPressed");
            moveGuy.Play("GuyBrushWalkRight");
            moveGuy.SetBool("isIdleRight", false);
            this.transform.position += transform.right * 3.5f * Time.deltaTime;
        }

        else
        {
            moveGuy.ResetTrigger("isDPressed");
            moveGuy.SetBool("isIdleRight", true);
        }
            

        if (Input.GetKey(KeyCode.A))
        {
            moveGuy.SetTrigger("isAPressed");
            moveGuy.Play("GuyBrushWalkLeft");
            moveGuy.SetBool("isIdleLeft", false);
            this.transform.position += transform.right * -3.5f * Time.deltaTime;
        }

        else
        {
            moveGuy.ResetTrigger("isAPressed");
            moveGuy.SetBool("isIdleLeft", true);
        }
    }
}
