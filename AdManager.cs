/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;
public class AdManager : MonoBehaviour, IUnityAdsListener
{
   /*
   public float newrotation;
   public GameObject car;
   public GameObject ObsSpawner;
   public GameObject GameOver;
   private GameManager gameManager;
   private CarSelection carselection;
#if UNITY_IOS
   private string gameId = "4150614";
#elif UNITY_ANDROID
   private string gameId = "4150615";
#endif
   private Deleteprops deleteprops;
   bool testMode = true;
   string mySurfacingId = "Rewarded_Android";
   void Start()
   {

       // Initialize the Ads service:
       Advertisement.AddListener(this);
       Advertisement.Initialize(gameId, testMode);
   }

   public static void ShowInterstitialAd()
   {
       // Check if UnityAds ready before calling Show method:
       if (Advertisement.IsReady())
       {
           Advertisement.Show();
           // Replace mySurfacingId with the ID of the placements you wish to display as shown in your Unity Dashboard.
       }
       else
       {
           Debug.Log("Interstitial ad not ready at the moment! Please try again later!");
       }
   }

   public void ShowRewardedVideo()
   {
       // Check if UnityAds ready before calling Show method:
       if (Advertisement.IsReady(mySurfacingId))
       {
           Advertisement.Show(mySurfacingId);
       }
       else
       {
           Debug.Log("Rewarded video is not ready at the moment! Please try again later!");
       }
   }

   // Implement IUnityAdsListener interface methods:
   public void OnUnityAdsDidFinish(string surfacingId, ShowResult showResult)
   {
       // Define conditional logic for each ad completion status:
       if (showResult == ShowResult.Finished)
       {
           car.transform.rotation = Quaternion.Euler(0, 0, 0);

           StartCoroutine(wait());
           Deleteprops.caralive = true;
           GameOver.SetActive(false);

           PlayerPrefs.SetFloat("PocketMoney", CarSelection.PocketMoney);

           // Reward the user for watching the ad to completion.
       }
       else if (showResult == ShowResult.Skipped)
       {
           GameOver.SetActive(true);
           Deleteprops.caralive = false;
           // Do not reward the user for skipping the ad.
       }
       else if (showResult == ShowResult.Failed)
       {
           GameOver.SetActive(true);
           Deleteprops.caralive = false;
           Debug.LogWarning("The ad did not finish due to an error.");
       }
   }

   public void OnUnityAdsReady(string surfacingId)
   {
       // If the ready Ad Unit or legacy Placement is rewarded, show the ad:
       if (surfacingId == mySurfacingId)
       {
           // Optional actions to take when theAd Unit or legacy Placement becomes ready (for example, enable the rewarded ads button)
       }
   }

   public void OnUnityAdsDidError(string message)
   {
       // Log the error.
   }

   public void OnUnityAdsDidStart(string surfacingId)
   {
       // Optional actions to take when the end-users triggers an ad.
   }

   // When the object that subscribes to ad events is destroyed, remove the listener:
   public void OnDestroy()
   {
       Advertisement.RemoveListener(this);
   }
   IEnumerator wait()
   {

       yield return new WaitForSeconds(2);
       ObsSpawner.SetActive(true);
   }


}

*/