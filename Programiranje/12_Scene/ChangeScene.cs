﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int brojScene;
	
	public void UcitajScenu()
	{
		SceneManager.LoadScene(brojScene);
	}
}
