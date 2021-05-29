using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public GameObject laserPrefab;
    
    public float speed = 5;

    bool leftButtonPressed = false;
    bool rightButtonPressed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 244;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || rightButtonPressed)
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || leftButtonPressed)
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        }

    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    public void SetRightButtonClicked(bool pressed)
    {
        rightButtonPressed = pressed;
    }

    public void SetLeftButtonClicked(bool pressed)
    {
        leftButtonPressed = pressed;
    }

    public void Attack()
    {
        GameObject laser = Instantiate(laserPrefab);
        laser.transform.position = transform.position + new Vector3(0, 1, 0);
    }
}
