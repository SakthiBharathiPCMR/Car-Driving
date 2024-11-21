using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5.31f, -7.84f);


    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {


    }

    void LateUpdate()
    {

        transform.position = player.transform.position + offset;

    }
}
