using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{

    private Rigidbody2D myRigid;
    public GameObject myPart;
    private GameStateManager gsm;


    // Use this for initialization
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();
        gsm = GameObject.Find("GameState").GetComponent<GameStateManager>();

    }

    // Update is called once per frame
    void Update()
    {

        myRigid.AddForce(this.transform.up * 250);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject part;



        if (collision.gameObject.tag == "Asteroid")
        {
            part = Instantiate(myPart,
                this.transform.position,
                this.transform.rotation);
            gsm.adjustScore(1);
            Destroy(collision.gameObject);
        }

        Destroy(this.gameObject);
    }
}
