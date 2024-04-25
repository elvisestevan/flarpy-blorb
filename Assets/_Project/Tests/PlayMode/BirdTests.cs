using NUnit.Framework;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class BirdTests
{

    private string sceneToTest = "SampleScene";
    
    [UnityTest]
    public IEnumerator Jump()
    {
        yield return SceneManager.LoadSceneAsync(sceneToTest, LoadSceneMode.Additive);

        var gameObject = GameObject.FindWithTag("Player");
        Assert.NotNull(gameObject);
        var bird = gameObject.GetComponent<BirdScript>();

        Assert.NotNull(bird.GetComponent<Rigidbody2D>());

        yield return new WaitForSeconds(0.1f);

        var beforeJumpYPosition = bird.transform.position.y;

        bird.Jump();

        yield return new WaitForSeconds(0.1f);

        var afterJumpYPosition = bird.transform.position.y;

        Assert.Greater(afterJumpYPosition, beforeJumpYPosition);

        yield return SceneManager.UnloadSceneAsync(sceneToTest);
    }
}
