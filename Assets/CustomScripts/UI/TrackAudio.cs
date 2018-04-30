using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrackAudio : MonoBehaviour {
    public AudioClip[] audioList;
    public AudioSource trackAudioSource;
    int trackNumber = 0;
    bool ispressed = false;
    bool isplaying = false;

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.M)) {
            if (!ispressed) {
                ispressed = true;
                isplaying = !isplaying;
            }
        }
        else {
            ispressed = false;
        }

        if (isplaying) {
            if (!trackAudioSource.isPlaying) {
                trackAudioSource.PlayOneShot(audioList[trackNumber], 1.0F);
                trackNumber = (trackNumber + 1) % (audioList.Length);
            }
        }
        else {
            trackAudioSource.Stop();
        }
    }
}
