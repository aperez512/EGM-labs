using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSprite : MonoBehaviour
{
    public string left;
    public string right;
    public string up;
    public string fire;
    public GameObject bullet;




    Rigidbody2D myRigid;
    public ParticleSystem myPart;
    public float lastFired;


    void Start()
    {
        
        myPart = GameObject.Find("Engine").GetComponent<ParticleSystem>();
        myRigid = this.GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        GameObject tmpBullet;

        if (Input.GetKey(left))
        {
            this.transform.Rotate(new Vector3(0f, 0f, 100f)
               * Time.deltaTime);
        }

        if (Input.GetKey(right))
        {
            this.transform.Rotate(new Vector3(0f, 0f,
                -100f) * Time.deltaTime);
        }

        if (Input.GetKey(fire))
        {
            if (Time.time > lastFired + 1)
            {
                Debug.Log("Fired");
                tmpBullet = Instantiate(bullet, this.transform.position +
                     (this.transform.up), this.transform.rotation);
                lastFired = Time.time;
                
            }
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(up))
        {
            if(!myPart.isPlaying)
                myPart.Play();

            myRigid.AddForce(this.transform.up * 50 * Time.deltaTime);
            
        }
        else
        {
            if(myPart.isPlaying)
                myPart.Stop();

        }

    }
}
