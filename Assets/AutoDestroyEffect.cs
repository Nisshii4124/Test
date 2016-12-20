using UnityEngine;
using System.Collections;

public class AutoDestroyEffect : MonoBehaviour
{
    //パーティクルシステムの参照
    //キャッシュ
    ParticleSystem particle;

    // Use this for initialization
    void Start()
    {
        //リンクをはって捕まえておく
        particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        // パーティクルの再生が終了したらGameObjectを削除
        // パーティクルシステムが再生終了しているか？(isPlayingを見に行く)isPlayingはフラグになっている
        if (particle.isPlaying == false)
        {
            Destroy(gameObject);
        }
        /*
        if (particle = GetComponent<ParticleSystem>().isPlaying == false)
        {
            Destroy(gameObject);
        }
        StartとUpdate内の文を1つにしたもの
        これだと毎回データを探すときに頭から総当たりで探してしまう
        */
    }
}
