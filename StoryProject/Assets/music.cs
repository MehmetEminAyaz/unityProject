using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip musicClip; // Bu scriptte çalacak müzik parçasý için bir AudioClip referansý
    private AudioSource audioSource; // Bu scriptin AudioSource'u

    void Start()
    {
        // Bu GameObject'e AudioSource bileþeni ekle ve ayarla
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = musicClip; // Bu scriptin müzik parçasýný ata
        audioSource.playOnAwake = false; // Oyun baþladýðýnda otomatik çalmamasý için
    }

    void Update()
    {
        // "M" tuþuna basýldýðýnda tüm AudioSource'larý durdur ve bu müziði çal
        if (Input.GetKeyDown(KeyCode.M))
        {
            // Tüm AudioSource bileþenlerini bul ve durdur
            foreach (AudioSource source in FindObjectsOfType<AudioSource>())
            {
                source.Stop();
            }

            // Sadece bu scriptin AudioSource'unu çal
            if (!audioSource.isPlaying)
            {
                audioSource.Play(); // Bu müziði çal
            }
        }
    }
}




