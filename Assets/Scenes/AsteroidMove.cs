using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
public class AsteroidMove : MonoBehaviour
{
    public int rotz; public int mx, my; public Rigidbody2D myRigid;    //�Use�this�for�initialization����
    void�Start�()�{
        myRigid = this.GetComponent<Rigidbody2D>();
        myRigid.AddForce(Vector3.up* my);
        myRigid.AddForce(Vector3.right* mx);
        myRigid.AddTorque(rotz);����}����//�Update�is�called�once�per�frame����
    void�Update�()�{����
    }
}
