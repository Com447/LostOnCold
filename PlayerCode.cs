using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCode : MonoBehaviour
{
    //private KillPlayer kp;
    public GameObject uiTextDead;
    public GameObject uiTextContinue; 
    public bool timerStart = false;
    public bool timerCoolDownStart = false;
    public GameObject FadeOnDead;
    public Rigidbody playerRB;
    public CameraShake cameraShake;
    public bool playerIsDead = false;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
       // kp = GameObject.FindGameObjectWithTag("KillPlayer").GetComponent<KillPlayer>();
        uiTextDead.SetActive(false);
        uiTextContinue.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsDead == true)
        {
           FadeOnDead.SetActive(true);
           StartCoroutine(WaitforSecc());
           StartCoroutine(WaitForSec());
           playerRB.constraints = RigidbodyConstraints.FreezePosition;
           playerRB.constraints = RigidbodyConstraints.FreezeRotation;
           StartCoroutine(cameraShake.Shake(15,.4f));

        }
        
        
        
        if (timerStart == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                FadeOnDead.SetActive(false);
                Destroy(uiTextDead);  
                Destroy(uiTextContinue);

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

                timerStart = false;
            }
        }
    }
    
    IEnumerator WaitForSec()// กดเพื่อไปต่อ
    {
        yield return new WaitForSeconds(8);
        timerStart = true;
        uiTextContinue.SetActive(true);
    }

    IEnumerator WaitforSecc() // รอให้fadeขึ้นครบ
    {
        yield return new WaitForSeconds(4);
        uiTextDead.SetActive(true);
    }
    
}
