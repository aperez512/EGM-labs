using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSprite: MonoBehaviour
{
    public string up;
    public string left;
    public string right;
    public string down;
    public Rigidbody2D myRigid;
    ParticleSystem myPart;
    // Start is called before the first frame update
    void Start()
    {
        myPart = GameObject.Find("Engine").GetComponent<ParticleSystem>();
        myRigid = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(left))
        {
            this.transform.Rotate(new Vector3(0f, 0f, 100f) * Time.deltaTime);
        }
        if (Input.GetKey(right))
        {
            this.transform.Rotate(new Vector3(0f, 0f, -100f) * Time.deltaTime);
        }
    }
    void FixedUpdate()
    {
        if (Input.GetKey(up))
        {
            if (!myPart.isPlaying)
            {
                myPart.Simulate(1);
                myPart.Play();
            }

            myRigid.AddForce(this.transform.up * 5);
        }
        else if (Input.GetKey(down))
        {
            if (myPart.isPlaying)
            {
                myPart.Stop();
                Debug.Log("Stopping");
            }
            myRigid.AddForce(this.transform.up * -3);
        } else
        {
            if (myPart.isPlaying)
            {

                myPart.Stop();
                Debug.Log("Stopping");
            }
        }
    }


}
