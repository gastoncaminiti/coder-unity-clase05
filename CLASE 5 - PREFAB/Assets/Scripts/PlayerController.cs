using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int lifePlayer = 3;
    public string namePlayer = "Mr. Blue";
    public float speedPlayer = 100.0f;
    public GameObject swordPlayer;
    public Vector3 initPosition = new Vector3(4, 2, 1);
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EN EL FRAME INICIAL...");
        transform.position = initPosition;
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        Debug.Assert(lifePlayer > 0);
        swordPlayer.GetComponent<SwordController>().SetSwordName("Espadon 9000");
        //Debug.Log(swordPlayer.GetComponent<SwordController>().nameSword);
        Debug.Log(swordPlayer.GetComponent<SwordController>().GetSwordName());
        //swordPlayer.transform.position = transform.position + new Vector3(0,0,1);
        swordPlayer.transform.position   = transform.position + Vector3.forward;
        swordPlayer.transform.localScale = transform.localScale;
        //Debug.Break();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("EN CADA FRAME...");
    }
}
