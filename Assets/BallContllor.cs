using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallContllor : MonoBehaviour {

	//ボールが見える可能性があるz軸の最大値
	private float visiblePosZ = -6.5f;

	//ゲームオーバーを表示するテキスト
	private GameObject gameoverText;

	//ゲームのscore
	private int score;

	//ゲームのscoreを表示するテキスト
	private GameObject scoreText;

	// Use this for initialization
	void Start () {
		//シーン中のGameOverTextオブジェクトを取得
		this.gameoverText = GameObject.Find("GameOverText");
		//シーン中のscoreTextオブジェクトを取得
		this.scoreText = GameObject.Find("ScoreText");
		
	}
	
	// Update is called once per frame
	void Update () {
		//ボールが画面外に出た場合
		if (this.transform.position.z < this.visiblePosZ) {
			//GameOverTextにベームオーバを表示
			this.gameoverText.GetComponent<Text> ().text = "Game Over";
		}
	}

	//衝突時に呼ばれる関数
	void OnCollisionEnter(Collision other) {

		if (other.gameObject.tag == "SmallStarTag") {
			//scoreを表示
			this.scoreText.GetComponent<Text> ().text = "score:"+(score += 10);
		} else if (other.gameObject.tag == "LargeStarTag") {
			//scoreを表示
			this.scoreText.GetComponent<Text> ().text = "score:"+(score += 25);
		} else if (other.gameObject.tag == "SmallCloudTag"){
			//scoreを表示
			this.scoreText.GetComponent<Text> ().text = "score:"+(score += 20);
		} else if (other.gameObject.tag == "LargeCloudTag"){
			//scoreを表示
			this.scoreText.GetComponent<Text> ().text = "score:"+(score += 35);
		}
			
	}
}
