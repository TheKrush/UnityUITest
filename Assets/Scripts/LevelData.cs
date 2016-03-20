using UnityEngine;
using System.Collections.Generic;

public class LevelData : MonoBehaviour
{
    public List<MobWave> Waves = new List<MobWave>();

    private struct WaveCreationParams
    {
        public MobWave.WaveType Type;
        public string Path;
    }
}
