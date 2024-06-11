using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //[SerializeField]
    //private Text _title;
    //
    //public int points = 0;
    private void OnTriggerEnter(Collider other)
    {
        //points += 1;
        //_title.text = points.ToString();
        Destroy(gameObject);
    }

        

}

