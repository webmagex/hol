﻿/*
* Copyright 2016 European Commission
*
* Licensed under the EUPL, Version 1.1 or – as soon they
will be approved by the European Commission - subsequent
versions of the EUPL (the "Licence");
* You may not use this work except in compliance with the
Licence.
* You may obtain a copy of the Licence at:
*
* https://joinup.ec.europa.eu/software/page/eupl5
*
* Unless required by applicable law or agreed to in
writing, software distributed under the Licence is
distributed on an "AS IS" basis,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
express or implied.
* See the Licence for the specific language governing
permissions and limitations under the Licence.
*/ 

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AboutEvents : MonoBehaviour {

	//VAR 4 Textify
	private string[] strgs;
	
	public Button backBtn;
	public Text titleTxt;
	public Text contentTxtArea;
	//

	void Start () 
	{
		LangTxt();
	}
	//Textify
	void LangTxt () 
	{
		TextAsset qAsset = null;
		string suffix = PlayerPrefs.GetString ("linguaSuffix");
		string fname = "Text/menu_" + suffix;
		qAsset = (TextAsset)Resources.Load(fname);
		string testoIntero = qAsset.text;
		strgs = testoIntero.Split ("\r\n" [0]);
		
		string[] strg = strgs [13].Split ('=');
		Text t1 = backBtn.GetComponentInChildren<Text> ();
		t1.text = strg[1];
		
		strg = strgs [6].Split ('=');
		titleTxt.text=strg[1];

		fname = "Text/about_" + suffix;
		qAsset = (TextAsset)Resources.Load(fname);
		testoIntero = qAsset.text;
		contentTxtArea.text = testoIntero;
	}

	/*
	 * The function backToMain is called by the menu button.
	 * It loads the MainMenu scene
	 * 
	 */
	public void backToMain() {
		//Application.LoadLevel("MainMenu");
		SceneManager.LoadScene("MainMenu");
	}

	/*
	 * The function openPage is called by the link button. 
	 * It opens the JRC game description page.
	 * 
	 * Actually this function is no longer used anymore
	 */
	public void openPage() {
		Application.OpenURL ("https://ec.europa.eu/jrc/en/scientific-tool/happy-onlife-game-raise-awareness-internet-risks-and-opportunities");
	}
}
