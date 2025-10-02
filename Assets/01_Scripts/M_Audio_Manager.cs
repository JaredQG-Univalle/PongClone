using UnityEngine;

public class M_Audio_Manager : MonoBehaviour
{
    // --- Audio Sources ---
    private AudioSource musicAS;
    private AudioSource sfxAS;

    // --- Volúmenes ---
    public float musicVol = 0.5f;
    public float sfxVol = 1f;

    // --- Clips ---
    private AudioClip backgroundMusic;
    private AudioClip jumpSFX;
    private AudioClip hitSFX;

    // --- Singleton ---
    public static M_Audio_Manager instance;

    private void Awake()
    {
        // Singleton
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // Crear dos AudioSource en este mismo GameObject
        musicAS = gameObject.AddComponent<AudioSource>();
        sfxAS = gameObject.AddComponent<AudioSource>();

        // Configuración inicial
        musicAS.volume = musicVol;
        musicAS.loop = true;

        sfxAS.volume = sfxVol;
        sfxAS.loop = false;
    }

    void Start()
    {
        // Cargar desde carpeta Resources/M_AudioSource/
        backgroundMusic = Resources.Load<AudioClip>("M_AudioSource/background_music");
        jumpSFX = Resources.Load<AudioClip>("M_AudioSource/jump");
        hitSFX = Resources.Load<AudioClip>("M_AudioSource/hit");

        // Reproducir música al inicio
        if (backgroundMusic != null)
        {
            SetMusic(backgroundMusic);
        }
    }

    void Update()
    {
        // Ejemplo: Space → salto, H → golpe
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlaySound(jumpSFX);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            PlaySound(hitSFX);
        }
    }

    // --- Métodos públicos ---
    public void PlaySound(AudioClip clip)
    {
        if (clip != null)
        {
            sfxAS.PlayOneShot(clip);
        }
    }

    public void SetMusic(AudioClip clip)
    {
        if (clip != null)
        {
            musicAS.Stop();
            musicAS.clip = clip;
            musicAS.Play();
        }
    }
}
