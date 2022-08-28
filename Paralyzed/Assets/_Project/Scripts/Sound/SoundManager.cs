using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SoundManager : MonoBehaviour
{
	[Header("AudioSOurces")]
	[SerializeField]private AudioSource a_EffectsSource;
	[SerializeField]private AudioSource a_MusicSource;

	[Header("Pitchs")]
	[SerializeField]private float f_LowPitchRange = .95f;
	[SerializeField]private float f_HighPitchRange = 1.05f;
	
	public static SoundManager Instance = null;
	
	
	private void Awake()
	{
		
		if (Instance == null)
		{
			Instance = this;
		}
		
		else if (Instance != this)
		{
			Destroy(gameObject);
		}
		
		DontDestroyOnLoad (gameObject);
	}
	
	public void Play(AudioClip clip)
	{
		a_EffectsSource.clip = clip;
		a_EffectsSource.Play();
	}
	
	public void PlayMusic(AudioClip clip)
	{
		a_MusicSource.clip = clip;
		a_MusicSource.Play();
	}
	
	public void RandomSoundEffect(params AudioClip[] clips)
	{
		int randomIndex = Random.Range(0, clips.Length);
		float randomPitch = Random.Range(f_LowPitchRange, f_HighPitchRange);
		a_EffectsSource.pitch = randomPitch;
		a_EffectsSource.clip = clips[randomIndex];
		a_EffectsSource.Play();
	}
	
}