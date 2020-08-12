using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public GameObject human;
    public static FirstPersonCamera instance;
    public Vector3 offset;
    Vector3 targetPosition;
    Vector3 pos;
    Vector3 velocity;

    public bool gameOver;



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        offset = human.transform.position - transform.position;
        gameOver = false;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!gameOver)
        {
            follow();
        }

    }

    public void follow()
    {
        pos = transform.position;



        velocity = human.GetComponent<Rigidbody>().velocity;
        targetPosition = human.transform.position - offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, 0.0001f * Time.deltaTime);
        //pos = Vector3.Lerp(pos, targetPosition, 5f * Time.deltaTime);

        //transform.position = Vector3.Slerp(transform.position,targetPosition, 1f);
    }
}
