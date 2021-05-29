using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeteorController : MonoBehaviour
{
    private int speed;

    private void Start()
    {
        this.speed = Random.Range(1, 3) * Level.Instance.meteorSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)    
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        } else if (collision.gameObject.tag == "laser")
        {
            Destroy(gameObject);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, this.speed, 0) * Time.deltaTime;

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
