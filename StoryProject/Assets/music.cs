using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip musicClip; // Bu scriptte �alacak m�zik par�as� i�in bir AudioClip referans�
    private AudioSource audioSource; // Bu scriptin AudioSource'u

    void Start()
    {
        // Bu GameObject'e AudioSource bile�eni ekle ve ayarla
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = musicClip; // Bu scriptin m�zik par�as�n� ata
        audioSource.playOnAwake = false; // Oyun ba�lad���nda otomatik �almamas� i�in
    }

    void Update()
    {
        // "M" tu�una bas�ld���nda t�m AudioSource'lar� durdur ve bu m�zi�i �al
        if (Input.GetKeyDown(KeyCode.M))
        {
            // T�m AudioSource bile�enlerini bul ve durdur
            foreach (AudioSource source in FindObjectsOfType<AudioSource>())
            {
                source.Stop();
            }

            // Sadece bu scriptin AudioSource'unu �al
            if (!audioSource.isPlaying)
            {
                audioSource.Play(); // Bu m�zi�i �al
            }
        }
    }
}




