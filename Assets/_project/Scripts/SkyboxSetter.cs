using System.Collections.Generic;
using UnityEngine;


public class SkyboxSetter : MonoBehaviour
{
    [SerializeField] List<Material> _skyboxMaterials;



    void OnEnable()
    {
        ChangeSkybox(0);
    }

    void ChangeSkybox(int skyBox)
    {
            RenderSettings.skybox = _skyboxMaterials[skyBox];
        
    }
}
