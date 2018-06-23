using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class MovieUrl : MonoBehaviour {

     string path = "C:\\Users\\Administrator.USER-20180109JC\\Desktop\\Cinematic Enus.ogv";
      MovieTexture movie;
    public RawImage movierawimage;
     AudioSource movieaudio;
    void Start()
    {
        movieaudio = GetComponent<AudioSource>();
         WWW www = new WWW("file:///" + path);
       
        movie = www.movie;
        movierawimage.texture = movie;
        movie.loop = false;
        movieaudio.clip = movie.audioClip;


        movie.Play();
        movieaudio.Play();
    }



}
