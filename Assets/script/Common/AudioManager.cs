using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace audio
{
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager instance;
        [SerializeField] private AudioMixer audioMixer;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void SetMasterVolume(float volume)
        {
            audioMixer.SetFloat("Master", volume);
        }

        public void SetBgmVolume(float volume)
        {
            audioMixer.SetFloat("BGM", volume);
        }

        public void SetSeVolume(float volume)
        {
            audioMixer.SetFloat("SE", volume);
        }
    }
}