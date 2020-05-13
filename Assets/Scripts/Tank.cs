using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed = 2f;
    public GameObject Missile;
    private GameObject missile_prefab;

    // Start is called before the first frame update
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.RightArrow)) && (transform.position.x < 8.6f))
        {   
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            Missile.transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        
        if ((Input.GetKey(KeyCode.LeftArrow)) && (transform.position.x > -8.9f))
        {   
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            Missile.transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            missile_prefab = Instantiate(Missile, new Vector3(transform.position.x+0.14f, -4.49f, -2f), Quaternion.identity) as GameObject;
            missile_prefab.AddComponent<Missile>();
            Destroy(missile_prefab, 2f);
        }
    }

}
