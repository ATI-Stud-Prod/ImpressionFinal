using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public Vector3 deplacement;
    public GameObject prefabObstacle;
    public Canvas message;
    public AudioSource tickSource;
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public float speed;
    public float clampX;
    public int vitesse;

    // Start is called before the first frame update
    void Start()
    {
        tickSource = GetComponent<AudioSource>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        float i = Input.GetAxisRaw("Vertical");

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -clampX, clampX);
        pos.y = Mathf.Clamp(pos.y, -clampX, clampX);
        transform.position = pos;
        float h = Input.GetAxisRaw("Horizontal");
        transform.Translate(new Vector3(h,i,0)  * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("damage");
            tickSource.Play();

            TakeDamage(20);

        }
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            tickSource.Play();
            TakeDamage(10);
        }

    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}