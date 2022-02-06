using System.Globalization;
using TMPro;
using UnityEngine;

public class FPS : MonoBehaviour
{
     public TMP_Text fpsText;
 
     private void Start()
     {
         Application.targetFrameRate = 120;
     }
     
     private void Update() 
     {
         var fps = (int)(1f / Time.unscaledDeltaTime);
         fpsText.text = Mathf.Ceil(fps).ToString(CultureInfo.InvariantCulture);
     }
}
