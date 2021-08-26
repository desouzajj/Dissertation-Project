using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioSource BGMSource, SFXSource;

    [SerializeField] AudioClip trashCollect, throwawayGD, throwawayBD, buttonClick, lvl1, lvl2, lvl3, menu;


    public static Audio instance;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance != this && instance != null)
        {

            Destroy(gameObject);

        }
        else
        {
            instance = this;
            
        }
        var sources = GetComponents<AudioSource>();
        BGMSource = sources[0];
        SFXSource = sources[1];
        //StartCoroutine(checklevel());
        //if (SceneManager.GetActiveScene().buildIndex == 1)
        //{
        //    Debug.Log("audiohere");
        //    BGMSource.clip = lvl1;
        //    BGMSource.Play();
        //}
        //transform.position = Camera.main.transform.position;
    }

    //IEnumerator checklevel()
    //{
    //    yield return new WaitForSeconds(0.1f);
    //    if (SceneManager.GetActiveScene().buildIndex == 1)
    //    {
            
    //        Debug.Log("audiohere");
    //        BGMSource.clip = lvl1;
    //        BGMSource.Play();
    //    }
    //    Debug.Log(SceneManager.GetActiveScene().buildIndex);
    //}
    private void Start()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        //if (SceneManager.GetActiveScene().buildIndex == 1)
        //{
        //    Debug.Log("audiohere");
        //    BGMSource.clip = lvl1;
        //    BGMSource.Play();
        //}

        var bmg = PlayerPrefs.GetFloat("BGMVol", 1.0f);
        var sfx = PlayerPrefs.GetFloat("SFXVol", 1.0f);

    }

    public void MusicVolume(float val)
    {
        BGMSource.volume = val;
        PlayerPrefs.SetFloat("BGMVol", val);
    }

    public void lvl1audio()
    {
        BGMSource.clip = lvl1;
        BGMSource.Play();
    }
    public void lvl2audio()
    {
        BGMSource.clip = lvl2;
        BGMSource.Play();
    }
    public void lvl3audio()
    {
        BGMSource.clip = lvl3;
        BGMSource.Play();
    }
    public void mainMenu()
    {
        BGMSource.clip = menu;
        BGMSource.Play();
    }
    public void SoundVolume(float val)
    {
        SFXSource.volume = val;
        PlayerPrefs.SetFloat("SFXVol", val);
    }


    public void TrashPickUp()
    {
        SFXSource.clip = trashCollect;
        SFXSource.Play();
    }

    public void TrashThrowAwayGOOD()
    {
        SFXSource.clip = throwawayGD;
        SFXSource.Play();
    }
    public void TrashThrowAwayBAD()
    {
        SFXSource.clip = throwawayBD;
        SFXSource.Play();
    }
    public void ButtonClick()
    {
        SFXSource.clip = buttonClick;
        SFXSource.Play();
    }

}

