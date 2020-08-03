﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FafaTools.Utils.Array;

namespace FafaTools.Audio
{
	[CreateAssetMenu(menuName = "FafaTools/Audio/SimpleMusic")]
	public class SimpleMusic : AudioEvent
	{
		private bool m_IsPlaying;
		private int m_Index;

		public override void Play(AudioSource source)
		{
			source.clip = m_Clips[Random.Range(0, m_Clips.Length)];
			source.loop = m_IsLooping;
			source.Play();
		}

		public void PlayNext(AudioSource source)
		{
			m_Index = m_Index < m_Clips.Length - 1 ? m_Index + 1 : 0;
			source.clip = m_Clips[m_Index];
			source.loop = false;
			source.Play();
		}

		public IEnumerator StartMusic(AudioSource source)
		{
			m_IsPlaying = true;
			m_Index = -1;
			ArrayExtension.Shuffle(this.m_Clips);//On randomize les music
			while (true)
			{
				if (m_IsPlaying && !source.isPlaying)
					PlayNext(source);

				if (m_IsPlaying && source.isPlaying)//On arrete la music si 
					source.Stop();

				yield return null;
			}
		}

        #region GET/SET

        public bool IsPlaying
        {
			set
            {
				m_IsPlaying = value;
            }
            get
			{
				return m_IsPlaying;
			}
        }

        #endregion
    }
}
