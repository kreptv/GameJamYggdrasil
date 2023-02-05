using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropMagicScript : MonoBehaviour
{
  public GameManager gm;
  public GameObject magic;
  public float cooldownTime = 2f;
  public bool cooldown = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    IEnumerator CooldownWait(){
       yield return new WaitForSeconds(cooldownTime);
       cooldown = false;
   }

    // Update is called once per frame
    void Update()
    {
        if (!gm.gameplayActive){return;}
      if (Input.GetKey(KeyCode.Space) && (cooldown == false)){
          gm.pms.animator.SetBool("Throwing", true);
          GameObject spawnMagic = Instantiate(magic, gm.pms.gameObject.transform.position, gm.pms.gameObject.transform.rotation);
          cooldown = true;
          StartCoroutine(CooldownWait());
      }

    }

    void LateUpdate(){
        if (!gm.gameplayActive){return;}
      gm.pms.animator.SetBool("Throwing", false);
    }
}
