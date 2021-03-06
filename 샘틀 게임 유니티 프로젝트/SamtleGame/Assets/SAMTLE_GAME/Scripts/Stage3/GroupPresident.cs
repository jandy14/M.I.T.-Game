﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MIT.SamtleGame.Stage3;

public class GroupPresident : NPCController
{
	public GameObject obj;

	void Start()
	{
		base.Start();
		StartCoroutine(Sequence());
	}
	void Update()
	{
		
	}
    IEnumerator Sequence()
	{
		//Move(new Vector3(-36.84f,0,-1.71f));
		//yield return new WaitUntil(() => !_isworking);

		_anim.SetTrigger("LookAround");
		yield return new WaitUntil(() => GameManager.Instance.AllDone() && !GameManager.Instance._player._controller._isFocusing);
		_anim.SetTrigger("PickingUP");
		yield return new WaitForSeconds(4f);
		PickObject();
		yield return new WaitForSeconds(1.4f);

		float dist = Vector3.Distance(transform.position, GameManager.Instance._player.transform.position);
		float ratio = (dist - 4.5f) / dist;
		ratio = ratio < 0.01f ? 0.01f : ratio;
		Vector3 dest = Vector3.Lerp(transform.position, GameManager.Instance._player.transform.position, ratio);
		Move(dest);
		yield return new WaitUntil(() => !_isworking);

		_anim.SetTrigger("Give");
		yield return new WaitUntil(() => !obj.activeInHierarchy); // some trigger
		_anim.SetTrigger("EndGive");
	}
	public void PickObject()
	{
		obj.SetActive(true);
	}
	public void GiveObject()
	{
		obj.SetActive(false);
	}
}
