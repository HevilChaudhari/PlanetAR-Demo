using UnityEngine;

public class SetPlanet : MonoBehaviour
{
    private const string PLANET_INDEX = "planetIndex";

    //Scriptable Object for Storing Planet Textures
    [SerializeField]private SO_PlanetTextures _planetTextures;

    private Renderer _renderer;

    //=====Awake Method
    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    //=====Start Method
    private void Start()
    {
        int planetID = PlayerPrefs.GetInt(PLANET_INDEX, 0);
        SetPlanetTexture(planetID);
    }


    //=====Set the Planet texture
    private void SetPlanetTexture(int planetIndex)
    {
        if(_renderer != null)
        {
            _renderer.material.mainTexture = _planetTextures.Planet_textures[planetIndex];
        }
    }
}
