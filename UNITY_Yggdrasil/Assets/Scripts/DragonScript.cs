using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonScript : MonoBehaviour
{

    public GameManager gm;
    public float speed = 1f;
    public GameObject dragonPrefab;
    public Vector3 bottomPosition;


    void Start(){
        bottomPosition = new Vector3(transform.position.x, 0, transform.position.z);
    }

    void Update()
    {
        if (!gm.gameplayActive){return;}
        // Move the dragon up the screen
        transform.position += Vector3.up * speed * Time.deltaTime;

        // Check if the dragon is touching the branch

    }

  void OnTriggerEnter2D(Collider2D collision) {
      if (!gm.gameplayActive){return;}

    if (collision.gameObject.tag == "Root"){
        Destroy(collision.gameObject);
        gm.SubtractLife();
        Destroy(this.gameObject);
    }

    if (collision.gameObject.tag == "Magic"){
        Destroy(collision.gameObject);
        gm.AddPoints();
        Destroy(this.gameObject);
    }
  }


}
