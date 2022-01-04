using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public Transform player;
    public float vitesse = .125f;
    public Vector3 offset;
    void Start()
    {
        //girlPos = GetComponent<CeriseGirl>().transform.position;
    }

    void FixedUpdate()
    {
        MoveWithPlayer();
        //FollowStraight();
    }
    void MoveWithPlayer()
    {
        Vector3 ciblePos = player.position + offset;
        Vector3 positionFinal = Vector3.Lerp(transform.position, ciblePos, vitesse );
        transform.position = positionFinal;
        transform.LookAt(player);
    }


    void FollowStraight()
    {
        Vector3 ciblePos = player.position + offset;
        ciblePos.z = transform.position.z;
        transform.position = Vector3.Lerp(ciblePos, transform.position, vitesse * Time.deltaTime);

    }

}
