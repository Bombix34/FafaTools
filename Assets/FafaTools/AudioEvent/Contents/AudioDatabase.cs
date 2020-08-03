using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FafaTools.Audio
{
    [CreateAssetMenu(menuName = "FafaTools/Audio/AudioDatabase")]
    public class AudioDatabase : SingletonScriptableObject<AudioDatabase>
    {
        public List<AudioDataField> m_Datas;


    }

    [System.Serializable]
    public struct AudioDataField
    {
        public string m_EnumFieldName;
        public AudioEvent m_AudioEvent;
    }
}

