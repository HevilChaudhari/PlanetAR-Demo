using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    private const string PLANET_INDEX = "planetIndex";
    private const string PLANET_AR = "_PlanetAR";
    private const string HOME_SCREEN = "_HomeScreen";

    public void LoadPlanet(int planetId)
    {
        PlayerPrefs.SetInt(PLANET_INDEX, planetId);
        SceneManager.LoadScene(PLANET_AR);
    }

    public void LoadHomeScreen()
    {
        SceneManager.LoadScene(HOME_SCREEN);
    }
}
