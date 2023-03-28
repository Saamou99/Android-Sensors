using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicFadeIn : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5f);
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        float t = 0f;
        while (t < 10f)
        {
            t += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(0f, 0.5f, t / 10f);
            yield return null;
        }
    }

}
