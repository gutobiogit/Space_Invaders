using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Missile : MonoBehaviour
{
    public float speed1 = 2f;
    public float speed2 = 10f;
    private ParticleSystem ps;
    public Text Score;
    public GameObject Explosion;
    private int sub_score;

    // Start is called before the first frame update
    void Start()
    {
        ps = Object.FindObjectOfType<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed1 * Time.deltaTime);
        if (transform.position.y > -3.0f)
        {
            ps.Play();
            transform.Translate(Vector2.up * speed2 * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.CompareTag("Enemy4")) && (other.isActiveAndEnabled))
        {
            GameObject explode = Instantiate(Explosion) as GameObject;
            explode.transform.position = transform.position;
            sub_score = int.Parse(Score.text);
            sub_score += 10;
            Score.text = sub_score.ToString();
            Destroy(explode, .2f);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if ((other.CompareTag("Enemy3")) && (other.isActiveAndEnabled))
        {
            GameObject explode = Instantiate(Explosion) as GameObject;
            explode.transform.position = transform.position;
            sub_score = int.Parse(Score.text);
            sub_score += 25;
            Score.text = sub_score.ToString();
            Destroy(explode, .2f);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if ((other.CompareTag("Enemy")) && (other.isActiveAndEnabled) )
        {
            GameObject explode = Instantiate(Explosion) as GameObject;
            explode.transform.position = transform.position;
            sub_score =int.Parse(Score.text);
            sub_score += 50;
            Score.text = sub_score.ToString();
            Destroy(explode, .2f);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if ((other.CompareTag("Shield")) && (other.isActiveAndEnabled) )
        {
            GameObject explode = Instantiate(Explosion) as GameObject;
            explode.transform.position = transform.position;
            Destroy(explode, .2f);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
        

}