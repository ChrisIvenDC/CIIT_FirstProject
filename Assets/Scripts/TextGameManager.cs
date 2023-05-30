using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class NewBehaviourScript : MonoBehaviour
{

    public TextMeshProUGUI storytextMeshPro, hptextMeshPro, statextmeshPro;
    public string storyText;
    public int HPVal, StaVal;
    public GameObject Level1_Object, PostThornyPath_Object, PostGravelPath_Object;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        storytextMeshPro.text = storyText;
        hptextMeshPro.text = HPVal.ToString();
        statextmeshPro.text = StaVal.ToString();    
    }
    
    
    //LEVEL1
    public void ThornyPath()
    {
        storyText = "You managed to get pass through despite having cuts and bruises all over your body, You also found a Steel Sword on the way! Now there's a plant monster in front of you, What do you do?";
        HPVal = HPVal - 5;
        StaVal = StaVal - 3;
        Level1_Object.SetActive(false);
        PostThornyPath_Object.SetActive(true);
    }

    public void GravelPath()
    {
        storyText = "You went through Unscathed, But now theres a huge plant monster in front of you. What do you do?";

        Level1_Object.SetActive(false);
        StaVal = StaVal - 1;
        PostThornyPath_Object.SetActive(true);
    }

    public void HugeFootPrints()
    {
        storyText = "While following the path, the footprint stopped midway. You heard a low growl. A huge mosnter ate you. You died.";
        HPVal = HPVal - 10;
        StaVal = StaVal - 10;

        Level1_Object.SetActive(false);
    }

    //LEVEL 2


}
