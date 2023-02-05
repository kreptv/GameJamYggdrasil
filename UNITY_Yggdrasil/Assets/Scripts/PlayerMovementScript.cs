using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
  public GameManager gm;

  public Animator animator;

  public float speed = 2f;
  public bool facingRight;
  public Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {

      animator = this.gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
      if (!gm.gameplayActive){return;}


      if (Input.GetAxis("Horizontal") > 0.1 ){
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0);
        gm.pms.animator.SetBool("Running", true);
        if (!facingRight){
          facingRight = true;
          transform.localScale = new Vector3(1,1,1);
        }
      } else if (Input.GetAxis("Horizontal") < -0.1){
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0);
        gm.pms.animator.SetBool("Running", true);
          if (facingRight){
            facingRight = false;
            transform.localScale = new Vector3(-1,1,1);
          }
      }
      else{
        gm.pms.animator.SetBool("Running", false);
      }

    }
}
