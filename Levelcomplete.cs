using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Levelcomplete : MonoBehaviour
{
    public TextMeshProUGUI complete;
    private void Start()
    {
        complete = GetComponent<TextMeshProUGUI>(); 
    }

    void Update()
    {
        if (Score.scoreValue == 15)
            StartCoroutine(lvl());
    }
    public IEnumerator lvl()
    {
        complete.GetComponent<TextMeshProUGUI>().enabled = true;
        yield return new WaitForSeconds(3f);
     
        loadnextscene();
    }
   public void loadnextscene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
