using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController 
{

    private LevelModel theModel;
    private LevelView theView;

    public LevelController(LevelModel theModel, LevelView theView)
    {
        this.theView = theView;
        this.theModel = theModel;

    }

	

}
