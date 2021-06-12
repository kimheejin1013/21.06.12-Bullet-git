using System.Collections;
using UnityEngine;

 public class Block : MonoBehaviour
 {

     private void Update()
     {

        //1.GameObject.Find() 하고 GetComponent
        if (transform.localPosition.y <= -20.0f)
        {
            //GameObject go = GameObject.Find("Score Text");
            //ScoreModule module = go.GetComponent<ScoreModule>();
            //module.AddCount();

            //Destroy(gameObject);


        //2.FindObjectOfType<>
            FindObjectOfType<ScoreModule>().AddCount();
            Destroy(gameObject);
        }

    }


}
